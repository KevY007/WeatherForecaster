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
using System.Data.SqlClient;

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
            centigradeSwitch.IsOn = Global.UserHandle.DisplayCelsius;
            weatherAPIKey.Text = Global.WeatherAPIKey;
        }

        private void centigradeSwitch_Toggled(object sender, EventArgs e)
        {
            Global.UserHandle.DisplayCelsius = centigradeSwitch.IsOn;
        }

        private void weatherAPIKey_EditValueChanged(object sender, EventArgs e)
        {
            Global.WeatherAPIKey = weatherAPIKey.Text;
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if (Global.UserHandle.Privileges != PrivilegeLevels.Admin)
            {
                MessageBox.Show("This button is restricted to admins!", "You lack the required privileges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var allCities = new List<City>();

            foreach (var cont in Global.Continents)
            {
                foreach (var country in cont.Countries)
                {
                    allCities.AddRange(country.Cities);
                }
            }
            if (allCities.Count == 0)
            {
                MessageBox.Show("There should be at least one city loaded in the program to load data for!");
                return;
            }

            int rows = 0;

            foreach (var city in allCities)
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

                        try
                        {
                            string query = "INSERT INTO WeatherData (ParentID, Timestamp, Temperature, Condition, Cloud, Humidity, RainChance, Precipitation, UVIndex, WindKPH, ContributorID) OUTPUT INSERTED.ID VALUES ";
                            query += $"({city.GetId()}, '{(DateTime.ParseExact(hour["time"].ToString(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)).ToString("yyyy-MM-dd HH:mm")}', " +
                                $"{float.Parse(hour["temp_c"].ToString())}, '{(string)hour["condition"]["text"]}', {int.Parse(hour["cloud"].ToString())}, " +
                                $"{int.Parse(hour["humidity"].ToString())}, {int.Parse(hour["chance_of_rain"].ToString())}, " +
                            $"{float.Parse(hour["precip_mm"].ToString())}, {float.Parse(hour["uv"].ToString())}, {float.Parse(hour["wind_kph"].ToString())}, {Global.UserHandle.GetId()}); ";

                            SqlCommand cmd = new SqlCommand(query, Global.Database);
                            int aID = (int)cmd.ExecuteScalar();

                            city.AddWeather(new Weather(aID, DateTime.ParseExact(hour["time"].ToString(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                            float.Parse(hour["temp_c"].ToString()), int.Parse(hour["cloud"].ToString()), int.Parse(hour["humidity"].ToString()),
                            int.Parse(hour["chance_of_rain"].ToString()), float.Parse(hour["precip_mm"].ToString()), float.Parse(hour["uv"].ToString()),
                            float.Parse(hour["wind_kph"].ToString()), (string)hour["condition"]["text"], Global.UserHandle));

                            rows++;
                        }
                        catch (SqlException err)
                        {
                            MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            string fetchStr = $"Fetched {rows} weather entries & inserted to database for the cities: \n\n";
            foreach(var city in allCities)
            {
                fetchStr += $"{city.GetName()} ({city.GetParent().GetName()})\n";
            }
            MessageBox.Show(fetchStr);
        }
    }
}
