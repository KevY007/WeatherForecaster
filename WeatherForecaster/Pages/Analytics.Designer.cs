namespace WeatherForecaster.Pages
{
    partial class Analytics
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
            this.listContainer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listEntries = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listMember = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMap = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.swapAxes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listContainer
            // 
            this.listContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listContainer.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listContainer.FormattingEnabled = true;
            this.listContainer.ItemHeight = 19;
            this.listContainer.Location = new System.Drawing.Point(87, 83);
            this.listContainer.Name = "listContainer";
            this.listContainer.Size = new System.Drawing.Size(343, 344);
            this.listContainer.TabIndex = 12;
            this.listContainer.SelectedIndexChanged += new System.EventHandler(this.listClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Container:";
            // 
            // listEntries
            // 
            this.listEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listEntries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listEntries.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listEntries.FormattingEnabled = true;
            this.listEntries.HorizontalScrollbar = true;
            this.listEntries.ItemHeight = 19;
            this.listEntries.Location = new System.Drawing.Point(469, 83);
            this.listEntries.Name = "listEntries";
            this.listEntries.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listEntries.Size = new System.Drawing.Size(414, 344);
            this.listEntries.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Entries:";
            // 
            // listMember
            // 
            this.listMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMember.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listMember.FormattingEnabled = true;
            this.listMember.ItemHeight = 19;
            this.listMember.Location = new System.Drawing.Point(922, 83);
            this.listMember.Name = "listMember";
            this.listMember.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listMember.Size = new System.Drawing.Size(343, 344);
            this.listMember.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1011, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Member:";
            // 
            // btnMap
            // 
            this.btnMap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMap.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnMap.Appearance.Options.UseBackColor = true;
            this.btnMap.Appearance.Options.UseBorderColor = true;
            this.btnMap.AppearanceHovered.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMap.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnMap.AppearanceHovered.Options.UseBackColor = true;
            this.btnMap.AppearanceHovered.Options.UseForeColor = true;
            this.btnMap.Location = new System.Drawing.Point(469, 539);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(284, 44);
            this.btnMap.TabIndex = 17;
            this.btnMap.Text = "Map Selection";
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnReset
            // 
            this.btnReset.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReset.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnReset.Appearance.Options.UseBackColor = true;
            this.btnReset.Appearance.Options.UseBorderColor = true;
            this.btnReset.AppearanceHovered.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReset.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnReset.AppearanceHovered.Options.UseBackColor = true;
            this.btnReset.AppearanceHovered.Options.UseForeColor = true;
            this.btnReset.Location = new System.Drawing.Point(87, 539);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(343, 44);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset Chart";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // swapAxes
            // 
            this.swapAxes.AutoSize = true;
            this.swapAxes.Location = new System.Drawing.Point(785, 551);
            this.swapAxes.Name = "swapAxes";
            this.swapAxes.Size = new System.Drawing.Size(112, 23);
            this.swapAxes.TabIndex = 19;
            this.swapAxes.Text = "Swap Axes";
            this.swapAxes.UseVisualStyleBackColor = true;
            this.swapAxes.CheckedChanged += new System.EventHandler(this.swapAxis_CheckedChanged);
            // 
            // Analytics
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.swapAxes);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.listMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listEntries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listContainer);
            this.Controls.Add(this.label1);
            this.Name = "Analytics";
            this.Size = new System.Drawing.Size(1294, 726);
            this.Load += new System.EventHandler(this.Analytics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listEntries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listMember;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnMap;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private System.Windows.Forms.CheckBox swapAxes;
    }
}
