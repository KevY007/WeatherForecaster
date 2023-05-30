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
        /// <summary>
        /// Contains all the Continents loaded in the program.
        /// </summary>
        public static List<Continent> Continents = new List<Continent>();

        public static string WeatherAPIKey = "6abd91f533ce4b1695b161946232503";
    }

    /// <summary>
    /// An abstract class, parent of classes based on Locations like Continent, Country, City.
    /// </summary>
    public abstract class Location : Entity
    {
        public abstract float GetAverageTemperature();
        public abstract object GetChild(int id);
        public abstract object GetChild(string name);
        public abstract object GetChildOfChild(int id);
        public abstract object GetChildOfChild(string name);

        public Location(int id, string name) : base(id, name) { }

    }

    /// <summary>
    /// Weather Entry
    /// </summary>
    public class Weather : Entity
    {
        /// <summary>
        /// Temperature in Centigrade. Valid Values: -273.15 to 100
        /// </summary>
        [Required]
        [Range(-273.15, 100)]
        public float Temperature { get; private set; }


        /// <summary>
        /// Cloud in percentage. Valid Values: 0 to 100
        /// </summary>
        [Required]
        [Range(0, 100)]
        public int Cloud { get; private set; }


        /// <summary>
        /// Humidity in percentage. Valid Values: 0 to 100
        /// </summary>
        [Required]
        [Range(0, 100)]
        public int Humidity { get; private set; }


        /// <summary>
        /// RainChance in percentage. Valid Values: 0 to 100
        /// </summary>
        [Required]
        [Range(0, 100)] 
        public int RainChance { get; private set; }


        /// <summary>
        /// Precipitation in millimeters.
        /// </summary>
        [Required]
        public float Precipitation { get; private set; } // In mm


        /// <summary>
        /// The UV Index. Valid Values: 0.0 to 10.0
        /// </summary>
        [Required]
        [Range(0.0, 10.0)]
        public float UVIndex { get; private set; }


        /// <summary>
        /// The Wind speed in KPH or KM/H.
        /// </summary>
        [Required]
        public float WindKPH { get; private set; }


        /// <summary>
        /// The current weather condition in string. Minimum length: 5
        /// </summary>
        [Required]
        [MinLength(5)]
        public string Condition { get; private set; }


        /// <summary>
        /// The timestamp of the Weather entry.
        /// </summary>
        [Required]
        public DateTime Timestamp { get; private set; }


        /// <summary>
        /// The user who added this entry. null if a User is not associated with it.
        /// </summary>
        private User Contributor;


        /// <summary>
        /// Gets the current temperature in centigrade.
        /// </summary>
        /// <returns>float value of the temperature.</returns>
        public float GetTemperature() { return Temperature; } 

        /// <summary>
        /// Gets the cloud percentage.
        /// </summary>
        /// <returns>int value of percentage of clouds.</returns>
        public int GetCloud() { return Cloud; }

        /// <summary>
        /// Gets the humidity percentage.
        /// </summary>
        /// <returns>int value of percentage of humidity.</returns>
        public int GetHumidity() { return Humidity; }

        /// <summary>
        /// Gets the chance of rain.
        /// </summary>
        /// <returns>int value of chances of rain.</returns>
        public int GetRainChance() { return RainChance; }

        /// <summary>
        /// Gets the precipitation.
        /// </summary>
        /// <returns>float value of percipitation in mm</returns>
        public float GetPrecipitation() { return Precipitation; }

        /// <summary>
        /// Gets the UV index.
        /// </summary>
        /// <returns>float value of the UV Index. 0.0 to 10.0</returns>
        public float GetUVIndex() { return UVIndex; }

        /// <summary>
        /// Gets the current Wind speed.
        /// </summary>
        /// <returns>float value of the wind speed in KM/H or KPH</returns>
        public float GetWindKPH() { return WindKPH; }

        /// <summary>
        /// Gets the current condition
        /// </summary>
        /// <returns>string value of the current condition of the weather</returns>
        public string GetCondition() { return Condition; }

        /// <summary>
        /// Gets the timestamp
        /// </summary>
        /// <returns>DateTime of the weather entry</returns>
        public DateTime GetTimestamp() { return Timestamp; }

        /// <summary>
        /// Gets the User who added this entry.
        /// </summary>
        /// <returns>A User, null if none.</returns>
        public User GetContributor() { return Contributor; }

        /// <summary>
        /// Gets the FULL Name of the Weather Entry.
        /// </summary>
        /// <returns>string value of the full name.</returns>
        public override string GetName()
        {
            City p = GetParent();
            return $"{(p != null ? $"{p.Name}, {p.GetParent().Name}" : "null")} - {GetTimestamp().ToString("yyyy-MM-dd HH:mm")} {(Global.UserHandle.DisplayCelsius == true ? ($"{GetTemperature()}°C") : ($"{Global.CelsiusToFahrenheit(GetTemperature())}°F"))} ({Id.ToString()})";
        }

        /// <summary>
        /// Gets the Parent City owning this Weather entry.
        /// </summary>
        /// <returns>City</returns>
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

        /// <summary>
        /// Creates a Weather instance.
        /// </summary>
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

        /// <summary>
        /// Creates a Weather instance and copies it's values from another.
        /// </summary>
        public Weather(Weather copy) : this(copy.Id, copy.Timestamp, copy.Temperature, copy.Cloud, copy.Humidity, copy.RainChance, copy.Precipitation, copy.UVIndex, copy.WindKPH, copy.Condition, copy.Contributor)
        {

        }
    }

    /// <summary>
    /// City, holding various Weather entries.
    /// </summary>
    public class City : Location
    {
        /// <summary>
        /// The list of all Weather's belonging to this City.
        /// </summary>
        public List<Weather> WeatherData = new List<Weather>();

        /// <summary>
        /// Gets the parent Country owning this City.
        /// </summary>
        /// <returns>Country</returns>
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

        /// <summary>
        /// Creates a city.
        /// </summary>
        public City(int _id, string _name) : base(_id, _name)
        {
        }

        /// <summary>
        /// Gets a weather entry with the specific ID belonging to this city.
        /// </summary>
        /// <param name="id">The ID of the weather entry</param>
        /// <returns>object, can be casted as (Weather)</returns>
        public override object GetChild(int id)
        {
            return WeatherData.First(c => c.Id == id);
        }

        /// <summary>
        /// Gets a weather entry with the specific name belonging to this city.
        /// </summary>
        /// <param name="name">The name of the weather entry</param>
        /// <returns>object, can be casted as (Weather)</returns>
        public override object GetChild(string name)
        {
            return WeatherData.First(c => c.Name == name);
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        public override object GetChildOfChild(int id)
        {
            return null;
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        public override object GetChildOfChild(string name)
        {
            return null;
        }


        /// <summary>
        /// Gets the average temperature of ALL the weather entries in this City.
        /// </summary>
        /// <returns>A float.</returns>
        public override float GetAverageTemperature()
        {
            List<float> temperatures = new List<float>();

            foreach (var c3 in WeatherData)
            {
                temperatures.Add(c3.Temperature);
            }

            return temperatures.Average();
        }

        /// <summary>
        /// Adds a weather entry in this City.
        /// </summary>
        /// <param name="entry">The weather entry</param>
        public void AddWeather(Weather entry)
        {
            WeatherData.Add(entry);
        }
    }

    public class Country : Location
    {
        /// <summary>
        /// A list containing all the City instances that belong to this Country.
        /// </summary>
        public List<City> Cities = new List<City>();

        /// <summary>
        /// Gets the parent Continent owning this Country.
        /// </summary>
        /// <returns>Country</returns>
        public Continent GetParent()
        {
            return Global.Continents.First(a => a.Countries.Contains(this));
        }

        /// <summary>
        /// Create a Country.
        /// </summary>
        public Country(int _id, string _name, float lat = 0.0f, float lon = 0.0f) : base(_id, _name)
        {
        }

        /// <summary>
        /// Gets a city that belongs to this Country.
        /// </summary>
        /// <param name="id">The ID of the city</param>
        /// <returns>object, castable as (City)</returns>
        public override object GetChild(int id)
        {
            return Cities.First(c => c.Id == id);
        }

        /// <summary>
        /// Gets a city that belongs to this Country.
        /// </summary>
        /// <param name="name">The name of the city</param>
        /// <returns>object, castable as (City)</returns>
        public override object GetChild(string name)
        {
            return Cities.First(c => c.Name == name);
        }

        /// <summary>
        /// Gets a weather entry that belongs to any City inside this Country.
        /// </summary>
        /// <param name="id">The ID of the entry</param>
        /// <returns>object, castable as (Weather)</returns>
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

        /// <summary>
        /// Gets a weather entry that belongs to any City inside this Country.
        /// </summary>
        /// <param name="name">The name of the entry</param>
        /// <returns>object, castable as (Weather)</returns>
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

        /// <summary>
        /// Gets the Average Temperature of all the entries that belong to all cities inside this Country.
        /// </summary>
        /// <returns>A float average.</returns>
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

        /// <summary>
        /// Add a city inside this Country.
        /// </summary>
        public void AddCity(City city)
        {
            Cities.Add(city);
        }
    }

    public class Continent : Location
    {
        /// <summary>
        /// The list of all Countries belong in this Continent.
        /// </summary>
        public List<Country> Countries = new List<Country>();
        public Continent(int _id, string _name, float lat = 0.0f, float lon = 0.0f) : base(_id, _name) 
        {
        }

        /// <summary>
        /// Gets a specific Country that belongs to this Continent.
        /// </summary>
        /// <param name="id">The ID of the Country</param>
        /// <returns>object, castable as (Country)</returns>
        public override object GetChild(int id)
        {
            return Countries.First(c => c.Id == id);
        }

        /// <summary>
        /// Gets a specific Country that belongs to this Continent.
        /// </summary>
        /// <param name="name">The name of the Country</param>
        /// <returns>object, castable as (Country)</returns>
        public override object GetChild(string name)
        {
            return Countries.First(c => c.Name == name);
        }

        /// <summary>
        /// Gets a specific City that belongs to any Country in this Continent.
        /// </summary>
        /// <param name="id">The ID of the City</param>
        /// <returns>object, castable as (City)</returns>
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

        /// <summary>
        /// Gets a specific City that belongs to any Country in this Continent.
        /// </summary>
        /// <param name="name">The ID of the City</param>
        /// <returns>object, castable as (City)</returns>
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

        /// <summary>
        /// Gets the continental temperature average.
        /// </summary>
        /// <returns>A float value</returns>
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

        /// <summary>
        /// Adds a Country inside this Continent.
        /// </summary>
        public void AddCountry(Country country)
        {
            Countries.Add(country);
        }
    }
}
