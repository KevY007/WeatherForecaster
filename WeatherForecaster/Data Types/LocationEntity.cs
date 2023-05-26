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
using System.Globalization;
using DevExpress.XtraRichEdit.Model;
using DevExpress.Data.Filtering.Helpers;

namespace WeatherForecaster
{
    public static partial class Global
    {
        public static List<Continent> Continents = new List<Continent>();

        public static string WeatherAPIKey = "6abd91f533ce4b1695b161946232503";
    }

    public class Location : Entity
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public Location(int id, string name) : base(id, name) { }

    }

    public class Weather : Entity
    {
        private float Temperature; // In centigrade
        private int Cloud; // 0-100
        private int Humidity; // 0-100
        private int RainChance; // 0-100
        private float Precipitation; // In mm
        private float UVIndex; // 0.0 - onwards.
        private float WindKPH; // ...
        private string Condition;
        private DateTime Timestamp; // ...

        private User Contributor;

        public float GetTemperature() { return Temperature; } 
        public int GetCloud() { return Cloud; }
        public int GetHumidity() { return Humidity; }
        public int GetRainChance() { return RainChance; }
        public float GetPrecipitation() { return Precipitation; }
        public float GetUVIndex() { return UVIndex; }
        public float GetWindKPH() { return WindKPH; }
        public string GetCondition() { return Condition; }
        public DateTime GetTimestamp() { return Timestamp; }
        public User GetContributor() { return Contributor; }

        public override string GetName()
        {
            return Id.ToString();
        }

        public City GetParent()
        {
            foreach (var a in Global.Continents)
            {
                foreach (var b in a.Countries)
                {
                    foreach (var c in b.Cities)
                    {
                        if (c.WeatherData.Contains(this)) return c;
                    }
                }
            }
            return null;
        }

        public Weather(int _id, DateTime timestamp, float temp, int cloud, int humidity, int rain, float precip, float uv, float wind, string condition, User contributor = null) : base(_id, _id.ToString())
        {
            Timestamp = timestamp;
            Temperature = temp;
            Cloud = cloud;
            Humidity = humidity;
            RainChance = rain;
            Precipitation = precip;
            UVIndex = uv;
            WindKPH = wind;
            Condition = condition;

            Contributor = contributor;
        }
    }

    public class City : Location
    {
        public List<Weather> WeatherData = new List<Weather>();
        public Country GetParent()
        {
            foreach(var a in Global.Continents)
            {
                foreach (var b in a.Countries)
                {
                    if(b.Cities.Contains(this)) return b;
                }
            }
            return null;
        }

        public City(int _id, string _name, float lat = 0.0f, float lon = 0.0f) : base(_id, _name)
        {
            Latitude = lat;
            Longitude = lon;
        }

        public void AddWeather(Weather c)
        {
            WeatherData.Add(c);
        }
    }

    public class Country : Location
    {
        public List<City> Cities = new List<City>();
        public Continent GetParent()
        {
            return Global.Continents.First(a => a.Countries.Contains(this));
        }

        public Country(int _id, string _name, float lat = 0.0f, float lon = 0.0f) : base(_id, _name)
        {
            Latitude = lat;
            Longitude = lon;
        }

        public void AddCity(City c)
        {
            Cities.Add(c);
        }
    }

    public class Continent : Location
    {
        public List<Country> Countries = new List<Country>();
        public Continent(int _id, string _name, float lat = 0.0f, float lon = 0.0f) : base(_id, _name) 
        {
            Latitude = lat;
            Longitude = lon;
        }

        public void AddCountry(Country c)
        {
            Countries.Add(c);
        }
    }
}
