using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WeatherForecaster
{
    public static partial class Global
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static formMain MainForm = null;
        public static SqlConnection Database = null;

        public static string GenerateSalt()
        {
            var bytes = new byte[128 / 8];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
        public static string ComputeHash(string str, string salt)
        {
            var byteResult = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes(str), Encoding.UTF8.GetBytes(salt), 10000);
            return Convert.ToBase64String(byteResult.GetBytes(24));
        }

        [STAThread]
        static void Main()
        {
            Database = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WeatherForecaster;Integrated Security=True");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            MainForm = new formMain();

            Database.Open();

            string query = $"SELECT ID, Username, Email, PrivilegeLevel FROM Users";

            try
            {
                SqlCommand cmd = new SqlCommand(query, Global.Database);
                
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var a = new User((int)reader["ID"], (string)reader["Username"], (string)reader["Email"], (byte)reader["PrivilegeLevel"]);
                    }
                }
                reader.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show("The database is not set-up correctly! Please ensure all tables are created.");
                //MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(MainForm);

            Database.Close();
        }
    }
}