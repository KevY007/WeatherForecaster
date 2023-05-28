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
            this.listClass = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listMember = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listSubMember = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listClass
            // 
            this.listClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listClass.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listClass.FormattingEnabled = true;
            this.listClass.ItemHeight = 19;
            this.listClass.Location = new System.Drawing.Point(87, 83);
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(343, 344);
            this.listClass.TabIndex = 12;
            this.listClass.SelectedIndexChanged += new System.EventHandler(this.listClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class:";
            // 
            // listMember
            // 
            this.listMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMember.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listMember.FormattingEnabled = true;
            this.listMember.HorizontalScrollbar = true;
            this.listMember.ItemHeight = 19;
            this.listMember.Location = new System.Drawing.Point(469, 83);
            this.listMember.Name = "listMember";
            this.listMember.Size = new System.Drawing.Size(414, 344);
            this.listMember.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Member:";
            // 
            // listSubMember
            // 
            this.listSubMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listSubMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSubMember.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listSubMember.FormattingEnabled = true;
            this.listSubMember.ItemHeight = 19;
            this.listSubMember.Location = new System.Drawing.Point(922, 83);
            this.listSubMember.Name = "listSubMember";
            this.listSubMember.Size = new System.Drawing.Size(343, 344);
            this.listSubMember.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(999, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sub-Member:";
            // 
            // Analytics
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listSubMember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listClass);
            this.Controls.Add(this.label1);
            this.Name = "Analytics";
            this.Size = new System.Drawing.Size(1294, 726);
            this.Load += new System.EventHandler(this.Analytics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listSubMember;
        private System.Windows.Forms.Label label3;
    }
}
