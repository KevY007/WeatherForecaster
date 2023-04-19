namespace WeatherForecaster
{
    partial class formMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.mainMenu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btnHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btnGroupAccount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnLoginSignup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnAccountSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnGroupLocations = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSelectLocation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnAddLocation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnRemoveLocation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormManager = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Office2016;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnHome,
            this.accordionControlSeparator1,
            this.btnGroupAccount,
            this.btnGroupLocations});
            this.mainMenu.Location = new System.Drawing.Point(0, 46);
            this.mainMenu.LookAndFeel.SkinName = "Office 2019 Black";
            this.mainMenu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.mainMenu.Size = new System.Drawing.Size(375, 720);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btnHome
            // 
            this.btnHome.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnHome.Appearance.Default.Options.UseFont = true;
            this.btnHome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHome.ImageOptions.SvgImage")));
            this.btnHome.Name = "btnHome";
            this.btnHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // btnGroupAccount
            // 
            this.btnGroupAccount.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnLoginSignup,
            this.btnAccountSettings});
            this.btnGroupAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGroupAccount.ImageOptions.SvgImage")));
            this.btnGroupAccount.Name = "btnGroupAccount";
            this.btnGroupAccount.Text = "Account";
            // 
            // btnLoginSignup
            // 
            this.btnLoginSignup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoginSignup.ImageOptions.SvgImage")));
            this.btnLoginSignup.Name = "btnLoginSignup";
            this.btnLoginSignup.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnLoginSignup.Text = "Login / Signup";
            this.btnLoginSignup.Click += new System.EventHandler(this.btnLoginSignup_Click);
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAccountSettings.ImageOptions.SvgImage")));
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAccountSettings.Text = "Settings";
            this.btnAccountSettings.Click += new System.EventHandler(this.btnAccountSettings_Click);
            // 
            // btnGroupLocations
            // 
            this.btnGroupLocations.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnSelectLocation,
            this.btnAddLocation,
            this.btnRemoveLocation});
            this.btnGroupLocations.Expanded = true;
            this.btnGroupLocations.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGroupLocations.ImageOptions.SvgImage")));
            this.btnGroupLocations.Name = "btnGroupLocations";
            this.btnGroupLocations.Text = "Locations";
            // 
            // btnSelectLocation
            // 
            this.btnSelectLocation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSelectLocation.ImageOptions.SvgImage")));
            this.btnSelectLocation.Name = "btnSelectLocation";
            this.btnSelectLocation.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSelectLocation.Text = "Select Location";
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddLocation.ImageOptions.SvgImage")));
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAddLocation.Text = "Add Location";
            // 
            // btnRemoveLocation
            // 
            this.btnRemoveLocation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemoveLocation.ImageOptions.SvgImage")));
            this.btnRemoveLocation.Name = "btnRemoveLocation";
            this.btnRemoveLocation.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRemoveLocation.Text = "Remove Location";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormManager;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1283, 46);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormManager
            // 
            this.fluentFormManager.Form = this;
            this.fluentFormManager.MaxItemId = 1;
            // 
            // formMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 766);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("formMain.IconOptions.SvgImage")));
            this.Name = "formMain";
            this.NavigationControl = this.mainMenu;
            this.Text = "WeatherForecaster";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraBars.Navigation.AccordionControl mainMenu;

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormManager;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btnHome;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btnLoginSignup;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btnSelectLocation;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btnGroupAccount;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btnGroupLocations;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btnAddLocation;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btnRemoveLocation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAccountSettings;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
    }
}

