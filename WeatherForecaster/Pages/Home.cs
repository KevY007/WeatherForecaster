using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherForecaster;

namespace WeatherForecaster.Pages
{
    public partial class Home : DevExpress.XtraEditors.XtraUserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if(Global.WeatherData.Count == 0)
            {
                lblLocationName.Text = "Unknown";
                lblDay.Text = "No weather entries in program";
                return;
            }

            Random rand = new Random();
            var selected = Global.WeatherData.ElementAt(rand.Next(0, Global.WeatherData.Count));

            
        }
    }
}
