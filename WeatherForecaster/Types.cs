using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WeatherForecaster.Form1;

namespace WeatherForecaster
{
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
        private string Name;
        private int Id;

        public string GetName() => Name;
        public int GetId() => Id;

        public Entity(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }
    }
}
