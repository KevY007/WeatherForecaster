namespace WeatherForecaster.Pages
{
    partial class EntryAddRemove
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cloudLabel;
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label humidityLabel;
            System.Windows.Forms.Label precipitationLabel;
            System.Windows.Forms.Label rainChanceLabel;
            System.Windows.Forms.Label temperatureLabel;
            System.Windows.Forms.Label timestampLabel;
            System.Windows.Forms.Label uVIndexLabel;
            System.Windows.Forms.Label windKPHLabel;
            this.viewer = new System.Windows.Forms.TreeView();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.weatherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cloudTextEdit = new System.Windows.Forms.NumericUpDown();
            this.conditionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.humidityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.precipitationSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.rainChanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.temperatureSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.timestampDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uVIndexSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.windKPHSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.btnAddEntry = new DevExpress.XtraEditors.SimpleButton();
            cloudLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            humidityLabel = new System.Windows.Forms.Label();
            precipitationLabel = new System.Windows.Forms.Label();
            rainChanceLabel = new System.Windows.Forms.Label();
            temperatureLabel = new System.Windows.Forms.Label();
            timestampLabel = new System.Windows.Forms.Label();
            uVIndexLabel = new System.Windows.Forms.Label();
            windKPHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precipitationSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainChanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVIndexSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windKPHSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cloudLabel
            // 
            cloudLabel.AutoSize = true;
            cloudLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cloudLabel.Location = new System.Drawing.Point(126, 464);
            cloudLabel.Name = "cloudLabel";
            cloudLabel.Size = new System.Drawing.Size(110, 22);
            cloudLabel.TabIndex = 14;
            cloudLabel.Text = "Cloud (%):";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            conditionLabel.Location = new System.Drawing.Point(126, 508);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(103, 22);
            conditionLabel.TabIndex = 16;
            conditionLabel.Text = "Condition:";
            // 
            // humidityLabel
            // 
            humidityLabel.AutoSize = true;
            humidityLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            humidityLabel.Location = new System.Drawing.Point(489, 464);
            humidityLabel.Name = "humidityLabel";
            humidityLabel.Size = new System.Drawing.Size(141, 22);
            humidityLabel.TabIndex = 18;
            humidityLabel.Text = "Humidity (%):";
            // 
            // precipitationLabel
            // 
            precipitationLabel.AutoSize = true;
            precipitationLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precipitationLabel.Location = new System.Drawing.Point(489, 508);
            precipitationLabel.Name = "precipitationLabel";
            precipitationLabel.Size = new System.Drawing.Size(188, 22);
            precipitationLabel.TabIndex = 20;
            precipitationLabel.Text = "Precipitation (mm):";
            // 
            // rainChanceLabel
            // 
            rainChanceLabel.AutoSize = true;
            rainChanceLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rainChanceLabel.Location = new System.Drawing.Point(126, 554);
            rainChanceLabel.Name = "rainChanceLabel";
            rainChanceLabel.Size = new System.Drawing.Size(99, 22);
            rainChanceLabel.TabIndex = 22;
            rainChanceLabel.Text = "Rain (%):";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            temperatureLabel.Location = new System.Drawing.Point(489, 554);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(113, 22);
            temperatureLabel.TabIndex = 24;
            temperatureLabel.Text = "Temp (*C):";
            // 
            // timestampLabel
            // 
            timestampLabel.AutoSize = true;
            timestampLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timestampLabel.Location = new System.Drawing.Point(126, 605);
            timestampLabel.Name = "timestampLabel";
            timestampLabel.Size = new System.Drawing.Size(119, 22);
            timestampLabel.TabIndex = 26;
            timestampLabel.Text = "Timestamp:";
            // 
            // uVIndexLabel
            // 
            uVIndexLabel.AutoSize = true;
            uVIndexLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uVIndexLabel.Location = new System.Drawing.Point(489, 605);
            uVIndexLabel.Name = "uVIndexLabel";
            uVIndexLabel.Size = new System.Drawing.Size(164, 22);
            uVIndexLabel.TabIndex = 28;
            uVIndexLabel.Text = "UV Index (0-10):";
            // 
            // windKPHLabel
            // 
            windKPHLabel.AutoSize = true;
            windKPHLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            windKPHLabel.Location = new System.Drawing.Point(126, 656);
            windKPHLabel.Name = "windKPHLabel";
            windKPHLabel.Size = new System.Drawing.Size(122, 22);
            windKPHLabel.TabIndex = 30;
            windKPHLabel.Text = "Wind (KPH):";
            // 
            // viewer
            // 
            this.viewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.viewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewer.CheckBoxes = true;
            this.viewer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewer.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewer.Indent = 21;
            this.viewer.LineColor = System.Drawing.Color.Gray;
            this.viewer.Location = new System.Drawing.Point(101, 32);
            this.viewer.Name = "viewer";
            this.viewer.ShowNodeToolTips = true;
            this.viewer.Size = new System.Drawing.Size(1114, 393);
            this.viewer.TabIndex = 0;
            this.viewer.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.viewer_AfterCheck);
            // 
            // btnRemove
            // 
            this.btnRemove.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRemove.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnRemove.Appearance.Options.UseBackColor = true;
            this.btnRemove.Appearance.Options.UseBorderColor = true;
            this.btnRemove.AppearanceHovered.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRemove.AppearanceHovered.Options.UseBackColor = true;
            this.btnRemove.AppearanceHovered.Options.UseForeColor = true;
            this.btnRemove.Location = new System.Drawing.Point(1001, 458);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(214, 44);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove Selected Entries";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // weatherBindingSource
            // 
            this.weatherBindingSource.DataSource = typeof(WeatherForecaster.Weather);
            // 
            // cloudTextEdit
            // 
            this.cloudTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.weatherBindingSource, "Cloud", true));
            this.cloudTextEdit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudTextEdit.Location = new System.Drawing.Point(264, 461);
            this.cloudTextEdit.Name = "cloudTextEdit";
            this.cloudTextEdit.Size = new System.Drawing.Size(200, 29);
            this.cloudTextEdit.TabIndex = 15;
            this.cloudTextEdit.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // conditionTextEdit
            // 
            this.conditionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.weatherBindingSource, "Condition", true));
            this.conditionTextEdit.EditValue = "Cloudy";
            this.conditionTextEdit.Location = new System.Drawing.Point(264, 505);
            this.conditionTextEdit.Name = "conditionTextEdit";
            this.conditionTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionTextEdit.Properties.Appearance.Options.UseFont = true;
            this.conditionTextEdit.Size = new System.Drawing.Size(200, 28);
            this.conditionTextEdit.TabIndex = 17;
            // 
            // humidityNumericUpDown
            // 
            this.humidityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.weatherBindingSource, "Humidity", true));
            this.humidityNumericUpDown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityNumericUpDown.Location = new System.Drawing.Point(682, 462);
            this.humidityNumericUpDown.Name = "humidityNumericUpDown";
            this.humidityNumericUpDown.Size = new System.Drawing.Size(200, 29);
            this.humidityNumericUpDown.TabIndex = 19;
            // 
            // precipitationSpinEdit
            // 
            this.precipitationSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.weatherBindingSource, "Precipitation", true));
            this.precipitationSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.precipitationSpinEdit.Location = new System.Drawing.Point(682, 507);
            this.precipitationSpinEdit.Name = "precipitationSpinEdit";
            this.precipitationSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipitationSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.precipitationSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.precipitationSpinEdit.Size = new System.Drawing.Size(200, 28);
            this.precipitationSpinEdit.TabIndex = 21;
            // 
            // rainChanceNumericUpDown
            // 
            this.rainChanceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.weatherBindingSource, "RainChance", true));
            this.rainChanceNumericUpDown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainChanceNumericUpDown.Location = new System.Drawing.Point(264, 552);
            this.rainChanceNumericUpDown.Name = "rainChanceNumericUpDown";
            this.rainChanceNumericUpDown.Size = new System.Drawing.Size(200, 29);
            this.rainChanceNumericUpDown.TabIndex = 23;
            // 
            // temperatureSpinEdit
            // 
            this.temperatureSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.weatherBindingSource, "Temperature", true));
            this.temperatureSpinEdit.EditValue = new decimal(new int[] {
            260,
            0,
            0,
            65536});
            this.temperatureSpinEdit.Location = new System.Drawing.Point(682, 553);
            this.temperatureSpinEdit.Name = "temperatureSpinEdit";
            this.temperatureSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.temperatureSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.temperatureSpinEdit.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.temperatureSpinEdit.Properties.MinValue = new decimal(new int[] {
            27315,
            0,
            0,
            -2147352576});
            this.temperatureSpinEdit.Size = new System.Drawing.Size(200, 28);
            this.temperatureSpinEdit.TabIndex = 25;
            // 
            // timestampDateTimePicker
            // 
            this.timestampDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.weatherBindingSource, "Timestamp", true));
            this.timestampDateTimePicker.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timestampDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timestampDateTimePicker.Location = new System.Drawing.Point(264, 605);
            this.timestampDateTimePicker.Name = "timestampDateTimePicker";
            this.timestampDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.timestampDateTimePicker.TabIndex = 27;
            // 
            // uVIndexSpinEdit
            // 
            this.uVIndexSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.weatherBindingSource, "UVIndex", true));
            this.uVIndexSpinEdit.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uVIndexSpinEdit.Location = new System.Drawing.Point(682, 602);
            this.uVIndexSpinEdit.Name = "uVIndexSpinEdit";
            this.uVIndexSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uVIndexSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.uVIndexSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.uVIndexSpinEdit.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uVIndexSpinEdit.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uVIndexSpinEdit.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.uVIndexSpinEdit.Size = new System.Drawing.Size(200, 28);
            this.uVIndexSpinEdit.TabIndex = 29;
            // 
            // windKPHSpinEdit
            // 
            this.windKPHSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.weatherBindingSource, "WindKPH", true));
            this.windKPHSpinEdit.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.windKPHSpinEdit.Location = new System.Drawing.Point(264, 653);
            this.windKPHSpinEdit.Name = "windKPHSpinEdit";
            this.windKPHSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windKPHSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.windKPHSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.windKPHSpinEdit.Size = new System.Drawing.Size(200, 28);
            this.windKPHSpinEdit.TabIndex = 31;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAddEntry.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddEntry.Appearance.Options.UseBackColor = true;
            this.btnAddEntry.Appearance.Options.UseBorderColor = true;
            this.btnAddEntry.AppearanceHovered.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddEntry.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAddEntry.AppearanceHovered.Options.UseBackColor = true;
            this.btnAddEntry.AppearanceHovered.Options.UseForeColor = true;
            this.btnAddEntry.Location = new System.Drawing.Point(493, 649);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(389, 36);
            this.btnAddEntry.TabIndex = 32;
            this.btnAddEntry.Text = "Add to Selected City";
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // EntryAddRemove
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(cloudLabel);
            this.Controls.Add(this.cloudTextEdit);
            this.Controls.Add(conditionLabel);
            this.Controls.Add(this.conditionTextEdit);
            this.Controls.Add(humidityLabel);
            this.Controls.Add(this.humidityNumericUpDown);
            this.Controls.Add(precipitationLabel);
            this.Controls.Add(this.precipitationSpinEdit);
            this.Controls.Add(rainChanceLabel);
            this.Controls.Add(this.rainChanceNumericUpDown);
            this.Controls.Add(temperatureLabel);
            this.Controls.Add(this.temperatureSpinEdit);
            this.Controls.Add(timestampLabel);
            this.Controls.Add(this.timestampDateTimePicker);
            this.Controls.Add(uVIndexLabel);
            this.Controls.Add(this.uVIndexSpinEdit);
            this.Controls.Add(windKPHLabel);
            this.Controls.Add(this.windKPHSpinEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.viewer);
            this.Name = "EntryAddRemove";
            this.Size = new System.Drawing.Size(1285, 721);
            this.Load += new System.EventHandler(this.EntryAddRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precipitationSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainChanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uVIndexSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windKPHSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView viewer;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private System.Windows.Forms.BindingSource weatherBindingSource;
        private System.Windows.Forms.NumericUpDown cloudTextEdit;
        private DevExpress.XtraEditors.TextEdit conditionTextEdit;
        private System.Windows.Forms.NumericUpDown humidityNumericUpDown;
        private DevExpress.XtraEditors.SpinEdit precipitationSpinEdit;
        private System.Windows.Forms.NumericUpDown rainChanceNumericUpDown;
        private DevExpress.XtraEditors.SpinEdit temperatureSpinEdit;
        private System.Windows.Forms.DateTimePicker timestampDateTimePicker;
        private DevExpress.XtraEditors.SpinEdit uVIndexSpinEdit;
        private DevExpress.XtraEditors.SpinEdit windKPHSpinEdit;
        private DevExpress.XtraEditors.SimpleButton btnAddEntry;
    }
}
