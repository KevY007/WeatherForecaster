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
using System.ComponentModel.DataAnnotations;
using DevExpress.Charts.Native;
using DevExpress.XtraSpellChecker;

namespace WeatherForecaster
{
    public static partial class Global
    {
        public static List<Continent> Continents = new List<Continent>();

        public static string WeatherAPIKey = "6abd91f533ce4b1695b161946232503";
    }

    public abstract class Location : Entity
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public abstract float GetAverageTemperature();
        public abstract object GetChild(int id);
        public abstract object GetChild(string name);
        public abstract object GetChildOfChild(int id);
        public abstract object GetChildOfChild(string name);

        public Location(int id, string name) : base(id, name) { }

    }

    public class Weather : Entity
    {
        [Required]
        [Range(-273.15, 100)]
        public float Temperature { get; private set; } // In centigrade

        [Required]
        [Range(0, 100)]
        public int Cloud { get; private set; } // 0-100

        [Required]
        [Range(0, 100)]
        public int Humidity { get; private set; } // 0-100

        [Required]
        [Range(0, 100)] 
        public int RainChance { get; private set; } // 0-100

        [Required]
        public float Precipitation { get; private set; } // In mm

        [Required]
        [Range(0.0, 10.0)]
        public float UVIndex { get; private set; } // 0.0 - onwards.

        [Required]
        public float WindKPH { get; private set; } // ...

        [Required]
        [MinLength(5)]
        public string Condition { get; private set; }

        [Required]
        public DateTime Timestamp { get; private set; } // ...


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
            City p = GetParent();
            return $"{(p != null ? $"{p.Name}, {p.GetParent().Name}" : "null")} - {GetTimestamp().ToString("yyyy-MM-dd HH:mm")} {(Global.UserHandle.DisplayCelsius == true ? ($"{GetTemperature()}°C") : ($"{Global.CelsiusToFahrenheit(GetTemperature())}°F"))} ({Id.ToString()})";
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

        public Weather(Weather copy) : this(copy.Id, copy.Timestamp, copy.Temperature, copy.Cloud, copy.Humidity, copy.RainChance, copy.Precipitation, copy.UVIndex, copy.WindKPH, copy.Condition, copy.Contributor)
        {

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

        public override object GetChild(int id)
        {
            return WeatherData.First(c => c.Id == id);
        }
        public override object GetChild(string name)
        {
            return WeatherData.First(c => c.Name == name);
        }

        public override object GetChildOfChild(int id)
        {
            return null;
        }
        public override object GetChildOfChild(string name)
        {
            return null;
        }

        public override float GetAverageTemperature()
        {
            List<float> temperatures = new List<float>();

            foreach (var c3 in WeatherData)
            {
                temperatures.Add(c3.Temperature);
            }

            return temperatures.Average();
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

        public override object GetChild(int id)
        {
            return Cities.First(c => c.Id == id);
        }
        public override object GetChild(string name)
        {
            return Cities.First(c => c.Name == name);
        }

        public override object GetChildOfChild(int id)
        {
            foreach (var c in Cities)
            {
                if (c.WeatherData.First(d => d.Id == id) != null)
                {
                    return c.WeatherData.First(d => d.Id == id);
                }
            }
            return null;
        }
        public override object GetChildOfChild(string name)
        {
            foreach (var c in Cities)
            {
                if (c.WeatherData.First(d => d.Name == name) != null)
                {
                    return c.WeatherData.First(d => d.Name == name);
                }
            }
            return null;
        }

        public override float GetAverageTemperature()
        {
            List<float> temperatures = new List<float>();
            foreach (var c2 in Cities)
            {
                foreach (var c3 in c2.WeatherData)
                {
                    temperatures.Add(c3.Temperature);
                }
            }

            return temperatures.Average();
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

        public override object GetChild(int id)
        {
            return Countries.First(c => c.Id == id);
        }
        public override object GetChild(string name)
        {
            return Countries.First(c => c.Name == name);
        }

        public override object GetChildOfChild(int id)
        {
            foreach(var c in Countries)
            {
                if(c.Cities.First(d => d.Id == id) != null)
                {
                    return c.Cities.First(d => d.Id == id);
                }
            }
            return null;
        }
        public override object GetChildOfChild(string name)
        {
            foreach (var c in Countries)
            {
                if (c.Cities.First(d => d.Name == name) != null)
                {
                    return c.Cities.First(d => d.Name == name);
                }
            }
            return null;
        }

        public override float GetAverageTemperature()
        {
            List<float> temperatures = new List<float>();
            foreach (var c in Countries)
            {
                foreach(var c2 in c.Cities)
                {
                    foreach(var c3 in c2.WeatherData)
                    {
                        temperatures.Add(c3.Temperature);
                    }
                }
            }

            return temperatures.Average();
        }

        public void AddCountry(Country c)
        {
            Countries.Add(c);
        }
    }
}
