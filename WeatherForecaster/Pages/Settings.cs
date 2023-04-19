using DevExpress.DataAccess.Sql;
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
using WeatherForecaster.Properties;

namespace WeatherForecaster.Pages
{
    public partial class Settings : DevExpress.XtraEditors.XtraUserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            centigradeSwitch.IsOn = Global.UserHandle.DisplayCelcius;
        }

        private void centigradeSwitch_Toggled(object sender, EventArgs e)
        {
            Global.UserHandle.DisplayCelcius = centigradeSwitch.IsOn;
        }
    }
}
