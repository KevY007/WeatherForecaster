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
