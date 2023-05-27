﻿using DevExpress.Charts.Native;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WeatherForecaster.Pages
{
    public partial class EntryAddRemove : DevExpress.XtraEditors.XtraUserControl
    {
        public EntryAddRemove()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<int> toRemove = new List<int>();

            foreach (TreeNode continent in viewer.Nodes)
            {
                foreach (TreeNode country in continent.Nodes)
                {
                    foreach (TreeNode city in country.Nodes)
                    {
                        List<TreeNode> removeNodes = new List<TreeNode>();
                        foreach (TreeNode nwd in city.Nodes)
                        {
                            if(nwd.Checked && nwd.Level == 3)
                            {
                                int id = Convert.ToInt32(nwd.Text.Substring(nwd.Text.IndexOf("(ID: ")).Substring(4).Trim(')'));
                                toRemove.Add(id);
                                removeNodes.Add(nwd);
                            }
                        }
                        for(int i = 0; i < removeNodes.Count; i++) city.Nodes.Remove(removeNodes[i]);
                    }
                }
            }

            if(toRemove.Count == 0)
            {
                MessageBox.Show("You have no selected weather entries", "No items selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"DELETE FROM WeatherData WHERE ID = ";

            foreach(int id in toRemove)
            {
                if (id == toRemove[0]) query += $"{id}";
                else if (id == toRemove[toRemove.Count - 1]) query += $" OR ID = {id};";
                else query += $" OR ID = {id}";
            }

            try
            {
                var cmd = new SqlCommand(query, Global.Database);
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show($"Deleted {rows} weather entries successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException err)
            {
                MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
            
            foreach (var continent in Global.Continents)
            {
                foreach (var country in continent.Countries)
                {
                    foreach (var city in country.Cities)
                    {
                        city.WeatherData.RemoveAll(wd => toRemove.Contains(wd.GetId()));
                    }
                }
            }

            // EntryAddRemove_Load(null, null);
        }

        private void CheckChildNodes(TreeNode node, bool check)
        {
            if(node.Nodes.Count >= 0)
            {
                foreach(TreeNode tn in node.Nodes)
                {
                    tn.Checked = check;
                    CheckChildNodes(tn, check);
                }
            }
        }

        private void viewer_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckChildNodes(e.Node, e.Node.Checked);
        }
        private void EntryAddRemove_Load(object sender, EventArgs e)
        {
            timestampDateTimePicker.Format = DateTimePickerFormat.Custom;
            timestampDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            viewer.Nodes.Clear();
            foreach (var continent in Global.Continents)
            {
                TreeNode ncontinent = viewer.Nodes.Add($"{continent.Name} (ID: {continent.Id})");
                ncontinent.ToolTipText = $"Average Temperature: " + (Global.UserHandle.DisplayCelsius == true ? ($"{continent.GetAverageTemperature()}°C") : ($"{Global.CelsiusToFahrenheit(continent.GetAverageTemperature())}°F"));

                foreach (var country in continent.Countries)
                {
                    TreeNode ncountry = ncontinent.Nodes.Add($"{country.Name} (ID: {country.Id})");
                    ncountry.ToolTipText = $"Average Temperature: " + (Global.UserHandle.DisplayCelsius == true ? ($"{country.GetAverageTemperature()}°C") : ($"{Global.CelsiusToFahrenheit(country.GetAverageTemperature())}°F"));

                    foreach (var city in country.Cities)
                    {
                        TreeNode ncity = ncountry.Nodes.Add($"{city.Name} (ID: {city.Id}) ({city.WeatherData.Count})");
                        ncity.ToolTipText = $"Average Temperature: " + (Global.UserHandle.DisplayCelsius == true ? ($"{city.GetAverageTemperature()}°C") : ($"{Global.CelsiusToFahrenheit(city.GetAverageTemperature())}°F"));

                        foreach (var wd in city.WeatherData)
                        {
                            TreeNode nwd = ncity.Nodes.Add($"{wd.GetTimestamp()} " +
                                $"{(Global.UserHandle.DisplayCelsius == true ? ($"{wd.GetTemperature()}°C") : ($"{Global.CelsiusToFahrenheit(wd.GetTemperature())}°F"))} " +
                                $"(ID: {wd.Id})");


                            nwd.ToolTipText = $"Contributor: {(wd.GetContributor() != null ? wd.GetContributor().Name : "N/A")}" + Environment.NewLine + $"Humid: {wd.GetHumidity()}% | Rain: {wd.GetRainChance()}% | Wind: {wd.GetWindKPH()} KM/H" + Environment.NewLine + $"UV: {wd.GetUVIndex()} | Precipitation: {wd.GetPrecipitation()}mm | Cloud: {wd.GetCloud()}%";
                        }
                    }
                }
            }
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            if(viewer.SelectedNode == null || viewer.SelectedNode.Level != 2)
            {
                MessageBox.Show("You have not selected a city in the list! (Double click the city)", "Improper Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Global.UserHandle.Privileges != PrivilegeLevels.Contributor)
            {
                MessageBox.Show("This button is restricted to contributors and admins!", "You lack the required privileges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Weather wd = new Weather(0, timestampDateTimePicker.Value, Convert.ToSingle(temperatureSpinEdit.Value), int.Parse(cloudTextEdit.Text), Convert.ToInt32(humidityNumericUpDown.Value), 
                Convert.ToInt32(rainChanceNumericUpDown.Value), Convert.ToSingle(precipitationSpinEdit.Value), Convert.ToSingle(uVIndexSpinEdit.Value), Convert.ToSingle(windKPHSpinEdit.Value), conditionTextEdit.Text, Global.UserHandle);

            ValidationContext context = new ValidationContext(wd, null, null);

            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(wd, context, validationResults, true);
            
            validationResults.RemoveAll(a => a.MemberNames.Contains("Name"));
            if (validationResults.Count == 0) valid = true;

            if (!valid)
            {
                string errors = "The following errors have been found in your values: \n\n";

                foreach(var a in validationResults)
                {
                    errors += a.ErrorMessage + Environment.NewLine;
                }
                MessageBox.Show(errors, "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string str = viewer.SelectedNode.Text.Substring(viewer.SelectedNode.Text.IndexOf("(ID: ")).Substring(4);
            str = str.Substring(0, str.IndexOf(')'));
            int parentId = Convert.ToInt32(str);

            int continentId = Convert.ToInt32(viewer.SelectedNode.FullPath.Split('\\')[0].Substring(viewer.SelectedNode.FullPath.Split('\\')[0].IndexOf("(ID: ")).Substring(4).Trim(')'));

            try
            {
                string query = "INSERT INTO WeatherData (ParentID, Timestamp, Temperature, Condition, Cloud, Humidity, RainChance, Precipitation, UVIndex, WindKPH, ContributorID) OUTPUT INSERTED.ID VALUES ";
                query += $"({parentId}, '{timestampDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm")}', " +
                    $"{temperatureSpinEdit.Value}, '{conditionTextEdit.Text}', {cloudTextEdit.Value}, " +
                    $"{humidityNumericUpDown.Value}, {rainChanceNumericUpDown.Value}, " +
                $"{precipitationSpinEdit.Value}, {uVIndexSpinEdit.Value}, {windKPHSpinEdit.Value}, {Global.UserHandle.GetId()}); ";

                SqlCommand cmd = new SqlCommand(query, Global.Database);
                int aID = (int)cmd.ExecuteScalar();

                ((City)Global.Continents.First(a => a.GetId() == continentId).GetChildOfChild(parentId)).AddWeather(new Weather(aID, timestampDateTimePicker.Value, Convert.ToSingle(temperatureSpinEdit.Value), int.Parse(cloudTextEdit.Text), Convert.ToInt32(humidityNumericUpDown.Value),
                Convert.ToInt32(rainChanceNumericUpDown.Value), Convert.ToSingle(precipitationSpinEdit.Value), Convert.ToSingle(uVIndexSpinEdit.Value), Convert.ToSingle(windKPHSpinEdit.Value), conditionTextEdit.Text, Global.UserHandle));
            }
            catch (SqlException err)
            {
                MessageBox.Show("An error with the database has occured, please contact a technician!\n\n" + err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}