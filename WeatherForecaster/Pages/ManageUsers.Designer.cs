using System.Windows.Forms;

namespace WeatherForecaster.Pages
{
    partial class ManageUsers
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
            this.listUsers = new DevExpress.XtraEditors.ListBoxControl();
            this.lblUser = new System.Windows.Forms.Label();
            this.roundedPanel1 = new WeatherForecaster.Controls.RoundedPanel();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.dispEntries = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateUser = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.dispId = new System.Windows.Forms.Label();
            this.dispEmail = new System.Windows.Forms.Label();
            this.dispPriv = new System.Windows.Forms.ComboBox();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lblPriv = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnViewLogs = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listUsers)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.listUsers.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUsers.Appearance.ForeColor = System.Drawing.Color.White;
            this.listUsers.Appearance.Options.UseBackColor = true;
            this.listUsers.Appearance.Options.UseFont = true;
            this.listUsers.Appearance.Options.UseForeColor = true;
            this.listUsers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.listUsers.Location = new System.Drawing.Point(417, 124);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(466, 182);
            this.listUsers.TabIndex = 0;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Yu Gothic UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUser.Location = new System.Drawing.Point(491, 42);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(292, 60);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Manage User:";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.Controls.Add(this.btnViewLogs);
            this.roundedPanel1.Controls.Add(this.separatorControl4);
            this.roundedPanel1.Controls.Add(this.dispEntries);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.btnUpdateUser);
            this.roundedPanel1.Controls.Add(this.separatorControl3);
            this.roundedPanel1.Controls.Add(this.separatorControl2);
            this.roundedPanel1.Controls.Add(this.separatorControl1);
            this.roundedPanel1.Controls.Add(this.dispId);
            this.roundedPanel1.Controls.Add(this.dispEmail);
            this.roundedPanel1.Controls.Add(this.dispPriv);
            this.roundedPanel1.Controls.Add(this.btnDelete);
            this.roundedPanel1.Controls.Add(this.lblPriv);
            this.roundedPanel1.Controls.Add(this.lblEmail);
            this.roundedPanel1.Controls.Add(this.lblId);
            this.roundedPanel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.roundedPanel1.Location = new System.Drawing.Point(329, 324);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(641, 376);
            this.roundedPanel1.TabIndex = 2;
            this.roundedPanel1.Thickness = 10F;
            // 
            // separatorControl4
            // 
            this.separatorControl4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.separatorControl4.Location = new System.Drawing.Point(-4, 197);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Size = new System.Drawing.Size(651, 33);
            this.separatorControl4.TabIndex = 18;
            // 
            // dispEntries
            // 
            this.dispEntries.AutoSize = true;
            this.dispEntries.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dispEntries.Location = new System.Drawing.Point(197, 165);
            this.dispEntries.Name = "dispEntries";
            this.dispEntries.Size = new System.Drawing.Size(22, 29);
            this.dispEntries.TabIndex = 17;
            this.dispEntries.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(47, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Entries:";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnUpdateUser.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.Appearance.Options.UseBackColor = true;
            this.btnUpdateUser.Appearance.Options.UseBorderColor = true;
            this.btnUpdateUser.AppearanceHovered.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateUser.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnUpdateUser.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdateUser.AppearanceHovered.Options.UseForeColor = true;
            this.btnUpdateUser.Location = new System.Drawing.Point(247, 313);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(169, 48);
            this.btnUpdateUser.TabIndex = 15;
            this.btnUpdateUser.Text = "Update Privileges";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // separatorControl3
            // 
            this.separatorControl3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.separatorControl3.Location = new System.Drawing.Point(-5, 276);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(651, 33);
            this.separatorControl3.TabIndex = 14;
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.separatorControl2.Location = new System.Drawing.Point(-4, 120);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(651, 33);
            this.separatorControl2.TabIndex = 13;
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.separatorControl1.Location = new System.Drawing.Point(-5, 40);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(651, 33);
            this.separatorControl1.TabIndex = 12;
            // 
            // dispId
            // 
            this.dispId.AutoSize = true;
            this.dispId.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dispId.Location = new System.Drawing.Point(197, 12);
            this.dispId.Name = "dispId";
            this.dispId.Size = new System.Drawing.Size(22, 29);
            this.dispId.TabIndex = 11;
            this.dispId.Text = "-";
            // 
            // dispEmail
            // 
            this.dispEmail.AutoSize = true;
            this.dispEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dispEmail.Location = new System.Drawing.Point(197, 88);
            this.dispEmail.Name = "dispEmail";
            this.dispEmail.Size = new System.Drawing.Size(22, 29);
            this.dispEmail.TabIndex = 10;
            this.dispEmail.Text = "-";
            // 
            // dispPriv
            // 
            this.dispPriv.FormattingEnabled = true;
            this.dispPriv.Location = new System.Drawing.Point(202, 249);
            this.dispPriv.Name = "dispPriv";
            this.dispPriv.Size = new System.Drawing.Size(239, 27);
            this.dispPriv.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.AppearanceHovered.Options.UseForeColor = true;
            this.btnDelete.Location = new System.Drawing.Point(47, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 48);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPriv
            // 
            this.lblPriv.AutoSize = true;
            this.lblPriv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriv.ForeColor = System.Drawing.Color.Gold;
            this.lblPriv.Location = new System.Drawing.Point(47, 246);
            this.lblPriv.Name = "lblPriv";
            this.lblPriv.Size = new System.Drawing.Size(120, 29);
            this.lblPriv.TabIndex = 2;
            this.lblPriv.Text = "Privileges:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gold;
            this.lblEmail.Location = new System.Drawing.Point(47, 88);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 29);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Gold;
            this.lblId.Location = new System.Drawing.Point(47, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(46, 29);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnViewLogs.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnViewLogs.Appearance.Options.UseBackColor = true;
            this.btnViewLogs.Appearance.Options.UseBorderColor = true;
            this.btnViewLogs.AppearanceHovered.BackColor = System.Drawing.Color.Gainsboro;
            this.btnViewLogs.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnViewLogs.AppearanceHovered.Options.UseBackColor = true;
            this.btnViewLogs.AppearanceHovered.Options.UseForeColor = true;
            this.btnViewLogs.Location = new System.Drawing.Point(445, 313);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(169, 48);
            this.btnViewLogs.TabIndex = 19;
            this.btnViewLogs.Text = "View Activity Log";
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // ManageUsers
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.listUsers);
            this.Name = "ManageUsers";
            this.Size = new System.Drawing.Size(1285, 721);
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listUsers)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listUsers;
        private Label lblUser;
        private Controls.RoundedPanel roundedPanel1;
        private Label lblPriv;
        private Label lblEmail;
        private Label lblId;
        private Label dispId;
        private Label dispEmail;
        private ComboBox dispPriv;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btnUpdateUser;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private Label dispEntries;
        private Label label2;
        private DevExpress.XtraEditors.SimpleButton btnViewLogs;
    }
}
