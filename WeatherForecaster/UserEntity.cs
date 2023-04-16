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
    }

    public class User : Entity
    {
        private string Password;
        private string Email;
        private PrivilegeLevels PrivilegeLevel;

        public bool IsCorrectPassword(string p) => Password == p;

        public PrivilegeLevels GetPrivilegeLevel()
        {
            return PrivilegeLevel;
        }

        ~User()
        {
            Global.Users.Remove(this);
        }

        public User(int id, string name, string email, string password) : base(id, name)
        {
            Password = password;
            Email = email;
            PrivilegeLevel = PrivilegeLevels.None;
        }

        public User(int id, string name, string email, string password, PrivilegeLevels privileges) : this(id, email, name, password)
        {
            PrivilegeLevel = privileges;
        }

        public User(int id, string name, string email, string password, int privileges) : this(id, name, email, password, (PrivilegeLevels)privileges) { }
    }
}
