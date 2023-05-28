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
            this.components = new System.ComponentModel.Container();
            this.weatherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // weatherBindingSource
            // 
            this.weatherBindingSource.DataSource = typeof(WeatherForecaster.Weather);
            // 
            // Analytics
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Analytics";
            this.Size = new System.Drawing.Size(1294, 726);
            this.Load += new System.EventHandler(this.Analytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource weatherBindingSource;
    }
}
