using DevExpress.DocumentView;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
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
            if (Global.WeatherData.Count == 0)
            {
                lblLocationName.Text = "No Data";
                lblDay.Text = "There are no weather entries";

                this.Controls.Remove(panelMiscInfo);
                this.Controls.Remove(lblHighest);
                this.Controls.Remove(lblLowest);
                this.Controls.Remove(lblLowHighSep);
                this.Controls.Remove(separatorControl1);
                this.Controls.Remove(lblTemperature);

                lblCondition.Text = "No data to display";
                return;
            }

            Random rand = new Random();

            List<Tuple<City, List<Weather>>> data = new List<Tuple<City, List<Weather>>>();
            
            int randHour = 0, attempts = 0;

            while (data.Count == 0)
            {
                randHour = rand.Next(0, 21);

                foreach (var a in Global.Cities)
                {
                    var b = Global.WeatherData.FindAll(x => x.GetParent() == a);

                    // Yesterday
                    if (b.Count(c => (c.GetTimestamp().Date == DateTime.Now.AddDays(-1).Date) && c.GetTimestamp().Hour == randHour) >= 1 &&
                        b.Count(c => (c.GetTimestamp().Date == DateTime.Now.AddDays(-1).Date) && c.GetTimestamp().Hour == randHour + 1) >= 1 &&
                        b.Count(c => (c.GetTimestamp().Date == DateTime.Now.AddDays(-1).Date) && c.GetTimestamp().Hour == randHour + 2) >= 1)
                    {
                        var list = b.FindAll(c => (c.GetTimestamp().Date == DateTime.Now.AddDays(-1).Date)
                            && (c.GetTimestamp().Hour == randHour || c.GetTimestamp().Hour == randHour + 1 ||
                            c.GetTimestamp().Hour == randHour + 2));

                        data.Add(new Tuple<City, List<Weather>>(a, list));
                    }

                    // Today
                    if (b.Count(c => (c.GetTimestamp().Date == DateTime.Now.Date) && c.GetTimestamp().Hour == randHour) >= 1 &&
                        b.Count(c => (c.GetTimestamp().Date == DateTime.Now.Date) && c.GetTimestamp().Hour == randHour + 1) >= 1 &&
                        b.Count(c => (c.GetTimestamp().Date == DateTime.Now.Date) && c.GetTimestamp().Hour == randHour + 2) >= 1)
                    {
                        var list = b.FindAll(c => (c.GetTimestamp().Date == DateTime.Now.Date)
                            && (c.GetTimestamp().Hour == randHour || c.GetTimestamp().Hour == randHour + 1 ||
                            c.GetTimestamp().Hour == randHour + 2));

                        data.Add(new Tuple<City, List<Weather>>(a, list));
                    }

                    // Tomorrow
                    if (b.Count(c => (c.GetTimestamp().Date == DateTime.Now.AddDays(1).Date) && c.GetTimestamp().Hour == randHour) >= 1 &&
                        b.Count(c => (c.GetTimestamp().Date == DateTime.Now.AddDays(1).Date) && c.GetTimestamp().Hour == randHour + 1) >= 1 &&
                        b.Count(c => (c.GetTimestamp().Date == DateTime.Now.AddDays(1).Date) && c.GetTimestamp().Hour == randHour + 2) >= 1)
                    {
                        var list = b.FindAll(c => (c.GetTimestamp().Date == DateTime.Now.AddDays(1).Date)
                            && (c.GetTimestamp().Hour == randHour || c.GetTimestamp().Hour == randHour + 1 ||
                            c.GetTimestamp().Hour == randHour + 2));

                        data.Add(new Tuple<City, List<Weather>>(a, list));
                    }
                }
                attempts++;

                if (attempts >= 50) break;
            }

            if (data.Count == 0)
            {
                lblLocationName.Text = "Not enough data";
                lblDay.Text = "Please fetch from settings";

                this.Controls.Remove(panelMiscInfo);
                this.Controls.Remove(lblHighest);
                this.Controls.Remove(lblLowest);
                this.Controls.Remove(lblLowHighSep);
                this.Controls.Remove(separatorControl1);
                this.Controls.Remove(lblTemperature);

                lblCondition.Text = "There needs to be at least one city with yesterday, tomorrow (predicted) or today data for 3 consequent hours.";
                lblCondition.Font = new Font(lblCondition.Font.FontFamily, 10);
                return;
            }

            var selected = data[new Random().Next(data.Count)];

            lblLocationName.Text = selected.Item1.GetName();

            if (selected.Item2[0].GetTimestamp().Date == DateTime.Now.AddDays(-1).Date) lblDay.Text = "Yesterday";
            else if (selected.Item2[0].GetTimestamp().Date == DateTime.Now.AddDays(1).Date) lblDay.Text = "Tomorrow (Predicted)";
            else if (selected.Item2[0].GetTimestamp().Date == DateTime.Now.Date) lblDay.Text = "Today";

            var now = selected.Item2.Find(a => a.GetTimestamp().Hour == randHour);
            var h2 = selected.Item2.Find(a => a.GetTimestamp().Hour == randHour + 1);
            var h3 = selected.Item2.Find(a => a.GetTimestamp().Hour == randHour + 2);

            lblHr1.Text = randHour != DateTime.Now.Hour ? $"{randHour}:00" : "Now";
            lblHr2.Text = randHour+1 != DateTime.Now.Hour ? $"{randHour + 1}:00" : "Now";
            lblHr3.Text = randHour+2 != DateTime.Now.Hour ? $"{randHour + 2}:00" : "Now";

            lblCondition.Text = now.GetCondition();

            int lowest = Convert.ToInt32(now.GetTemperature());
            int highest = Convert.ToInt32(now.GetTemperature());

            if (Convert.ToInt32(h2.GetTemperature()) < lowest) lowest = Convert.ToInt32(h2.GetTemperature());
            if (Convert.ToInt32(h3.GetTemperature()) < lowest) lowest = Convert.ToInt32(h3.GetTemperature());

            if (Convert.ToInt32(h2.GetTemperature()) > highest) highest = Convert.ToInt32(h2.GetTemperature());
            if (Convert.ToInt32(h3.GetTemperature()) < highest) highest = Convert.ToInt32(h3.GetTemperature());

            if (Global.UserHandle.DisplayCelsius)
            {
                lblTemperature.Text = $"{Convert.ToInt32(now.GetTemperature())} °C";

                lblLowest.Text = $"{lowest} °C";
                lblHighest.Text = $"{highest} °C";

                lblHr1Temp.Text = $"{Convert.ToInt32(now.GetTemperature())}°C";
                lblHr2Temp.Text = $"{Convert.ToInt32(h2.GetTemperature())}°C";
                lblHr3Temp.Text = $"{Convert.ToInt32(h3.GetTemperature())}°C";
            }
            else
            {
                lblTemperature.Text = $"{Global.CelsiusToFahrenheit(Convert.ToInt32(now.GetTemperature()))} °F";

                lblLowest.Text = $"{Global.CelsiusToFahrenheit(lowest)} °F";
                lblHighest.Text = $"{Global.CelsiusToFahrenheit(highest)} °F";

                lblHr1Temp.Text = $"{Global.CelsiusToFahrenheit(Convert.ToInt32(now.GetTemperature()))}°F";
                lblHr2Temp.Text = $"{Global.CelsiusToFahrenheit(Convert.ToInt32(h2.GetTemperature()))}°F";
                lblHr3Temp.Text = $"{Global.CelsiusToFahrenheit(Convert.ToInt32(h3.GetTemperature()))}°F";
            }

            

            lblHr1Wind.Text = $"{Convert.ToInt32(now.GetWindKPH())} KM/H";
            lblHr2Wind.Text = $"{Convert.ToInt32(h2.GetWindKPH())} KM/H";
            lblHr3Wind.Text = $"{Convert.ToInt32(h3.GetWindKPH())} KM/H";

            lblHr1Rain.Text = $"{now.GetRainChance()}%";
            lblHr2Rain.Text = $"{h2.GetRainChance()}%";
            lblHr3Rain.Text = $"{h3.GetRainChance()}%";

            svgHr1.SvgImage = GetImageFromCondition(now.GetCondition());
            svgHr2.SvgImage = GetImageFromCondition(h2.GetCondition());
            svgHr3.SvgImage = GetImageFromCondition(h3.GetCondition());
        }

        public DevExpress.Utils.Svg.SvgImage GetImageFromCondition(string condition)
        {
            if (condition.ToLower().Contains("cloudy")) return weatherIconCollection[1];
            else if (condition.ToLower().Contains("patchy rain") || condition.ToLower().Contains("drizzle") || condition.ToLower().Contains("shower")) return weatherIconCollection[6];
            else if (condition.ToLower().Contains("overcast")) return weatherIconCollection[2];
            else if (condition.ToLower().Contains("heavy rain")) return weatherIconCollection[5];
            else if (condition.ToLower().Contains("rain")) return weatherIconCollection[3];
            else if (condition.ToLower().Contains("sunny")) return weatherIconCollection[12];
            else if (condition.ToLower().Contains("thunder") || condition.ToLower().Contains("thunderstorm") || condition.ToLower().Contains("storm")) return weatherIconCollection[11];
            else if (condition.ToLower().Contains("snow") || condition.ToLower().Contains("snowing")) return weatherIconCollection[7];
            else if (condition.ToLower().Contains("wind") || condition.ToLower().Contains("windy")) return weatherIconCollection[14];
            else if (condition.ToLower().Contains("hail") || condition.ToLower().Contains("hailing")) return weatherIconCollection[4];


            return weatherIconCollection[1];
        }
    }
}
