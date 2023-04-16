using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecaster
{
    public partial class RegisterControl : DevExpress.XtraEditors.XtraUserControl
    {
        public RegisterControl()
        {
            InitializeComponent();
        }

        private void btnGoLogin_Click(object sender, EventArgs e)
        {
            Global.MainForm.Clear();

            Global.MainForm.Controls.Add(new LoginControl() { Dock = DockStyle.Fill });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length < 3 || (txtEmail.Text.Length < 3 || !txtEmail.Text.Contains("@")) || txtPassword.Text.Length < 3 || 
             (txtConfirmPass.Text != txtPassword.Text && txtPassword.Text.Length >= 3))
            {
                MessageBox.Show("Please resolve all errors!");
                return;
            }
        }

        private void txtUsername_EditValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUsername, "");
            if (txtUsername.Text.Length < 3)
            {
                errorProvider1.SetError(txtUsername, "Username cannot be smaller than 3 characters");
            }
        }

        private void txtEmail_EditValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtEmail, "");
            if (txtEmail.Text.Length < 3 || !txtEmail.Text.Contains("@"))
            {
                errorProvider1.SetError(txtEmail, "Invalid email");
            }
        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtConfirmPass, "");
            if (txtPassword.Text.Length < 3)
            {
                errorProvider1.SetError(txtConfirmPass, "Password should be more than 3 characters");
            }


            if (txtConfirmPass.Text != txtPassword.Text && txtPassword.Text.Length >= 3)
            {
                errorProvider1.SetError(txtConfirmPass, "Passwords do not match!");
            }
        }

        private void txtConfirmPass_EditValueChanged(object sender, EventArgs e)
        {
            txtPassword_EditValueChanged(sender, e);
        }
    }
}
