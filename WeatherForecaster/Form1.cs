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

        /// <summary>
        /// Contains the Control handles of the empty main menu page. 
        /// Used to differentiate between default controls (navigator) and added controls (textboxes).
        /// </summary>
        public List<IntPtr> defaultControls = new List<IntPtr>();

        /// <summary>
        /// Clears all non-default controls off the page. Keeps navigation bar and controls added in designer.
        /// </summary>
        public void Clear()
        {
            // In case Analytics tab was open last time, kill the Analytics form.
            if(Analytics.Instance != null)
            {
                Analytics.Instance.Hide();
                Analytics.Instance.Dispose();
                Analytics.Instance = null;
            }

            // Same with ManageUsers View Logs form.
            if (ManageUsers.Instance != null)
            {
                ManageUsers.Instance.Hide();
                ManageUsers.Instance.Dispose();
                ManageUsers.Instance = null;
            }

            // Remove all elements that don't belong to defaultControls list.
            foreach (Control c in this.Controls)
            {
                if (!defaultControls.Contains(c.Handle)) Controls.Remove(c);
            }
        }

        public formMain()
        {
            InitializeComponent();

            // Since this is called when the form is created upon launch:
            // Get all starting controls and add them to a list for later use in Clear().
            foreach (Control c in this.Controls) defaultControls.Add(c.Handle);


            // Hide all the navigation-bar buttons and groups before log-in:
            foreach(var a in mainMenu.Elements)
            {
                a.Visible = false; // Groups

                foreach(var b in a.Elements)
                {
                    b.Visible = false; // Items/Buttons
                }
            }

            // Display only the Group -> Login/Signup buttons in nav-bar.
            btnGroupAccount.Visible = true;
            btnLoginSignup.Visible = true;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // Simulate a click to the Login button upon form load (application launched; since we never close this main form)
            btnLoginSignup_Click(sender, e);
        }

        private void btnLoginSignup_Click(object sender, EventArgs e)
        {
            // This technique will be used to keep a persistent form but display multiple pages:

            // Clear all elements off the page EXCEPT the default navigation bar and designer-added components.
            Clear();

            // Add the page we are trying to display (as a Control) - this will incorporate it into the current form.
            // But we do not add it to defaultControls list because we want to get rid of all these controls next time we call 'Clear();'.
            this.Controls.Add(new Pages.Login() { Dock = DockStyle.Fill });
        }

        public void OnSignupLogin()
        {
            Clear();

            // Show all the buttons & their groups after successful signup/log-in:

            foreach (var a in mainMenu.Elements)
            {
                a.Visible = true; // Groups

                foreach (var b in a.Elements)
                {
                    b.Visible = true; // Items/Buttons
                }
            }


            // Now hide the login and signup button because, we're already logged in.
            btnLoginSignup.Visible = false;

            // Simulate a click to Home button. Our default main menu "page".
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
            // Check if the user has permissions to even go to the tab.
            // Adding/removing locations, managing users is an admin's authority.
            // Adding/removing entries is a contributor's authority (admin as well since Admin > Contributor).

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
