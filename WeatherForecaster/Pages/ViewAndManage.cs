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

namespace WeatherForecaster.Pages
{
    public partial class ViewAndManage : DevExpress.XtraEditors.XtraUserControl
    {
        public ViewAndManage()
        {
            InitializeComponent();
        }

        private void ViewAndManage_Load(object sender, EventArgs e)
        {
            foreach(var continent in Global.Continents)
            {
                TreeNode ncontinent = viewer.Nodes.Add($"{continent.Name} (ID: {continent.Id})");

                foreach (var country in continent.Countries)
                {
                    TreeNode ncountry = ncontinent.Nodes.Add($"{country.Name} (ID: {country.Id})");

                    foreach (var city in country.Cities)
                    {
                        TreeNode ncity = ncountry.Nodes.Add($"{city.Name} (ID: {city.Id}) ({city.WeatherData.Count})");

                        foreach (var wd in city.WeatherData)
                        {
                            TreeNode nwd = ncity.Nodes.Add($"{wd.GetTimestamp()} " +
                                $"{(Global.UserHandle.DisplayCelsius == true ? ($"{wd.GetTemperature()}°C") : ($"{Global.CelsiusToFahrenheit(wd.GetTemperature())}°F"))} " +
                                $"(ID: {wd.Id})");

                            
                            nwd.ToolTipText = $"Humid: {wd.GetHumidity()}% | Rain: {wd.GetRainChance()}% | Wind: {wd.GetWindKPH()} KM/H" + Environment.NewLine + $"UV: {wd.GetUVIndex()} | Precipitation: {wd.GetPrecipitation()}mm | Cloud: {wd.GetCloud()}%";
                        }
                    }
                }
            }
        }
    }
}
