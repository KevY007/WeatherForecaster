namespace WeatherForecaster.Pages
{
    partial class ViewAndManage
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
            this.viewer = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
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
            this.viewer.Location = new System.Drawing.Point(117, 25);
            this.viewer.Name = "viewer";
            this.viewer.ShowNodeToolTips = true;
            this.viewer.Size = new System.Drawing.Size(1015, 382);
            this.viewer.TabIndex = 0;
            // 
            // ViewAndManage
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewer);
            this.Name = "ViewAndManage";
            this.Size = new System.Drawing.Size(1294, 726);
            this.Load += new System.EventHandler(this.ViewAndManage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView viewer;
    }
}
