using DevExpress.Utils.Extensions;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace WeatherForecaster.Pages
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lblWeather = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.lblLowHighSep = new System.Windows.Forms.Label();
            this.panelMiscInfo = new WeatherForecaster.Controls.RoundedPanel();
            this.lblHr3Rain = new System.Windows.Forms.Label();
            this.svgHr3Rain = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr3Wind = new System.Windows.Forms.Label();
            this.svgHr3Wind = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr3Temp = new System.Windows.Forms.Label();
            this.svgHr3 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr3 = new System.Windows.Forms.Label();
            this.lblHr2Rain = new System.Windows.Forms.Label();
            this.svgHr2Rain = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr2Wind = new System.Windows.Forms.Label();
            this.svgHr2Wind = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr2Temp = new System.Windows.Forms.Label();
            this.svgHr2 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr2 = new System.Windows.Forms.Label();
            this.lblHr1Rain = new System.Windows.Forms.Label();
            this.svgHr1Rain = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr1Wind = new System.Windows.Forms.Label();
            this.svgHr1Wind = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr1Temp = new System.Windows.Forms.Label();
            this.svgHr1 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.panelMiscInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr3Rain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr3Wind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr2Rain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr2Wind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr1Rain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr1Wind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(467, 26);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(336, 80);
            this.lblLocationName.TabIndex = 0;
            this.lblLocationName.Text = "Katowice";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Gray;
            this.lblDay.Location = new System.Drawing.Point(575, 122);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(106, 36);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "Today";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTemperature.Location = new System.Drawing.Point(544, 181);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(175, 80);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "2 °C";
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.separatorControl1.Location = new System.Drawing.Point(481, 254);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(322, 19);
            this.separatorControl1.TabIndex = 3;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.ForeColor = System.Drawing.Color.Gray;
            this.lblWeather.Location = new System.Drawing.Point(575, 278);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(104, 36);
            this.lblWeather.TabIndex = 4;
            this.lblWeather.Text = "Sunny";
            // 
            // lblLowest
            // 
            this.lblLowest.AutoSize = true;
            this.lblLowest.BackColor = System.Drawing.Color.Transparent;
            this.lblLowest.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(134)))), ((int)(((byte)(202)))));
            this.lblLowest.Location = new System.Drawing.Point(539, 323);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(88, 36);
            this.lblLowest.TabIndex = 5;
            this.lblLowest.Text = "-5 °C";
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.BackColor = System.Drawing.Color.Transparent;
            this.lblHighest.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.lblHighest.Location = new System.Drawing.Point(642, 323);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(77, 36);
            this.lblHighest.TabIndex = 6;
            this.lblHighest.Text = "2 °C";
            // 
            // lblLowHighSep
            // 
            this.lblLowHighSep.AutoSize = true;
            this.lblLowHighSep.BackColor = System.Drawing.Color.Transparent;
            this.lblLowHighSep.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowHighSep.ForeColor = System.Drawing.Color.Gray;
            this.lblLowHighSep.Location = new System.Drawing.Point(619, 323);
            this.lblLowHighSep.Name = "lblLowHighSep";
            this.lblLowHighSep.Size = new System.Drawing.Size(29, 36);
            this.lblLowHighSep.TabIndex = 7;
            this.lblLowHighSep.Text = "/";
            // 
            // panelMiscInfo
            // 
            this.panelMiscInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelMiscInfo.BorderColor = System.Drawing.Color.Transparent;
            this.panelMiscInfo.Controls.Add(this.lblHr3Rain);
            this.panelMiscInfo.Controls.Add(this.svgHr3Rain);
            this.panelMiscInfo.Controls.Add(this.lblHr3Wind);
            this.panelMiscInfo.Controls.Add(this.svgHr3Wind);
            this.panelMiscInfo.Controls.Add(this.lblHr3Temp);
            this.panelMiscInfo.Controls.Add(this.svgHr3);
            this.panelMiscInfo.Controls.Add(this.lblHr3);
            this.panelMiscInfo.Controls.Add(this.lblHr2Rain);
            this.panelMiscInfo.Controls.Add(this.svgHr2Rain);
            this.panelMiscInfo.Controls.Add(this.lblHr2Wind);
            this.panelMiscInfo.Controls.Add(this.svgHr2Wind);
            this.panelMiscInfo.Controls.Add(this.lblHr2Temp);
            this.panelMiscInfo.Controls.Add(this.svgHr2);
            this.panelMiscInfo.Controls.Add(this.lblHr2);
            this.panelMiscInfo.Controls.Add(this.lblHr1Rain);
            this.panelMiscInfo.Controls.Add(this.svgHr1Rain);
            this.panelMiscInfo.Controls.Add(this.lblHr1Wind);
            this.panelMiscInfo.Controls.Add(this.svgHr1Wind);
            this.panelMiscInfo.Controls.Add(this.lblHr1Temp);
            this.panelMiscInfo.Controls.Add(this.svgHr1);
            this.panelMiscInfo.Controls.Add(this.lblHr1);
            this.panelMiscInfo.Location = new System.Drawing.Point(333, 373);
            this.panelMiscInfo.Name = "panelMiscInfo";
            this.panelMiscInfo.Radius = 10;
            this.panelMiscInfo.Size = new System.Drawing.Size(602, 330);
            this.panelMiscInfo.TabIndex = 8;
            this.panelMiscInfo.Thickness = 500F;
            // 
            // lblHr3Rain
            // 
            this.lblHr3Rain.AutoSize = true;
            this.lblHr3Rain.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr3Rain.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr3Rain.Location = new System.Drawing.Point(509, 296);
            this.lblHr3Rain.Name = "lblHr3Rain";
            this.lblHr3Rain.Size = new System.Drawing.Size(52, 24);
            this.lblHr3Rain.TabIndex = 20;
            this.lblHr3Rain.Text = "50%";
            // 
            // svgHr3Rain
            // 
            this.svgHr3Rain.Location = new System.Drawing.Point(507, 251);
            this.svgHr3Rain.Name = "svgHr3Rain";
            this.svgHr3Rain.Size = new System.Drawing.Size(50, 42);
            this.svgHr3Rain.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgHr3Rain.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgHr3Rain.SvgImage")));
            this.svgHr3Rain.TabIndex = 19;
            this.svgHr3Rain.Text = "svgHr3Rain";
            // 
            // lblHr3Wind
            // 
            this.lblHr3Wind.AutoSize = true;
            this.lblHr3Wind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr3Wind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr3Wind.Location = new System.Drawing.Point(499, 205);
            this.lblHr3Wind.Name = "lblHr3Wind";
            this.lblHr3Wind.Size = new System.Drawing.Size(70, 22);
            this.lblHr3Wind.TabIndex = 18;
            this.lblHr3Wind.Text = "3 KM/H";
            // 
            // svgHr3Wind
            // 
            this.svgHr3Wind.Location = new System.Drawing.Point(507, 160);
            this.svgHr3Wind.Name = "svgHr3Wind";
            this.svgHr3Wind.Size = new System.Drawing.Size(50, 42);
            this.svgHr3Wind.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgHr3Wind.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgHr3Wind.SvgImage")));
            this.svgHr3Wind.TabIndex = 17;
            this.svgHr3Wind.Text = "svgHr3Wind";
            // 
            // lblHr3Temp
            // 
            this.lblHr3Temp.AutoSize = true;
            this.lblHr3Temp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr3Temp.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr3Temp.Location = new System.Drawing.Point(512, 115);
            this.lblHr3Temp.Name = "lblHr3Temp";
            this.lblHr3Temp.Size = new System.Drawing.Size(42, 24);
            this.lblHr3Temp.TabIndex = 16;
            this.lblHr3Temp.Text = "2°C";
            // 
            // svgHr3
            // 
            this.svgHr3.Location = new System.Drawing.Point(507, 67);
            this.svgHr3.Name = "svgHr3";
            this.svgHr3.Size = new System.Drawing.Size(50, 42);
            this.svgHr3.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgHr3.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgHr3.SvgImage")));
            this.svgHr3.TabIndex = 15;
            this.svgHr3.Text = "svgHr3";
            // 
            // lblHr3
            // 
            this.lblHr3.AutoSize = true;
            this.lblHr3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr3.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr3.Location = new System.Drawing.Point(499, 14);
            this.lblHr3.Name = "lblHr3";
            this.lblHr3.Size = new System.Drawing.Size(73, 29);
            this.lblHr3.TabIndex = 14;
            this.lblHr3.Text = "14:00";
            // 
            // lblHr2Rain
            // 
            this.lblHr2Rain.AutoSize = true;
            this.lblHr2Rain.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr2Rain.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr2Rain.Location = new System.Drawing.Point(263, 296);
            this.lblHr2Rain.Name = "lblHr2Rain";
            this.lblHr2Rain.Size = new System.Drawing.Size(52, 24);
            this.lblHr2Rain.TabIndex = 13;
            this.lblHr2Rain.Text = "50%";
            // 
            // svgHr2Rain
            // 
            this.svgHr2Rain.Location = new System.Drawing.Point(261, 251);
            this.svgHr2Rain.Name = "svgHr2Rain";
            this.svgHr2Rain.Size = new System.Drawing.Size(50, 42);
            this.svgHr2Rain.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgHr2Rain.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgHr2Rain.SvgImage")));
            this.svgHr2Rain.TabIndex = 12;
            this.svgHr2Rain.Text = "svgHr2Rain";
            // 
            // lblHr2Wind
            // 
            this.lblHr2Wind.AutoSize = true;
            this.lblHr2Wind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr2Wind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr2Wind.Location = new System.Drawing.Point(253, 205);
            this.lblHr2Wind.Name = "lblHr2Wind";
            this.lblHr2Wind.Size = new System.Drawing.Size(70, 22);
            this.lblHr2Wind.TabIndex = 11;
            this.lblHr2Wind.Text = "3 KM/H";
            // 
            // svgHr2Wind
            // 
            this.svgHr2Wind.Location = new System.Drawing.Point(261, 160);
            this.svgHr2Wind.Name = "svgHr2Wind";
            this.svgHr2Wind.Size = new System.Drawing.Size(50, 42);
            this.svgHr2Wind.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgHr2Wind.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgHr2Wind.SvgImage")));
            this.svgHr2Wind.TabIndex = 10;
            this.svgHr2Wind.Text = "svgHr2Wind";
            // 
            // lblHr2Temp
            // 
            this.lblHr2Temp.AutoSize = true;
            this.lblHr2Temp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr2Temp.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr2Temp.Location = new System.Drawing.Point(266, 115);
            this.lblHr2Temp.Name = "lblHr2Temp";
            this.lblHr2Temp.Size = new System.Drawing.Size(42, 24);
            this.lblHr2Temp.TabIndex = 9;
            this.lblHr2Temp.Text = "2°C";
            // 
            // svgHr2
            // 
            this.svgHr2.Location = new System.Drawing.Point(261, 67);
            this.svgHr2.Name = "svgHr2";
            this.svgHr2.Size = new System.Drawing.Size(50, 42);
            this.svgHr2.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgHr2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgHr2.SvgImage")));
            this.svgHr2.TabIndex = 8;
            this.svgHr2.Text = "svgHr2";
            // 
            // lblHr2
            // 
            this.lblHr2.AutoSize = true;
            this.lblHr2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr2.Location = new System.Drawing.Point(253, 14);
            this.lblHr2.Name = "lblHr2";
            this.lblHr2.Size = new System.Drawing.Size(73, 29);
            this.lblHr2.TabIndex = 7;
            this.lblHr2.Text = "13:00";
            // 
            // lblHr1Rain
            // 
            this.lblHr1Rain.AutoSize = true;
            this.lblHr1Rain.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr1Rain.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr1Rain.Location = new System.Drawing.Point(35, 296);
            this.lblHr1Rain.Name = "lblHr1Rain";
            this.lblHr1Rain.Size = new System.Drawing.Size(52, 24);
            this.lblHr1Rain.TabIndex = 6;
            this.lblHr1Rain.Text = "50%";
            // 
            // svgHr1Rain
            // 
            this.svgHr1Rain.Location = new System.Drawing.Point(33, 251);
            this.svgHr1Rain.Name = "svgHr1Rain";
            this.svgHr1Rain.Size = new System.Drawing.Size(50, 42);
            this.svgHr1Rain.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgHr1Rain.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgHr1Rain.SvgImage")));
            this.svgHr1Rain.TabIndex = 5;
            this.svgHr1Rain.Text = "svgHr1Rain";
            // 
            // lblHr1Wind
            // 
            this.lblHr1Wind.AutoSize = true;
            this.lblHr1Wind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr1Wind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr1Wind.Location = new System.Drawing.Point(25, 205);
            this.lblHr1Wind.Name = "lblHr1Wind";
            this.lblHr1Wind.Size = new System.Drawing.Size(70, 22);
            this.lblHr1Wind.TabIndex = 4;
            this.lblHr1Wind.Text = "3 KM/H";
            // 
            // svgHr1Wind
            // 
            this.svgHr1Wind.Location = new System.Drawing.Point(33, 160);
            this.svgHr1Wind.Name = "svgHr1Wind";
            this.svgHr1Wind.Size = new System.Drawing.Size(50, 42);
            this.svgHr1Wind.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgHr1Wind.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgHr1Wind.SvgImage")));
            this.svgHr1Wind.TabIndex = 3;
            this.svgHr1Wind.Text = "svgHr1Wind";
            // 
            // lblHr1Temp
            // 
            this.lblHr1Temp.AutoSize = true;
            this.lblHr1Temp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr1Temp.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr1Temp.Location = new System.Drawing.Point(38, 115);
            this.lblHr1Temp.Name = "lblHr1Temp";
            this.lblHr1Temp.Size = new System.Drawing.Size(42, 24);
            this.lblHr1Temp.TabIndex = 2;
            this.lblHr1Temp.Text = "2°C";
            // 
            // svgHr1
            // 
            this.svgHr1.Location = new System.Drawing.Point(33, 67);
            this.svgHr1.Name = "svgHr1";
            this.svgHr1.Size = new System.Drawing.Size(50, 42);
            this.svgHr1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgHr1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgHr1.SvgImage")));
            this.svgHr1.TabIndex = 1;
            this.svgHr1.Text = "svgHr1";
            // 
            // lblHr1
            // 
            this.lblHr1.AutoSize = true;
            this.lblHr1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr1.Location = new System.Drawing.Point(28, 14);
            this.lblHr1.Name = "lblHr1";
            this.lblHr1.Size = new System.Drawing.Size(60, 29);
            this.lblHr1.TabIndex = 0;
            this.lblHr1.Text = "Now";
            // 
            // Home
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMiscInfo);
            this.Controls.Add(this.lblLowHighSep);
            this.Controls.Add(this.lblHighest);
            this.Controls.Add(this.lblLowest);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblLocationName);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1285, 721);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panelMiscInfo.ResumeLayout(false);
            this.panelMiscInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr3Rain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr3Wind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr2Rain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr2Wind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr1Rain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr1Wind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTemperature;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Label lblLowHighSep;
        private Controls.RoundedPanel panelMiscInfo;
        private Label lblHr3Rain;
        private DevExpress.XtraEditors.SvgImageBox svgHr3Rain;
        private Label lblHr3Wind;
        private DevExpress.XtraEditors.SvgImageBox svgHr3Wind;
        private Label lblHr3Temp;
        private DevExpress.XtraEditors.SvgImageBox svgHr3;
        private Label lblHr3;
        private Label lblHr2Rain;
        private DevExpress.XtraEditors.SvgImageBox svgHr2Rain;
        private Label lblHr2Wind;
        private DevExpress.XtraEditors.SvgImageBox svgHr2Wind;
        private Label lblHr2Temp;
        private DevExpress.XtraEditors.SvgImageBox svgHr2;
        private Label lblHr2;
        private Label lblHr1Rain;
        private DevExpress.XtraEditors.SvgImageBox svgHr1Rain;
        private Label lblHr1Wind;
        private DevExpress.XtraEditors.SvgImageBox svgHr1Wind;
        private Label lblHr1Temp;
        private DevExpress.XtraEditors.SvgImageBox svgHr1;
        private Label lblHr1;
    }
}
