namespace WeatherForecaster.Pages
{
    partial class LocationAddRemove
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
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblParents = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.listAddParents = new System.Windows.Forms.ListBox();
            this.listRemoveItem = new System.Windows.Forms.ListBox();
            this.lblRemove = new System.Windows.Forms.Label();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(502, 168);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(270, 27);
            this.cmbItemType.TabIndex = 0;
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbLocationType_SelectedIndexChanged);
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.BackColor = System.Drawing.Color.Transparent;
            this.lblItemType.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lblItemType.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblItemType.Location = new System.Drawing.Point(495, 71);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(277, 41);
            this.lblItemType.TabIndex = 1;
            this.lblItemType.Text = "Select the type:";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.BackColor = System.Drawing.Color.Transparent;
            this.lblAddName.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblAddName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAddName.Location = new System.Drawing.Point(126, 353);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(97, 31);
            this.lblAddName.TabIndex = 2;
            this.lblAddName.Text = "Name:";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(254, 359);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(178, 27);
            this.txtAddName.TabIndex = 3;
            // 
            // lblParents
            // 
            this.lblParents.AutoSize = true;
            this.lblParents.BackColor = System.Drawing.Color.Transparent;
            this.lblParents.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblParents.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblParents.Location = new System.Drawing.Point(126, 413);
            this.lblParents.Name = "lblParents";
            this.lblParents.Size = new System.Drawing.Size(105, 31);
            this.lblParents.TabIndex = 5;
            this.lblParents.Text = "Parent:";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAdd.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseBorderColor = true;
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.Options.UseForeColor = true;
            this.btnAdd.Location = new System.Drawing.Point(148, 551);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(284, 44);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listAddParents
            // 
            this.listAddParents.FormattingEnabled = true;
            this.listAddParents.ItemHeight = 19;
            this.listAddParents.Location = new System.Drawing.Point(254, 413);
            this.listAddParents.Name = "listAddParents";
            this.listAddParents.Size = new System.Drawing.Size(178, 118);
            this.listAddParents.TabIndex = 9;
            // 
            // listRemoveItem
            // 
            this.listRemoveItem.FormattingEnabled = true;
            this.listRemoveItem.ItemHeight = 19;
            this.listRemoveItem.Location = new System.Drawing.Point(974, 359);
            this.listRemoveItem.Name = "listRemoveItem";
            this.listRemoveItem.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRemoveItem.Size = new System.Drawing.Size(285, 175);
            this.listRemoveItem.TabIndex = 11;
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.BackColor = System.Drawing.Color.Transparent;
            this.lblRemove.Font = new System.Drawing.Font("Rockwell", 14F);
            this.lblRemove.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRemove.Location = new System.Drawing.Point(838, 353);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(126, 31);
            this.lblRemove.TabIndex = 10;
            this.lblRemove.Text = "Remove:";
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
            this.btnRemove.Location = new System.Drawing.Point(974, 551);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(284, 44);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // LocationAddRemove
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listRemoveItem);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.listAddParents);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblParents);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.cmbItemType);
            this.Name = "LocationAddRemove";
            this.Size = new System.Drawing.Size(1285, 721);
            this.Load += new System.EventHandler(this.LocationAddRemove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label lblParents;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.ListBox listAddParents;
        private System.Windows.Forms.ListBox listRemoveItem;
        private System.Windows.Forms.Label lblRemove;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
    }
}
