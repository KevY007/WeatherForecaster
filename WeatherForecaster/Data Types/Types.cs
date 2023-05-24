using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WeatherForecaster.formMain;

namespace WeatherForecaster
{
    public partial class Global
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return ((celsius * 9) / 5) + 32;
        }
        public static int CelsiusToFahrenheit(int celsius)
        {
            return Convert.ToInt32(((celsius * 9) / 5) + 32);
        }
    }
    public interface IEntity
    {
        string GetName();
        int GetId();
    }

    public enum PrivilegeLevels
    {
        None,
        Contributor,
        Admin,
    }

    public abstract class Entity : IEntity
    {
        public string Name { get; protected set;  }
        public int Id { get; protected set; }

        public string GetName() => Name;
        public int GetId() => Id;

        public Entity(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }
    }
}
