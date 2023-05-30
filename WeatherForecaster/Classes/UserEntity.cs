using DevExpress.XtraEditors.TextEditController.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace WeatherForecaster
{
    public static partial class Global
    {
        /// <summary>
        /// List of all Users loaded in the memory.
        /// </summary>
        public static List<User> Users = new List<User>();

        /// <summary>
        /// Handle of currently logged in User. null if logged out.
        /// </summary>
        public static User UserHandle = null;
    }

    /// <summary>
    /// Account class.
    /// </summary>
    public class User : Entity
    {
        private string _Email;
        /// <summary>
        /// Email address of the User.
        /// </summary>
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email")]
        public string Email { get { return _Email; } set { _Email = value; } }


        private string _Password;
        /// <summary>
        /// The password of the User. Never loaded in the program. Only used for validation purposes.
        /// Minimum length: 3
        /// Maximum length: 32
        /// </summary>
        [Required]
        [MinLength(3, ErrorMessage = "Password is too small")]
        [MaxLength(32, ErrorMessage = "Password is too long")]
        public string Password { get { return _Password; } set { _Password = value; } }


        private bool Celsius;
        /// <summary>
        /// Boolean value. True: User is displayed values in Celsius, False: User is displayed values in Fahrenheit.
        /// </summary>
        public bool DisplayCelsius
        {
            get { return Celsius; }
            set { 
                Celsius = value;

                // Update the field as we update DisplayCelsius.
                string query = $"UPDATE Users SET Celsius = {Convert.ToInt32(Celsius)} WHERE ID = {GetId()};";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, Global.Database);

                    if(cmd.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to update temperature display type in database!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException err)
                {
                   MessageBox.Show("An error with the database has occured while updating temperature display type, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private PrivilegeLevels PrivilegeLevel;
        /// <summary>
        /// The PrivilegeLevel / power of a User.
        /// </summary>
        public PrivilegeLevels Privileges
        {
            get { return PrivilegeLevel; }
            set
            {
                PrivilegeLevel = value;

                string query = $"UPDATE Users SET PrivilegeLevel = {(byte)PrivilegeLevel} WHERE ID = {GetId()};";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, Global.Database);

                    if (cmd.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to update PrivilegeLevel in database!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException err)
                {
                    MessageBox.Show("An error with the database has occured while updating PrivilegeLevel, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Gets the email address of the user.
        /// </summary>
        /// <returns></returns>
        public string GetEmail() => Email;

        /// <summary>
        /// Get number of entries by this User in all continents.
        /// </summary>
        /// <returns>int value determining how many entries this User has added.</returns>
        public int GetEntries()
        {
            int numEntries = 0;

            foreach (var a in Global.Continents)
            {
                numEntries += GetEntries(a);
            }
            return numEntries;
        }

        /// <summary>
        /// Get number of entries by this User in a specific continent.
        /// </summary>
        /// <param name="continent">The continent to search in</param>
        /// <returns>int value determining how many entries this User has added in this specific Continent.</returns>
        public int GetEntries(Continent continent)
        {
            int numEntries = 0;

            foreach (var b in continent.Countries)
            {
                numEntries += GetEntries(b);
            }
            return numEntries;
        }

        /// <summary>
        /// Get number of entries by this User in a specific country.
        /// </summary>
        /// <param name="country">The country to search in</param>
        /// <returns>int value determining how many entries this User has added in this specific Country.</returns>
        public int GetEntries(Country country)
        {
            int numEntries = 0;

            foreach (var b in country.Cities)
            {
                numEntries += GetEntries(b);
            }
            return numEntries;
        }

        /// <summary>
        /// Get number of entries by this User in a specific city.
        /// </summary>
        /// <param name="continent">The city to search in</param>
        /// <returns>int value determining how many entries this User has added in this specific City.</returns>
        public int GetEntries(City city)
        {
            return city.WeatherData.Count(w => w.GetContributor() == this);
        }

        /// <summary>
        /// Creates a User account.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <param name="name">Name of the user.</param>
        /// <param name="email">Email address of the user.</param>
        /// <param name="celsius">true: Temperature in Celsius, false: Temperature in Fahrenheit</param>
        public User(int id, string name, string email, bool celsius) : base(id, name)
        {
            Email = email;
            PrivilegeLevel = PrivilegeLevels.None;
            Celsius = celsius;
        }

        /// <summary>
        /// Creates a User account.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <param name="name">Name of the user.</param>
        /// <param name="email">Email address of the user.</param>
        /// <param name="celsius">true: Temperature in Celsius, false: Temperature in Fahrenheit</param>
        /// <param name="privileges">What power the user possesses.</param>
        public User(int id, string name, string email, bool celsius, PrivilegeLevels privileges) : this(id, name, email, celsius)
        {
            PrivilegeLevel = privileges;
        }

        /// <summary>
        /// Creates a User account.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <param name="name">Name of the user.</param>
        /// <param name="email">Email address of the user.</param>
        /// <param name="celsius">true: Temperature in Celsius, false: Temperature in Fahrenheit</param>
        /// <param name="privileges">What power the user possesses.</param>
        public User(int id, string name, string email, bool celsius, int privileges) : this(id, name, email, celsius, (PrivilegeLevels)privileges) { }
    }
}
