using DevExpress.Data.Helpers;
using DevExpress.DirectX.Common.DirectWrite;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using WeatherForecaster.Pages;

namespace WeatherForecaster
{
    public partial class formMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        protected override bool ExtendNavigationControlToFormTitle
        {
            get { return false; }
        }

        public List<IntPtr> defaultControls = new List<IntPtr>();

        public void Clear()
        {
            if(Analytics.Instance != null)
            {
                Analytics.Instance.Hide();
                Analytics.Instance.Dispose();
                Analytics.Instance = null;
            }
            foreach (Control c in this.Controls)
            {
                if (!defaultControls.Contains(c.Handle)) Controls.Remove(c);
            }
        }
        public formMain()
        {
            InitializeComponent();

            foreach (Control c in this.Controls) defaultControls.Add(c.Handle);

            // Hide all the controls before log-in:
            
            foreach(var a in mainMenu.Elements)
            {
                a.Visible = false; // Groups

                foreach(var b in a.Elements)
                {
                    b.Visible = false; // Items/Buttons
                }
            }

            btnGroupAccount.Visible = true;
            btnLoginSignup.Visible = true;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            btnLoginSignup_Click(sender, e);

            //Global.DefaultInit();
        }

        private void btnLoginSignup_Click(object sender, EventArgs e)
        {
            Clear();

            this.Controls.Add(new Pages.Login() { Dock = DockStyle.Fill });
        }

        public void OnSignupLogin()
        {
            Clear();

            // Show all the controls after log-in:

            foreach (var a in mainMenu.Elements)
            {
                a.Visible = true; // Groups

                foreach (var b in a.Elements)
                {
                    b.Visible = true; // Items/Buttons
                }
            }


            // Now hide specific controls
            btnLoginSignup.Visible = false;

            btnHome_Click(null, null);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Clear();

            this.Controls.Add(new Pages.Home() { Dock = DockStyle.Fill });
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            Clear();

            this.Controls.Add(new Pages.Settings() { Dock = DockStyle.Fill });
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if(Global.UserHandle.Privileges != PrivilegeLevels.Admin)
            {
                MessageBox.Show("This area is restricted to admins!", "You lack the required privileges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Clear();

            this.Controls.Add(new Pages.LocationAddRemove() { Dock = DockStyle.Fill });
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if (Global.UserHandle.Privileges != PrivilegeLevels.Admin)
            {
                MessageBox.Show("This area is restricted to admins!", "You lack the required privileges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Clear();

            this.Controls.Add(new Pages.ManageUsers() { Dock = DockStyle.Fill });
        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            Clear();

            this.Controls.Add(new Pages.EntryAddRemove() { Dock = DockStyle.Fill });
        }
        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            Clear();

            this.Controls.Add(new Pages.Analytics() { Dock = DockStyle.Fill });
        }
    }
}
