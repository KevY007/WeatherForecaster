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

namespace WeatherForecaster
{
    public static partial class Global
    {
        public static List<Continent> Continents = new List<Continent>();
        public static List<Country> Countries = new List<Country>();
        public static List<City> Cities = new List<City>();
        public static List<Weather> WeatherData = new List<Weather>();


        public static string WeatherAPIKey = "6abd91f533ce4b1695b161946232503";
    }

    public class Weather : Entity
    {
        private City Parent;

        private float Temperature; // In centigrade
        private int Cloud; // 0-100
        private int Humidity; // 0-100
        private int RainChance; // 0-100
        private float Precipitation; // In mm
        private float UVIndex; // 0.0 - onwards.
        private float WindKPH; // ...
        private string Condition;
        private DateTime Timestamp; // ...

        public User Contributor;

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



        public City GetParent() => Parent;

        public Weather(int _id, City _parent, DateTime timestamp, float temp, int cloud, int humidity, int rain, float precip, float uv, float wind, string condition, User contributor = null) : base(_id, _id.ToString())
        {
            Parent = _parent;

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

            Global.WeatherData.Add(this);
        }
        public Weather(City _parent, DateTime timestamp, float temp, int cloud, int humidity, int rain, float precip, float uv, float wind, string condition, User contributor = null) : this(Global.WeatherData.Count, _parent, timestamp, temp, cloud, humidity, rain, precip, uv, wind, condition, contributor) { }
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
            Global.WeatherData.RemoveAll(a => a.GetParent() == this);

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
