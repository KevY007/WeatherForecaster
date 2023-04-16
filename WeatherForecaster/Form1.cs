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
            foreach (Control c in this.Controls)
            {
                if (!defaultControls.Contains(c.Handle)) Controls.Remove(c);
            }
        }
        public formMain()
        {
            InitializeComponent();

            foreach (Control c in this.Controls) defaultControls.Add(c.Handle);
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            btnLoginSignup_Click(sender, e);

            //Global.DefaultInit();
        }

        private void btnLoginSignup_Click(object sender, EventArgs e)
        {
            Clear();

            this.Controls.Add(new LoginControl() { Dock = DockStyle.Fill });
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
