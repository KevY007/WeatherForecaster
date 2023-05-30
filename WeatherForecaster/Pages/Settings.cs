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
        /// <summary>
        /// Used to get the JSON data from WeatherAPI.com. No other use.
        /// </summary>
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
            // Set the values of the checkboxes to the values of what the properties are set to currently.
            centigradeSwitch.IsOn = Global.UserHandle.DisplayCelsius;
            weatherAPIKey.Text = Global.WeatherAPIKey;
        }

        private void centigradeSwitch_Toggled(object sender, EventArgs e)
        {
            // This triggers a set {} on the concerned property. It has it's own code in the User class.
            Global.UserHandle.DisplayCelsius = centigradeSwitch.IsOn;
        }

        private void weatherAPIKey_EditValueChanged(object sender, EventArgs e)
        {
            Global.WeatherAPIKey = weatherAPIKey.Text;
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            // Admin privileges required because it's fetching a lot of data into the database, not something a user/contributor would use anyways.
            if (Global.UserHandle.Privileges != PrivilegeLevels.Admin)
            {
                MessageBox.Show("This button is restricted to admins!", "You lack the required privileges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get all the cities. (for using their name's to fetch data from)
            
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

            //////////////////////////////
           
            int rows = 0;

            foreach (var city in allCities)
            {
                // Loop through all cities and parse their weather data for next 3 days from the API.

                dynamic json = JObject.Parse(HTTPGet($"http://api.weatherapi.com/v1/forecast.json?key={Global.WeatherAPIKey}&q={city.GetName()}&aqi=no&alerts=no&days=3"));

                // Rough data structure:
                // json["location"]["name"].ToString()
                // json["forecast"] contains an array of data: forecastday[days] (where days = num. of days)

                foreach (var day in json["forecast"]["forecastday"])
                {
                    // json["forecast"]["forecastday"][i] contains: hour[hours], astro, and other properties. (we only use hour)
                    // where i = the day, starting at current day.
                    foreach (var hour in day["hour"])
                    {

                        try
                        {
                            // Prepare a query to parse & insert the relevant data into the WeatherData table.

                            string query = "INSERT INTO WeatherData (ParentID, Timestamp, Temperature, Condition, Cloud, Humidity, RainChance, Precipitation, UVIndex, WindKPH, ContributorID) OUTPUT INSERTED.ID VALUES ";
                            query += $"({city.GetId()}, '{(DateTime.ParseExact(hour["time"].ToString(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)).ToString("yyyy-MM-dd HH:mm")}', " +
                                $"{float.Parse(hour["temp_c"].ToString())}, '{(string)hour["condition"]["text"]}', {int.Parse(hour["cloud"].ToString())}, " +
                                $"{int.Parse(hour["humidity"].ToString())}, {int.Parse(hour["chance_of_rain"].ToString())}, " +
                            $"{float.Parse(hour["precip_mm"].ToString())}, {float.Parse(hour["uv"].ToString())}, {float.Parse(hour["wind_kph"].ToString())}, {Global.UserHandle.GetId()}); ";

                            // Send the query.
                            SqlCommand cmd = new SqlCommand(query, Global.Database);
                            int aID = (int)cmd.ExecuteScalar();

                            // Add the entry to local memory.
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

            // After all has been done, display the result.
            string fetchStr = $"Fetched {rows} weather entries & inserted to database for the cities: \n\n";
            foreach(var city in allCities)
            {
                fetchStr += $"{city.GetName()} ({city.GetParent().GetName()})\n";
            }
            MessageBox.Show(fetchStr);
        }
    }
}
