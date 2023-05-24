using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
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

        [STAThread]
        static void Main()
        {
            Database = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WeatherForecaster;Integrated Security=True");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            MainForm = new formMain();

            Database.Open();

            string query = $"SELECT ID, Username, Email, Celsius, PrivilegeLevel FROM Users";

            try
            {
                SqlCommand cmd = new SqlCommand(query, Global.Database);
                
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var a = new User((int)reader["ID"], (string)reader["Username"], (string)reader["Email"], (bool)reader["Celsius"], (byte)reader["PrivilegeLevel"]);
                    }
                }
                reader.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("The database is not set-up correctly! Please ensure all tables are created.");
                //MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            query = $"SELECT ID, Name FROM Continents";

            try
            {
                SqlCommand cmd = new SqlCommand(query, Global.Database);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Global.Continents.Add(new Continent((int)reader["ID"], (string)reader["Name"]));
                    }
                }
                reader.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("The database is not set-up correctly! Please ensure all tables are created.");
                return;
            }

            query = $"SELECT ID, Name, ParentID FROM Countries";

            try
            {
                SqlCommand cmd = new SqlCommand(query, Global.Database);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Global.Continents.First(a => a.Id == (int)reader["ParentID"]).AddCountry(new Country((int)reader["ID"], (string)reader["Name"]));
                    }
                }
                reader.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("The database is not set-up correctly! Please ensure all tables are created.");
                return;
            }

            query = $"SELECT ID, Name, ParentID FROM Cities";

            try
            {
                SqlCommand cmd = new SqlCommand(query, Global.Database);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        foreach (var c in Global.Continents)
                        {
                            foreach (var c2 in c.Countries)
                            {
                                if (c2.GetId() == (int)reader["ParentID"])
                                {
                                    c2.AddCity(new City((int)reader["ID"], (string)reader["Name"]));
                                }
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("The database is not set-up correctly! Please ensure all tables are created.");
                return;
            }

            query = $"SELECT * FROM WeatherData";

            try
            {
                SqlCommand cmd = new SqlCommand(query, Global.Database);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var allCities = new List<City>();
                        var allWeather = new List<Weather>();

                        foreach (var cont in Global.Continents)
                        {
                            foreach (var country in cont.Countries)
                            {
                                foreach (var city in country.Cities)
                                {
                                    if(city.Id == (int)reader["ParentID"])
                                    {
                                        city.AddWeather(new Weather((int)reader["ID"], DateTime.ParseExact((string)reader["Timestamp"], "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                                        Convert.ToSingle(reader["Temperature"]), (int)reader["Cloud"], (int)reader["Humidity"], (int)reader["RainChance"], Convert.ToSingle(reader["Precipitation"]),
                                        Convert.ToSingle(reader["UVIndex"]), Convert.ToSingle(reader["WindKPH"]), (string)reader["Condition"], (int)reader["ContributorID"] == -1 ? null : Global.Users.Find(b => b.GetId() == (int)reader["ContributorID"])));
                                    }
                                }
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("The database is not set-up correctly! Please ensure all tables are created.");
                return;
            }

            Application.Run(MainForm);

            Database.Close();
        }
    }
}