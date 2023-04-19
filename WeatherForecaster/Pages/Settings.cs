using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherForecaster.Properties;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace WeatherForecaster.Pages
{
    public partial class Settings : DevExpress.XtraEditors.XtraUserControl
    {
        private static string HTTPGet(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            centigradeSwitch.IsOn = Global.UserHandle.DisplayCelcius;
            weatherAPIKey.Text = Global.WeatherAPIKey;
        }

        private void centigradeSwitch_Toggled(object sender, EventArgs e)
        {
            Global.UserHandle.DisplayCelcius = centigradeSwitch.IsOn;
        }

        private void weatherAPIKey_EditValueChanged(object sender, EventArgs e)
        {
            Global.WeatherAPIKey = weatherAPIKey.Text;
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You're about to fetch weather entries for the next 3 days from weatherapi.com for all cities loaded right now.\n\nYou have three options right now:\n\n" +
                "Yes: Fetch data into the database + local memory (MIGHT DUPLICATE DATA IF YOU FETCH MULTIPLE TIMES)\n\n " +
                "No: Fetch data into the local memory only (The data goes away after restarting)\n\n " +
                "Cancel: Exit fetching", "Fetching Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result != DialogResult.Yes && result != DialogResult.No) return;

            int weatherCount = 0;
            
            /*var asia = new Continent("Asia");
            var na = new Continent("North America");
            var eu = new Continent("Europe");

            // AS

            var pk = new Country("Pakistan", asia);
            new City("Karachi", pk);
            new City("Islamabad", pk);
            new City("Lahore", pk);

            var ag = new Country("Afghanistan", asia);
            new City("Kabul", ag);
            new City("Kandahar", ag);

            var ind = new Country("India", asia);
            new City("Mumbai", ind);
            new City("Delhi", ind);

            // NA

            var usa = new Country("United States", na);
            new City("New York", usa);
            new City("Houston", usa);


            var ca = new Country("Canada", na);
            new City("Toronto", ca);
            new City("Montreal", ca);

            // EU

            var uk = new Country(5, "United Kingdom", eu);
            new City("London", uk);
            new City("Edinburgh", uk);

            var de = new Country(6, "Germany", eu);
            new City("Berlin", de);
            new City("Frankfurt", de);*/

            foreach (var city in Global.Cities)
            {
                dynamic json = JObject.Parse(HTTPGet($"http://api.weatherapi.com/v1/forecast.json?key={Global.WeatherAPIKey}&q={city.GetName()}&aqi=no&alerts=no&days=3"));

                // JObject json = JObject.Parse(File.ReadAllText("test.json"));
                // json["location"]["name"].ToString()


                // json.forecast => forecastday[days]
                foreach (var day in json["forecast"]["forecastday"])
                {
                    // json.forecast.forecastday[i] => hour[hours], astro
                    foreach (var hour in day["hour"])
                    {
                        Weather w = new Weather(city);

                        w.Timestamp = DateTime.ParseExact(hour["time"].ToString(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                        w.Temperature = double.Parse(hour["temp_c"].ToString());
                        w.Humidity = int.Parse(hour["humidity"].ToString());
                        w.Precipitation = double.Parse(hour["precip_mm"].ToString());
                        w.Cloud = int.Parse(hour["cloud"].ToString());
                        w.WindKPH = double.Parse(hour["wind_kph"].ToString());
                        w.RainChance = int.Parse(hour["chance_of_rain"].ToString());
                        w.UVIndex = double.Parse(hour["uv"].ToString());

                        w.Contributor = null;

                        if(result == DialogResult.Yes)
                        {

                        }

                        weatherCount++;
                    }
                }
            }

            string fetchStr = "Fetched {weatherCount} weather entries into the local database for the cities: \n\n";
            foreach(var city in Global.Cities)
            {
                fetchStr += $"{city.GetName()} ({city.GetParent().GetName()})\n";
            }
            MessageBox.Show(fetchStr);
        }
    }
}
