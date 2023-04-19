using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Globalization;
using DevExpress.XtraPrinting.Native.WebClientUIControl;

namespace WeatherForecaster
{
    public static partial class Global
    {
        public static List<Continent> Continents = new List<Continent>();
        public static List<Country> Countries = new List<Country>();
        public static List<City> Cities = new List<City>();
        public static List<Weather> WeatherData = new List<Weather>();

        public static string HTTPGet(string uri)
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

        public static void DefaultInit()
        {
            var asia = new Continent("Asia");
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
            new City("Frankfurt", de);

            foreach (var city in Cities)
            {
                dynamic json = JObject.Parse(HTTPGet($"http://api.weatherapi.com/v1/forecast.json?key=6abd91f533ce4b1695b161946232503&q={city.GetName()}&aqi=no&alerts=no&days=7"));
                
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
                    }
                }

                break;
            }
        }
    }

    public class Weather : Entity
    {
        private object Parent;

        public double Temperature; // In centigrade
        public int Cloud; // 0-100
        public int Humidity; // 0-100
        public int RainChance; // 0-100
        public double Precipitation; // In mm
        public double UVIndex; // 0.0 - onwards.
        public double WindKPH; // ...
        public DateTime Timestamp; // ...


        public User Contributor;

        public object GetParent() => Parent;

        public bool BelongsToCity() => Parent.GetType() == typeof(City);
        public bool BelongsToCountry() => Parent.GetType() == typeof(Country);

        public Weather(int _id, object _parent) : base(_id, _id.ToString())
        {
            Parent = _parent;
            Global.WeatherData.Add(this);
        }
        public Weather(object _parent) : this(Global.Cities.Count, _parent) { }
    
        

        ~Weather()
        {
            Global.WeatherData.Remove(this);
        }
    }

    public class City : Entity
    {
        private Country Parent;

        public Country GetParent() => Parent;

        public City(int _id, string _name, Country _parent) : base(_id, _name)
        {
            Parent = _parent;
            Global.Cities.Add(this);
        }
        public City(string _name, Country _parent) : this(Global.Cities.Count, _name, _parent) { }

        ~City()
        {
            Global.WeatherData.RemoveAll(a => a.BelongsToCity() && a.GetParent() == this);

            Global.Cities.Remove(this);
        }
    }

    public class Country : Entity
    {
        private Continent Parent;

        public Continent GetParent() => Parent;

        public Country(int _id, string _name, Continent _parent) : base(_id, _name)
        {
            Parent = _parent;
            Global.Countries.Add(this);
        }
        public Country(string _name, Continent _parent) : this(Global.Countries.Count, _name, _parent) { }

        ~Country()
        {
            Global.WeatherData.RemoveAll(a => a.BelongsToCountry() && a.GetParent() == this);
            Global.Cities.RemoveAll(a => a.GetParent() == this);

            Global.Countries.Remove(this);
        }
    }

    public class Continent : Entity
    {
        public Continent(int _id, string _name) : base(_id, _name) 
        { 
            Global.Continents.Add(this); 
        }
        public Continent(string _name) : this(Global.Continents.Count, _name) { }

        ~Continent()
        {
            Global.Countries.RemoveAll(a => a.GetParent() == this);

            Global.Continents.Remove(this);
        }
    }
}
