using DevExpress.XtraEditors.TextEditController.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecaster
{
    public static partial class Global
    {
        public static List<User> Users = new List<User>();
        public static User UserHandle = null;
    }

    public class User : Entity
    {
        private string Email;
        private PrivilegeLevels PrivilegeLevel;
        private bool Celsius;

        public bool DisplayCelsius
        {
            get { return Celsius; }
            set { 
                Celsius = value;

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

        public string GetEmail() => Email;

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

        ~User()
        {
            Global.Users.Remove(this);
        }

        public User(int id, string name, string email, bool celsius) : base(id, name)
        {
            Email = email;
            PrivilegeLevel = PrivilegeLevels.None;

            Global.Users.Add(this);
            Celsius = celsius;
        }

        public User(int id, string name, string email, bool celsius, PrivilegeLevels privileges) : this(id, name, email, celsius)
        {
            PrivilegeLevel = privileges;
        }

        public User(int id, string name, string email, bool celsius, int privileges) : this(id, name, email, celsius, (PrivilegeLevels)privileges) { }
    }
}
