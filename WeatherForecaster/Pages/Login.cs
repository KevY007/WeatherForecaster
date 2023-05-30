using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TextEditController.Win32;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecaster.Pages
{
    public partial class Login : DevExpress.XtraEditors.XtraUserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            // Check out the Register form first to understand the code better.z
        }

        private void btnGoSignup_Click(object sender, EventArgs e)
        {
            Global.MainForm.Clear();

            Global.MainForm.Controls.Add(new Register() { Dock = DockStyle.Fill });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(1, txtUsername.Text, "email@gmail.com", true);
            user.Password = txtPassword.Text;

            ValidationContext context = new ValidationContext(user, null, null);

            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(user, context, validationResults, true);
            if (!valid)
            {
                MessageBox.Show("Please input valid credentials.");
                return;
            }


            if (Global.Users.Count(u => u.GetName() == txtUsername.Text) == 0)
            {
                MessageBox.Show("The account \"" + txtUsername.Text + "\" does not exist!", "Invalid account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                return;
            }

            string query = $"SELECT ID, Password, PrivilegeLevel FROM Users WHERE Username = '{txtUsername.Text}'";

            try
            {
                SqlCommand cmd = new SqlCommand(query, Global.Database);

                var reader = cmd.ExecuteReader();
                
                if(!reader.HasRows)
                {
                    MessageBox.Show("The account \"" + txtUsername.Text + "\" does not exist!", "Invalid account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    reader.Close();
                    return;
                }
                reader.Read();

                if((string)reader["Password"] != txtPassword.Text)
                {
                    MessageBox.Show("Incorrect password! Please try again.", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    reader.Close();
                    return;
                }

                reader.Close();

                Global.UserHandle = Global.Users.Find(u => u.GetName() == txtUsername.Text);

                MessageBox.Show($"Logged in to account ID {Global.UserHandle.GetId()} successfully.", "Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Global.MainForm.OnSignupLogin();
            }
            catch (SqlException err)
            {
                MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
