using DevExpress.Charts.Native;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecaster.Pages
{
    public partial class ManageUsers : DevExpress.XtraEditors.XtraUserControl
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            listUsers.DataSource = new List<User>();

            listUsers.DataSource = Global.Users;
            listUsers.ValueMember = "Id";
            listUsers.DisplayMember = "Name";

            dispPriv.DataSource = Enum.GetNames(typeof(PrivilegeLevels));

            dispPriv.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdateUser.Enabled = false;
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dispPriv.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdateUser.Enabled = false;
            dispEmail.Text = "-";
            dispId.Text = "-";

            if (listUsers.SelectedValue == null)
            {
                return;
            }

            User user = (User)listUsers.SelectedItem;
            dispEmail.Text = user.GetEmail();
            dispId.Text = $"{user.GetId()}";
            btnDelete.Enabled = true;
            btnUpdateUser.Enabled = true;
            dispPriv.Enabled = true;

            int entries = 0;
            foreach(var a in Global.Continents)
            {
                foreach(var b in a.Countries)
                {
                    foreach(var c in b.Cities)
                    {
                        entries += c.WeatherData.Count(w => w.GetContributor() == user);
                    }
                }
            }

            dispEntries.Text = $"{entries}";

            if (user.Privileges == PrivilegeLevels.Contributor)
            {
                dispPriv.SelectedItem = "Contributor";
            }
            else if (user.Privileges == PrivilegeLevels.Admin)
            {
                dispPriv.SelectedItem = "Admin";
            }
            else if (user.Privileges == PrivilegeLevels.None)
            {
                dispPriv.SelectedItem = "None";
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedValue == null || listUsers.SelectedItem == null)
            {
                return;
            }

            User user = (User)listUsers.SelectedItem;

            if ((string)dispPriv.SelectedItem == "Contributor")
            {
                MessageBox.Show($"You have set {user.GetName()}'s privilege's to Level: Contributor", "Contributor added");
                user.Privileges = PrivilegeLevels.Contributor;
            }
            else if ((string)dispPriv.SelectedItem == "Admin")
            {
                MessageBox.Show($"You have set {user.GetName()}'s privilege's to Level: Admin", "Permissions changed");
                user.Privileges = PrivilegeLevels.Admin;
            }
            else if ((string)dispPriv.SelectedItem == "None")
            {
                MessageBox.Show($"You have removed all privileges from {user.GetName()}.", "Permissions removed");
                user.Privileges = PrivilegeLevels.None;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedValue == null || listUsers.SelectedItem == null)
            {
                return;
            }

            User user = (User)listUsers.SelectedItem;

            if(user == Global.UserHandle)
            {
                MessageBox.Show("You cannot delete yourself!");
                return;
            }

            try
            {
                string query = "";

                query = $"DELETE FROM Users WHERE ID = {user.GetId()};";
                SqlCommand cmd = new SqlCommand(query, Global.Database);
                cmd.ExecuteNonQuery();

                Global.Users.Remove(user);

                MessageBox.Show("You have deleted the account from the database successfully.");

                ManageUsers_Load(null, null);
            }
            catch (SqlException err)
            {
                MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
