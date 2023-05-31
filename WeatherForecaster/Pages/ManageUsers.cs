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
        public static FormViewLogs Instance { get; set; }
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            // Reset/Remove View Logs tab.
            if (Instance != null)
            {
                Instance.Hide();
                Instance.Dispose();
                Instance = null;
            }

            // Assign it to an empty list because sometimes lists and comboboxes don't update without changing datasource twice.
            listUsers.DataSource = new List<User>();

            listUsers.DataSource = Global.Users;
            listUsers.ValueMember = "Id";
            listUsers.DisplayMember = "Name";

            // Get all PrivilegeLevels rather than manually specifying them one by one.
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

            // Find all entries by that specific user for displaying purposes.
            dispEntries.Text = $"{user.GetEntries()}";

            // Change the current selected privilege level according to what they are.
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
                Global.UserHandle.Log($"Set the account: {user.GetName()} privileges to: Contributor");
            }
            else if ((string)dispPriv.SelectedItem == "Admin")
            {
                MessageBox.Show($"You have set {user.GetName()}'s privilege's to Level: Admin", "Permissions changed");
                user.Privileges = PrivilegeLevels.Admin;
                Global.UserHandle.Log($"Set the account: {user.GetName()} privileges to: Admin");
            }
            else if ((string)dispPriv.SelectedItem == "None")
            {
                MessageBox.Show($"You have removed all privileges from {user.GetName()}.", "Permissions removed");
                user.Privileges = PrivilegeLevels.None;
                Global.UserHandle.Log($"Set the account: {user.GetName()} privileges to: None");
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

                query = $"UPDATE WeatherData SET ContributorID = -1 WHERE ContributorID = {user.GetId()};";
                cmd = new SqlCommand(query, Global.Database);
                cmd.ExecuteNonQuery();

                Global.UserHandle.Log($"Deleted the account: {user.GetName()}");
                Global.Users.Remove(user);

                MessageBox.Show("You have deleted the account from the database successfully.");
                
                ManageUsers_Load(null, null);
            }
            catch (SqlException err)
            {
                MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedValue == null || listUsers.SelectedItem == null)
            {
                return;
            }

            User user = (User)listUsers.SelectedItem;

            if (Instance == null)
            {
                Instance = new FormViewLogs();
                Instance.Show();
            }

            Global.UserHandle.Log($"Viewed logs for: {user.GetName()}");

            DataTable table = new DataTable();
            table.Columns.Add("Log ID", typeof(int));
            table.Columns.Add("User Concerned", typeof(string));
            table.Columns.Add("Record Time", typeof(DateTime));
            table.Columns.Add("Action Logged", typeof(string));

            foreach(var log in Global.Logs.Where(c => c.User == user).OrderBy(l => l.Timestamp).ToList())
            {
                table.Rows.Add(log.Id, log.User.Name, log.Timestamp.ToString("yyyy-MM-dd HH:mm:ss"), log.Action);
            }
            Instance.dataGridView1.DataSource = table;
            Instance.dataGridView1.Refresh();
            Instance.dataGridView1.AutoResizeColumns();
            //Instance.dataGridView1.Columns[0].Width;
        }
    }
}
