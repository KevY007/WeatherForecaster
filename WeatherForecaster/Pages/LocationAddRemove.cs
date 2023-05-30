using DevExpress.Utils.Extensions;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecaster.Pages
{
    public partial class LocationAddRemove : DevExpress.XtraEditors.XtraUserControl
    {
        public LocationAddRemove()
        {
            InitializeComponent();
        }

        private void LocationAddRemove_Load(object sender, EventArgs e)
        {
            // What items are available to add.
            cmbItemType.DataSource = new string[] { "Continent", "Country", "City" };
        }

        private void cmbLocationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear lists:
            cmbSetParent.DataSource = new string[] { };
            listRemoveItem.DataSource = new string[] { };

            // Parents tab shouldn't be visible because our default selection is Continent (requires no parent).
            cmbSetParent.Visible = false;
            lblParents.Visible = false;

            txtAddName.Text = "";

            var allCountries = new List<Country>();
            var allCities = new List<City>();

            foreach (var cont in Global.Continents)
            {
                allCountries.AddRange(cont.Countries);
                foreach (var country in cont.Countries)
                {
                    allCities.AddRange(country.Cities);
                }
            }


            switch ((string)cmbItemType.SelectedItem)
            {
                case "Continent":
                    cmbSetParent.Visible = false;
                    lblParents.Visible = false;

                    try // In case it's empty (the lists so it ignores the exception)
                    {
                        listRemoveItem.DataSource = Global.Continents;
                        listRemoveItem.DisplayMember = "Name";
                        listRemoveItem.ValueMember = "Id";
                    }
                    catch { }
                    break;
                case "Country":
                    cmbSetParent.Visible = true;
                    lblParents.Visible = true;

                    try // In case it's empty (the lists so it ignores the exception)
                    {
                        listRemoveItem.DataSource = allCountries;
                        listRemoveItem.DisplayMember = "Name";
                        listRemoveItem.ValueMember = "Id";

                        cmbSetParent.DataSource = Global.Continents;
                        cmbSetParent.DisplayMember = "Name";
                        cmbSetParent.ValueMember = "Id";
                    }
                    catch { }
                    break;
                case "City":
                    cmbSetParent.Visible = true;
                    lblParents.Visible = true;

                    try // In case it's empty (the lists so it ignores the exception)
                    {
                        listRemoveItem.DataSource = allCities;
                        listRemoveItem.DisplayMember = "Name";
                        listRemoveItem.ValueMember = "Id";

                        cmbSetParent.DataSource = allCountries;
                        cmbSetParent.DisplayMember = "Name";
                        cmbSetParent.ValueMember = "Id";
                    }
                    catch { }
                    break;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "";
            switch ((string)cmbItemType.SelectedItem)
            {
                case "Continent":
                    query = $"INSERT INTO Continents (Name) OUTPUT INSERTED.ID VALUES ('{txtAddName.Text}');";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, Global.Database);

                        int aID = (int)cmd.ExecuteScalar();

                        MessageBox.Show($"Continent {txtAddName.Text} added with ID {aID}!", "Continent Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        Global.Continents.Add(new Continent(aID, txtAddName.Text));
                    }
                    catch (SqlException err)
                    {
                        if (err.Message.Contains("Violation of UNIQUE KEY"))
                        {
                            MessageBox.Show("Continent \"" + txtAddName.Text + "\" already exists!", "Duplicate continent!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Country":
                    if (cmbSetParent.SelectedValue == null)
                    {
                        MessageBox.Show("You haven't selected the continent this country belongs to!", "Incorrect relationship!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int parentId = (int)cmbSetParent.SelectedValue;

                    query = $"INSERT INTO Countries (Name, ParentID) OUTPUT INSERTED.ID VALUES ('{txtAddName.Text}', {parentId});";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, Global.Database);

                        int aID = (int)cmd.ExecuteScalar();

                        MessageBox.Show($"Country {txtAddName.Text} added with ID {aID}! Parent: {((Continent)cmbSetParent.SelectedItem).Name}", "Country Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ((Continent)cmbSetParent.SelectedItem).AddCountry(new Country(aID, txtAddName.Text));
                    }
                    catch (SqlException err)
                    {
                        if (err.Message.Contains("Violation of UNIQUE KEY"))
                        {
                            MessageBox.Show("The entry for \"" + txtAddName.Text + "\" already exists!", "Duplicate entry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    break;
                case "City":
                    if (cmbSetParent.SelectedValue == null)
                    {
                        MessageBox.Show("You haven't selected the country this city belongs to!", "Incorrect relationship!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    query = $"INSERT INTO Cities (Name, ParentID) OUTPUT INSERTED.ID VALUES ('{txtAddName.Text}', {(int)cmbSetParent.SelectedValue});";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, Global.Database);

                        int aID = (int)cmd.ExecuteScalar();

                        MessageBox.Show($"City {txtAddName.Text} added with ID {aID}! Parent: {((Country)cmbSetParent.SelectedItem).Name}", "City Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ((Country)cmbSetParent.SelectedItem).AddCity(new City(aID, txtAddName.Text));
                    }
                    catch (SqlException err)
                    {
                        if (err.Message.Contains("Violation of UNIQUE KEY"))
                        {
                            MessageBox.Show("The entry for \"" + txtAddName.Text + "\" already exists!", "Duplicate entry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
            }
            cmbLocationType_SelectedIndexChanged(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listRemoveItem.SelectedValue == null)
            {
                MessageBox.Show("You haven't selected any items to remove!", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string names = "";
            int rows = 0;
            foreach(dynamic d in listRemoveItem.SelectedItems)
            {
                if(d.GetType() == typeof(Continent))
                {
                    try
                    {
                        string query = "";

                        // Delete all downwards weatherdata first:
                        query = $"DELETE FROM WeatherData WHERE ParentID IN ( SELECT * FROM ( SELECT ID FROM Cities WHERE ParentID IN ( SELECT * FROM ( SELECT ID FROM Countries WHERE ParentID = {d.GetId()} ) AS p2 ) ) AS p)";
                        SqlCommand cmd = new SqlCommand(query, Global.Database);
                        rows += cmd.ExecuteNonQuery();

                        // Then the cities:
                        query = $"DELETE FROM Cities WHERE ParentID IN ( SELECT * FROM ( SELECT ID FROM Countries WHERE ParentID = {d.GetId()} ) AS p)";
                        cmd = new SqlCommand(query, Global.Database);
                        rows += cmd.ExecuteNonQuery();

                        // Then the countries:
                        query = $"DELETE FROM Countries WHERE ParentID = {d.GetId()}";
                        cmd = new SqlCommand(query, Global.Database);
                        rows += cmd.ExecuteNonQuery();

                        // Now delete the Continent:
                        query = $"DELETE FROM Continents WHERE ID = {d.GetId()};";
                        cmd = new SqlCommand(query, Global.Database);
                        rows += cmd.ExecuteNonQuery();

                        names = names + "\n" + d.GetName();

                        Global.Continents.Remove(d);
                    }
                    catch (SqlException err)
                    {
                        MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (d.GetType() == typeof(Country))
                {
                    try
                    {
                        string query = "";

                        // Delete all downwards weatherdata first:
                        query = $"DELETE FROM WeatherData WHERE ParentID IN ( SELECT * FROM ( SELECT ID FROM Cities WHERE ParentID = {d.GetId()} ) AS p)";
                        SqlCommand cmd = new SqlCommand(query, Global.Database);
                        rows += cmd.ExecuteNonQuery();

                        // Then the cities:
                        query = $"DELETE FROM Cities WHERE ParentID = {d.GetId()}";
                        cmd = new SqlCommand(query, Global.Database);
                        rows += cmd.ExecuteNonQuery();

                        // Now the Country:
                        query = $"DELETE FROM Countries WHERE ID = {d.GetId()}";
                        cmd = new SqlCommand(query, Global.Database);
                        rows += cmd.ExecuteNonQuery();

                        names = names + "\n" + d.GetName();

                        ((Country)d).GetParent().Countries.Remove(d);
                    }
                    catch (SqlException err)
                    {
                        MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (d.GetType() == typeof(City))
                {
                    try
                    {
                        string query = "";

                        // Delete all downwards weatherdata first:
                        query = $"DELETE FROM WeatherData WHERE ParentID = {d.GetId()}";
                        SqlCommand cmd = new SqlCommand(query, Global.Database);
                        rows += cmd.ExecuteNonQuery();

                        // Now delete the City:
                        query = $"DELETE FROM Cities WHERE ID = {d.GetId()}";
                        cmd = new SqlCommand(query, Global.Database);
                        rows += cmd.ExecuteNonQuery();

                        names = names + "\n" + d.GetName();

                        ((City)d).GetParent().Cities.Remove(d);
                    }
                    catch (SqlException err)
                    {
                        MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            MessageBox.Show($"The following entries have been deleted: ({rows} rows affected)\n\n{names}", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Invoke selection changed so it can refresh:
            cmbLocationType_SelectedIndexChanged(sender, e);
        }
    }
}
