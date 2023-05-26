using DevExpress.Drawing.Internal.Fonts.Interop;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecaster.Pages
{
    public partial class Register : DevExpress.XtraEditors.XtraUserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnGoLogin_Click(object sender, EventArgs e)
        {
            Global.MainForm.Clear();

            Global.MainForm.Controls.Add(new Login() { Dock = DockStyle.Fill });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User(1, txtUsername.Text, txtEmail.Text, true);
            user.Password = txtPassword.Text;

            ValidationContext context = new ValidationContext(user, null, null);

           
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(user, context, validationResults, true);
            if (!valid || txtConfirmPass.Text != txtPassword.Text)
            {
                MessageBox.Show("Please resolve all errors!\nHover over the error icon for more.");
                return;
            }

            string query = $"INSERT INTO Users " +
                $"(Username, Email, Password) OUTPUT INSERTED.ID " +
                $"VALUES ('{user.Name}', '{user.Email}', '{user.Password}');";

            try { 
                SqlCommand cmd = new SqlCommand(query, Global.Database);

                int aID = (int)cmd.ExecuteScalar();

                MessageBox.Show($"Your account has been created!\nAccount ID: {aID}\nUsername: {user.Name}\nEmail: {user.Email}\n\nPlease proceed to login now!", "Account Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGoLogin_Click(sender, e);

                new User(aID, txtUsername.Text, txtEmail.Text, true);
            }
            catch (SqlException err) 
            {
                if (err.Message.Contains("Violation of UNIQUE KEY"))
                {
                    MessageBox.Show("An account with the name \"" + user.Name + "\" already exists!\nTry another name.", "Username already exists!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_EditValueChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtUsername, "");
            tickProvider.SetError(txtUsername, "");

            User user = new User(1, txtUsername.Text, "email@gmail.com", true);
            user.Password = "correctpassword";
            ValidationContext context = new ValidationContext(user, null, null);

            if (user != null)
            {
                List<ValidationResult> validationResults = new List<ValidationResult>();
                bool valid = Validator.TryValidateObject(user, context, validationResults, true);
                if (!valid)
                {
                    errorProvider.SetError(txtUsername, validationResults[0].ErrorMessage);
                }
            }

            if (errorProvider.GetError(txtUsername) == "") tickProvider.SetError(txtUsername, "Username is valid");
        }

        private void txtEmail_EditValueChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtEmail, "");
            tickProvider.SetError(txtEmail, "");

            User user = new User(1, "username", txtEmail.Text, true);
            user.Password = "correctpassword";
            ValidationContext context = new ValidationContext(user, null, null);

            if (user != null)
            {
                List<ValidationResult> validationResults = new List<ValidationResult>();
                bool valid = Validator.TryValidateObject(user, context, validationResults, true);
                if (!valid)
                {
                    errorProvider.SetError(txtEmail, validationResults[0].ErrorMessage);
                }
            }

            if (errorProvider.GetError(txtEmail) == "") tickProvider.SetError(txtEmail, "Email is valid");
        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtConfirmPass, "");
            tickProvider.SetError(txtConfirmPass, "");

            User user = new User(1, "username", "email@gmail.com", true);
            user.Password = txtPassword.Text;
            ValidationContext context = new ValidationContext(user, null, null);

            if (user != null)
            {
                List<ValidationResult> validationResults = new List<ValidationResult>();
                bool valid = Validator.TryValidateObject(user, context, validationResults, true);
                if (!valid)
                {
                    errorProvider.SetError(txtConfirmPass, validationResults[0].ErrorMessage);
                }
                else
                {
                    if (txtConfirmPass.Text != txtPassword.Text)
                    {
                        errorProvider.SetError(txtConfirmPass, "Passwords do not match!");
                    }
                }
            }

            if (errorProvider.GetError(txtConfirmPass) == "") tickProvider.SetError(txtConfirmPass, "Password matches");
        }

        private void txtConfirmPass_EditValueChanged(object sender, EventArgs e)
        {
            txtPassword_EditValueChanged(sender, e);
        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                errorProvider.SetIconPadding(c, 10);
                tickProvider.SetIconPadding(c, 10);
            }

            txtUsername_EditValueChanged(sender, e);
            txtEmail_EditValueChanged(sender, e);
            txtPassword_EditValueChanged(sender, e);
        }
    }
}
