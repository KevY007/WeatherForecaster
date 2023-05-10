﻿using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TextEditController.Win32;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        }

        private void btnGoSignup_Click(object sender, EventArgs e)
        {
            Global.MainForm.Clear();

            Global.MainForm.Controls.Add(new Register() { Dock = DockStyle.Fill });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Global.Users.Count(u => u.GetName() == txtUsername.Text) == 0)
            {
                MessageBox.Show("The account \"" + txtUsername.Text + "\" does not exist!", "Invalid account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                return;
            }

            string salt = Global.GenerateSalt();
            string hashed = Global.ComputeHash(txtPassword.Text, salt);

            string query = $"SELECT ID, Password, Salt, PrivilegeLevel FROM Users WHERE Username = '{txtUsername.Text}'";

            try
            {
                SqlCommand cmd = new SqlCommand(query, Global.Database);

            
                var reader = cmd.ExecuteReader();

                reader.Read();

                if((string)reader["Password"] != Global.ComputeHash(txtPassword.Text, (string)reader["Salt"]))
                {
                    MessageBox.Show("Incorrect password! Please try again.", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
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