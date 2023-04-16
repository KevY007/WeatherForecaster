using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public PrivilegeLevels GetPrivilegeLevel()
        {
            return PrivilegeLevel;
        }

        ~User()
        {
            Global.Users.Remove(this);
        }

        public User(int id, string name, string email) : base(id, name)
        {
            Email = email;
            PrivilegeLevel = PrivilegeLevels.None;

            Global.Users.Add(this);
        }

        public User(int id, string name, string email, PrivilegeLevels privileges) : this(id, name, email)
        {
            PrivilegeLevel = privileges;
        }

        public User(int id, string name, string email, int privileges) : this(id, name, email, (PrivilegeLevels)privileges) { }
    }
}
