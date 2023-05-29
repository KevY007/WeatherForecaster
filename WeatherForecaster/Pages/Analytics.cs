using DevExpress.Charts.Native;
using DevExpress.CodeParser;
using DevExpress.Diagram.Core.Shapes;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            listContainer.DataSource = new List<TypeString>();

            btnReset_Click(null, null);

            cmbViewType.DataSource = null;

            List<cViewType> cViewTypes = new List<cViewType>();
            
            foreach (ViewType enumValue in Enum.GetValues(typeof(ViewType)))
            {
                cViewTypes.Add(new cViewType(enumValue.ToString(), enumValue));
            }

            cmbViewType.DataSource = cViewTypes;
            cmbViewType.ValueMember = "vType";
            cmbViewType.DisplayMember = "vName";

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
            list.Add(new TypeString("All", ents));

            foreach (var cont in Global.Continents)
            {
                var contList = new List<Weather>();
                list.Add(new TypeString(cont.Name, contList));

                foreach (var country in cont.Countries)
                {
                    var countryList = new List<Weather>();
                    list.Add(new TypeString("    " + country.Name, countryList));

                    foreach (var city in country.Cities)
                    {
                        list.Add(new TypeString("        " + city.Name, city.WeatherData));

                        countryList.AddRange(city.WeatherData);
                        contList.AddRange(city.WeatherData);
                    }

                    list.First(i => i.Display == "    " + country.Name).Items = countryList;
                }
                list.First(i => i.Display == cont.Name).Items = contList;
            }

            list.First(i => i.Display == "All").Items = ents;

            listContainer.DataSource = list;
            listContainer.DisplayMember = "Display";
            listContainer.ValueMember = null;
        }

        private void listClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            listEntries.DataSource = new List<string>();
            listMember.DataSource = new List<string>();
    
            TypeString item = (TypeString)listContainer.SelectedItem;

            List<string> members = new List<string>();
            members.Add("All");

            foreach(dynamic a in item.Items)
            {
                members.Add((string)a.Name);
            }

            listEntries.DataSource = members;

            List<string> properties = new List<string>();
            properties.Add("All");

            foreach (PropertyInfo prop in typeof(Weather).GetProperties())
                properties.Add(prop.Name);
            
            properties.RemoveAll(s => s == "Timestamp" || s == "Condition" || s == "Name" || s == "Id");

            listEntries.DataSource = members;
            listMember.DataSource = properties;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (Instance != null)
            {
                Instance.Hide();
                Instance.Dispose();
                Instance = null;
            }
            Instance = new FormAnalytics();
            Instance.Show();

            swapAxes.Checked = false;
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            TypeString selected = (TypeString)listContainer.SelectedItem;

            List<WeatherProcessor> dataSource = new List<WeatherProcessor>();

            List<string> properties = new List<string>();

            if (listMember.SelectedItems.Count > 1 || listMember.SelectedItems.Contains("All"))
            {
                if (listMember.SelectedItems.Contains("All")) {
                    properties.AddRange(((List<string>)listMember.DataSource).Where(s => s != "All").ToArray());
                }
                else
                {
                    foreach (string s in listMember.SelectedItems) properties.Add(s);
                }
            }
            else
            {
                properties.Add((string)listMember.SelectedItems[0]);
            }

            if (listEntries.SelectedItems.Count > 1 || listEntries.SelectedItems.Contains("All"))
            {
                for (int i = 0; i < selected.Items.Count; i++)
                {
                    if (!listEntries.SelectedItems.Contains("All") && !listEntries.SelectedItems.Contains(selected.Items[i].Name)) continue;

                    foreach (var prop in properties)
                    {
                        double FixedValue = Math.Round(Convert.ToDouble(typeof(Weather).GetProperty(prop).GetValue(selected.Items[i])), 1);
                        dataSource.Add(new WeatherProcessor(selected.Items[i]) { Series = selected.Items[i].Name + " - " + prop, Value = FixedValue });
                    }
                }
            }
            else
            {
                for (int i = 0; i < selected.Items.Count; i++)
                {
                    if (selected.Items[i].Name == (string)listEntries.SelectedItems[0])
                    {
                        foreach (var prop in properties)
                        {
                            double FixedValue = Math.Round(Convert.ToDouble(typeof(Weather).GetProperty(prop).GetValue(selected.Items[i])), 1);
                            dataSource.Add(new WeatherProcessor(selected.Items[i]) { Series = prop, Value = FixedValue });
                        }
                    }
                }
            }

            try
            {
                Instance.chartControl1.DataSource = dataSource;


                swapAxis_CheckedChanged(null, null);

                Instance.chartControl1.SeriesTemplate.ValueDataMembers.AddRange("Value");
                //Instance.chartControl1.SeriesTemplate.ChangeView(ViewType.Waterfall)

                Instance.chartControl1.Titles.Clear();
            }
            catch { MessageBox.Show("An error has occured. The view or data might be incompatible!"); }
        }

        private void swapAxis_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (swapAxes.Checked)
                {
                    Instance.chartControl1.SeriesTemplate.SeriesDataMember = "Timestamp";
                    Instance.chartControl1.SeriesTemplate.ArgumentDataMember = "Series";
                    Instance.chartControl1.SeriesTemplate.ArgumentScaleType = ScaleType.Auto;
                }
                else
                {
                    Instance.chartControl1.SeriesTemplate.SeriesDataMember = "Series";
                    Instance.chartControl1.SeriesTemplate.ArgumentDataMember = "Timestamp";
                    Instance.chartControl1.SeriesTemplate.ArgumentScaleType = ScaleType.DateTime;
                    Instance.chartControl1.SeriesTemplate.TimeSpanSummaryOptions.MeasureUnit = TimeSpanMeasureUnit.Hour;
                    Instance.chartControl1.SeriesTemplate.DateTimeSummaryOptions.MeasureUnit = DateTimeMeasureUnit.Hour;
                }
            } catch { }
        }

        private void cmbViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbViewType.SelectedItem == null) return;

            var selection = (cViewType)cmbViewType.SelectedItem;
            if(Instance != null) Instance.chartControl1.SeriesTemplate.ChangeView(selection.vType);
        }
    }

    public class cViewType
    {
        public ViewType vType { get; set; }
        public string vName { get; set; }

        public cViewType(string n, ViewType v) { vType = v; vName = n; }
    }

    public class WeatherProcessor : Weather
    {
        public string Series { get; set; }
        public double Value { get; set; }

        public WeatherProcessor(Weather copy) : base(copy) { }
    }

    public class TypeString
    {
        public string Display { get; set; }
        public List<Weather> Items { get; set; }

        public TypeString(string o)
        {
            Display = o;
            Items = new List<Weather>();
        }
        public TypeString(string o, List<Weather> i)
        {
            Display = o;
            Items = i;
        }
    }
}
