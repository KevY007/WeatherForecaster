using DevExpress.Charts.Native;
using DevExpress.XtraCharts;
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

    public partial class Analytics : DevExpress.XtraEditors.XtraUserControl
    {
        public static FormAnalytics Instance { get; set; }
        public Analytics()
        {
            InitializeComponent();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            if (Instance == null)
            {
                Instance = new FormAnalytics();
                Instance.Show();
            }


            List<Weather> weatherData = new List<Weather>();
            foreach(var c1 in Global.Continents)
            {
                foreach(var c2 in c1.Countries)
                {
                    foreach(var c3 in c2.Cities)
                    {
                        weatherData = c3.WeatherData;
                        break;
                    }
                    break;
                }
                break;
            }

            // Create a line series.
            Series series1 = new Series("Series 1", ViewType.Line);

            // Add points to it.
            series1.Points.Add(new SeriesPoint(1, 2));
            series1.Points.Add(new SeriesPoint(2, 12));
            series1.Points.Add(new SeriesPoint(3, 14));
            series1.Points.Add(new SeriesPoint(4, 17));

            // Add the series to the chart.
            Instance.chartControl1.Series.Add(series1);

            // Set the numerical argument scale types for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical;

            // Access the view-type-specific options of the series.
            ((LineSeriesView)series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series1.View).LineMarkerOptions.Size = 20;
            ((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
            ((LineSeriesView)series1.View).LineStyle.DashStyle = DashStyle.Dash;

            // Access the view-type-specific options of the series.
            ((XYDiagram)Instance.chartControl1.Diagram).AxisY.Interlaced = true;
            ((XYDiagram)Instance.chartControl1.Diagram).AxisY.InterlacedColor = Color.FromArgb(20, 60, 60, 60);
            ((XYDiagram)Instance.chartControl1.Diagram).AxisX.NumericScaleOptions.AutoGrid = false;
            ((XYDiagram)Instance.chartControl1.Diagram).AxisX.NumericScaleOptions.GridSpacing = 1;

            // Hide the legend (if necessary).
            Instance.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add a title to the chart (if necessary).
            Instance.chartControl1.Titles.Add(new ChartTitle());
            Instance.chartControl1.Titles[0].Text = "Line Chart";

        }
    }
}
