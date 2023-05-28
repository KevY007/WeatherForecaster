using DevExpress.Charts.Native;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherForecaster;

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
            listClass.DataSource = new List<TypeString>();

            if (Instance == null)
            {
                Instance = new FormAnalytics();
                Instance.Show();
            }


            List<Weather> ents = new List<Weather>();
            List<Country> countries = new List<Country>();
            List<City> cities = new List<City>();
            foreach(var c1 in Global.Continents)
            {
                foreach(var c2 in c1.Countries)
                {
                    countries.Add(c2);
                    foreach(var c3 in c2.Cities)
                    {
                        cities.Add(c3);
                        ents.AddRange(c3.WeatherData);
                    }
                }
            }

            List<TypeString> list = new List<TypeString>();
            list.Add(new TypeString("Continents", typeof(Continent), Global.Continents));
            list.Add(new TypeString("Countries", typeof(Country), countries));
            list.Add(new TypeString("Cities", typeof(City), cities));
            list.Add(new TypeString("Weather Entries", typeof(Weather), ents));

            listClass.DataSource = list;
            listClass.DisplayMember = "Display";
            listClass.ValueMember = "Value";



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

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            listMember.DataSource = new List<string>();
            listSubMember.DataSource = new List<string>();
    
            TypeString item = (TypeString)listClass.SelectedItem;

            List<string> members = new List<string>();
            foreach(dynamic a in item.Items)
            {
                members.Add((string)a.Name);
            }

            listMember.DataSource = members;
        }
    }

    public class TypeString
    {
        public string Display { get; set; }
        public Type Value { get; set; }
        public dynamic Items { get; set; }

        public TypeString(string o, Type v)
        {
            Display = o;
            Value = v;
            Items = new List<object>();
        }
        public TypeString(string o, Type v, object i)
        {
            Display = o;
            Value = v;
            Items = i;
        }
    }

}
