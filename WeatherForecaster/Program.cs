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
    /// <summary>
    /// This static class contains all the default variables and values that are shared across all forms.
    /// </summary>
    public static partial class Global
    {
        /// <summary>
        /// Handle to the Main form of the program to be accessible throughout the application.
        /// </summary>
        public static formMain MainForm = null;

        /// <summary>
        /// Handle to the SqlConnection of the Database.
        /// </summary>
        public static SqlConnection Database = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Assign a SqlConnection to Database on the global variable so all other forms can access it.

            Database = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WeatherForecaster;Integrated Security=True");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Initialize the main form & open the connection.
            MainForm = new formMain();
            Database.Open();


            //////////////////////////////////////////

            // Prepare a query to fetch all users from the database.
            string query = $"SELECT ID, Username, Email, Celsius, PrivilegeLevel FROM Users";

            try
            {
                SqlCommand cmd = new SqlCommand(query, Global.Database);
                
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Add the user to the Users list so that we can easily access it later.
                        Global.Users.Add(new User((int)reader["ID"], (string)reader["Username"], (string)reader["Email"], (bool)reader["Celsius"], (byte)reader["PrivilegeLevel"]));
                    }
                }
                reader.Close();
            }
            catch (SqlException) // In case any exception is thrown, mostly it would only throw if the database/table/column doesn't exist!
            {
                MessageBox.Show("The database is not set-up correctly! Please ensure all tables are created.");
                return;
            }

            //////////////////////////////////////////
           
            // Prepare a query to fetch all the Continents, Countries, Cities & WeatherData (in-order).

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

            //////////////////////////////////////////

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

            //////////////////////////////////////////

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

            //////////////////////////////////////////

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

                        // Loop through all Location entities to find the belonging parent of the Weather entry to add.

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

            //////////////////////////////////////////
           
            // After everything has been loaded, display the MainForm.
            Application.Run(MainForm);

            // This would only be called once the MainForm has been closed/exited (i.e. our program is about to quit).
            Database.Close();
        }
    }
}