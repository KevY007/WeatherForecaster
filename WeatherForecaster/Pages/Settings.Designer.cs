namespace WeatherForecaster.Pages
{
    partial class Settings
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.centigradeSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.weatherAPIKey = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnFetch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.centigradeSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherAPIKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Rockwell", 42F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.LineColor = System.Drawing.Color.White;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(458, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(307, 98);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Settings";
            // 
            // centigradeSwitch
            // 
            this.centigradeSwitch.EditValue = true;
            this.centigradeSwitch.Location = new System.Drawing.Point(764, 239);
            this.centigradeSwitch.Name = "centigradeSwitch";
            this.centigradeSwitch.Properties.Appearance.Font = new System.Drawing.Font("Rockwell", 8F);
            this.centigradeSwitch.Properties.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.centigradeSwitch.Properties.Appearance.Options.UseFont = true;
            this.centigradeSwitch.Properties.Appearance.Options.UseForeColor = true;
            this.centigradeSwitch.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.centigradeSwitch.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.centigradeSwitch.Properties.OffText = "Fahrenheit";
            this.centigradeSwitch.Properties.OnText = "Celcius";
            this.centigradeSwitch.Properties.ShowText = false;
            this.centigradeSwitch.Size = new System.Drawing.Size(74, 27);
            this.centigradeSwitch.TabIndex = 1;
            this.centigradeSwitch.Toggled += new System.EventHandler(this.centigradeSwitch_Toggled);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(378, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Display as Centigrade";
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl1.LineColor = System.Drawing.Color.Gray;
            this.separatorControl1.Location = new System.Drawing.Point(374, 270);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(462, 26);
            this.separatorControl1.TabIndex = 3;
            // 
            // weatherAPIKey
            // 
            this.weatherAPIKey.Location = new System.Drawing.Point(677, 302);
            this.weatherAPIKey.Name = "weatherAPIKey";
            this.weatherAPIKey.Size = new System.Drawing.Size(149, 26);
            this.weatherAPIKey.TabIndex = 4;
            this.weatherAPIKey.EditValueChanged += new System.EventHandler(this.weatherAPIKey_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(378, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "WeatherAPI Key";
            // 
            // separatorControl2
            // 
            this.separatorControl2.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl2.LineColor = System.Drawing.Color.Gray;
            this.separatorControl2.Location = new System.Drawing.Point(374, 334);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(462, 26);
            this.separatorControl2.TabIndex = 6;
            // 
            // btnFetch
            // 
            this.btnFetch.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnFetch.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnFetch.Appearance.Options.UseBackColor = true;
            this.btnFetch.Appearance.Options.UseBorderColor = true;
            this.btnFetch.AppearanceHovered.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFetch.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnFetch.AppearanceHovered.Options.UseBackColor = true;
            this.btnFetch.AppearanceHovered.Options.UseForeColor = true;
            this.btnFetch.Location = new System.Drawing.Point(839, 304);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(87, 23);
            this.btnFetch.TabIndex = 7;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // Settings
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weatherAPIKey);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.centigradeSwitch);
            this.Controls.Add(this.labelControl1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1285, 721);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.centigradeSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherAPIKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch centigradeSwitch;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit weatherAPIKey;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SimpleButton btnFetch;
    }
}
