using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WeatherForecaster.formMain;

namespace WeatherForecaster
{
    public partial class Global
    {
        /// <summary>
        /// Converts the celsius value to fahrenheit.
        /// </summary>
        /// <param name="celsius">The value in celsius.</param>
        /// <returns>The value in fahrenheit as double, up to 1 decimal point accurate.</returns>
        public static double CelsiusToFahrenheit(double celsius)
        {
            return Math.Round(((celsius * 9) / 5) + 32, 1);
        }

        /// <summary>
        /// Converts the celsius value to fahrenheit.
        /// </summary>
        /// <param name="celsius">The value in celsius.</param>
        /// <returns>The value in fahrenheit as int.</returns>
        public static int CelsiusToFahrenheit(int celsius)
        {
            return Convert.ToInt32(((celsius * 9) / 5) + 32);
        }
    }

    /// <summary>
    /// The interface which is extended onto all classes that possess the attributes of Name and Id.
    /// </summary>
    public interface IEntity
    {
        string GetName();
        int GetId();
    }

    /// <summary>
    /// The valid power/privileges a user can possess.
    /// </summary>
    public enum PrivilegeLevels
    {
        /// <summary>
        /// No power.
        /// </summary>
        None,

        /// <summary>
        /// User can add and remove Weather entries.
        /// </summary>
        Contributor,

        /// <summary>
        /// User can add, remove, manage, fetch weather entries, locations & other users.
        /// </summary>
        Admin,
    }
    
    /// <summary>
    /// The base class Entity. Extends IEntity interface with bare minimum validation.
    /// </summary>
    public abstract class Entity : IEntity
    {
        private string _Name;
        /// <summary>
        /// Name of the entity.
        /// </summary>
        [Required]
        [MinLength(3, ErrorMessage = "Name is too small")]
        public string Name { get { return GetName(); } protected set { this._Name = value; } }


        /// <summary>
        /// ID of the Entity.
        /// </summary>
        [Required]
        [Range(0, 1000)]
        public int Id { get; protected set; }

        /// <summary>
        /// Gets the name of the Entity.
        /// </summary>
        /// <returns>string value indicating the name of the Entity.</returns>
        public virtual string GetName() => _Name;

        /// <summary>
        /// Gets the ID of the Entity.
        /// </summary>
        /// <returns>int value indicating the ID of the Entity.</returns>
        public virtual int GetId() => Id;

        /// <summary>
        /// Creates an Entity object.
        /// </summary>
        /// <param name="_id">ID of the Entity</param>
        /// <param name="_name">Name of the Entity</param>
        public Entity(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }
    }
}
