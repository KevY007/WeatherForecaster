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

            // Create the List of ViewTypes class to use as DataSource.
            List<cViewType> cViewTypes = new List<cViewType>();
            
            // Get and map all possible values.
            foreach (ViewType enumValue in Enum.GetValues(typeof(ViewType)))
            {
                cViewTypes.Add(new cViewType(enumValue.ToString(), enumValue));
            }

            cmbViewType.DataSource = cViewTypes;
            cmbViewType.ValueMember = "vType";
            cmbViewType.DisplayMember = "vName";

            ///////////////////////////////////////////////////////

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

            ///////////////////////////////////////////////////////

            // Initialize the TypeString list.
            // A TypeString class is being used to map names to lists.
            List<TypeString> list = new List<TypeString>();
            list.Add(new TypeString("All", ents)); // Add an "All" item in the list to select all items.

            foreach (var cont in Global.Continents)
            {
                var contList = new List<Weather>();
                list.Add(new TypeString(cont.Name, contList));

                foreach (var country in cont.Countries)
                {
                    var countryList = new List<Weather>();
                    list.Add(new TypeString("    " + country.Name, countryList)); 
                    // Empty spaces to make the items more organized and simulate a tree without using a tree.

                    foreach (var city in country.Cities)
                    {
                        list.Add(new TypeString("        " + city.Name, city.WeatherData));

                        countryList.AddRange(city.WeatherData);
                        contList.AddRange(city.WeatherData);
                    }

                    // Re-assign the list without removing/re-adding it from/to the list so the list item doesn't lose it's position in the list.
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
    
            // Start parsing the TypeString from the selected item:

            TypeString item = (TypeString)listContainer.SelectedItem;

            List<string> members = new List<string>();
            members.Add("All");

            foreach(dynamic a in item.Items)
            {
                members.Add((string)a.Name);
            }

            // Dynamically get all properties of Weather to reduce hard-coding:

            List<string> properties = new List<string>();
            properties.Add("All");
            
            foreach (PropertyInfo prop in typeof(Weather).GetProperties())
                properties.Add(prop.Name);
            

            properties.RemoveAll(s => s == "Timestamp" || s == "Condition" || s == "Name" || s == "Id"); // Remove incompatible known properties

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

            // We will use the WeatherProcessor as an extended class from Weather so we can use it as DataSource.
            // This effectively allows us to add Display and Value members without reconstructing/changing the base Weather class.
            List<WeatherProcessor> dataSource = new List<WeatherProcessor>();

            List<string> properties = new List<string>();

            if (listMember.SelectedItems.Count > 1 || listMember.SelectedItems.Contains("All")) // Multiple properties selected?
            {
                if (listMember.SelectedItems.Contains("All")) { // All properties selected?
                    properties.AddRange(((List<string>)listMember.DataSource).Where(s => s != "All").ToArray());
                }
                else
                {
                    foreach (string s in listMember.SelectedItems) properties.Add(s);
                }
            }
            else // Only one parent selected
            {
                properties.Add((string)listMember.SelectedItems[0]);
            }

            if (listEntries.SelectedItems.Count > 1 || listEntries.SelectedItems.Contains("All")) // Multiple entries being compared?
            {
                for (int i = 0; i < selected.Items.Count; i++)
                {
                    if (!listEntries.SelectedItems.Contains("All") && !listEntries.SelectedItems.Contains(selected.Items[i].Name)) continue;

                    foreach (var prop in properties)
                    {
                        // All the properties are converted into double for the following reason:
                        // DevExpress chart doesn't support using dynamic or object data types as ValueMembers.
                        // I tried everything, dynamically casting, using Convert.ToType even, nothing worked. The datatype has to be specified at runtime.
                        double FixedValue = Math.Round(Convert.ToDouble(typeof(Weather).GetProperty(prop).GetValue(selected.Items[i])), 1);
                        
                        // Using the power of our extendeed class WeatherProcessor to dynamically set Series and Value member according to the selections:
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

            try // Try block because this code tends to break a lot when switching view types etc.
            {
                Instance.chartControl1.DataSource = dataSource;

                swapAxis_CheckedChanged(null, null); // Trigger an axis update.

                Instance.chartControl1.SeriesTemplate.ValueDataMembers.AddRange("Value");

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

    /// <summary>
    /// Eessentially used to map the enum ViewType in a DataSource by having value member and display member properties.
    /// </summary>
    public class cViewType
    {
        /// <summary>
        /// The ViewType value of this instance. Usually a ValueMember.
        /// </summary>
        public ViewType vType { get; set; }
        /// <summary>
        /// The Name of this instance. Usually a DisplayMember.
        /// </summary>
        public string vName { get; set; }

        /// <summary>
        /// Creates an instance of cViewType.
        /// </summary>
        /// <param name="displayname">The display name of the ViewType.</param>
        /// <param name="viewtype">The value of the ViewType.</param>
        public cViewType(string displayname, ViewType viewtype) { vType = viewtype; vName = displayname; }
    }

    /// <summary>
    /// A derived class to use Weather as DataSource.
    /// </summary>
    public class WeatherProcessor : Weather
    {
        /// <summary>
        /// The Display Member property.
        /// </summary>
        public string Series { get; set; }

        /// <summary>
        /// The Value Member property.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Copy constructor to base off of an existing weather instance.
        /// </summary>
        /// <param name="copy">The instance of Weather to copy.</param>
        public WeatherProcessor(Weather copy) : base(copy) { }
    }

    /// <summary>
    /// A class to map DisplayMember and a List as value for using as a DataSource.
    /// </summary>
    public class TypeString
    {
        /// <summary>
        /// The display member.
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// The value member (List)
        /// </summary>
        public List<Weather> Items { get; set; }

        /// <summary>
        /// Creates and initializes a TypeString with empty list.
        /// </summary>
        /// <param name="name">The display name.</param>
        public TypeString(string name)
        {
            Display = name;
            Items = new List<Weather>();
        }

        /// <summary>
        /// Creates and initializes a TypeString with list items copied from another.
        /// </summary>
        /// <param name="name">The display name.</param>
        /// <param name="list">The list to copy off.</param>
        public TypeString(string name, List<Weather> list)
        {
            Display = name;
            Items = list;
        }
    }
}
