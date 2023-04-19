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
            this.lblHr1 = new System.Windows.Forms.Label();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr1Temp = new System.Windows.Forms.Label();
            this.lblHr1Wind = new System.Windows.Forms.Label();
            this.svgImageBox2 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr1Rain = new System.Windows.Forms.Label();
            this.svgImageBox3 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr2Rain = new System.Windows.Forms.Label();
            this.svgImageBox4 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr2Wind = new System.Windows.Forms.Label();
            this.svgImageBox5 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr2Temp = new System.Windows.Forms.Label();
            this.svgImageBox6 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr2 = new System.Windows.Forms.Label();
            this.lblHr3Rain = new System.Windows.Forms.Label();
            this.svgImageBox7 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr3Wind = new System.Windows.Forms.Label();
            this.svgImageBox8 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr3Temp = new System.Windows.Forms.Label();
            this.svgImageBox9 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.panelMiscInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox9)).BeginInit();
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
            this.panelMiscInfo.Controls.Add(this.svgImageBox7);
            this.panelMiscInfo.Controls.Add(this.lblHr3Wind);
            this.panelMiscInfo.Controls.Add(this.svgImageBox8);
            this.panelMiscInfo.Controls.Add(this.lblHr3Temp);
            this.panelMiscInfo.Controls.Add(this.svgImageBox9);
            this.panelMiscInfo.Controls.Add(this.lblHr3);
            this.panelMiscInfo.Controls.Add(this.lblHr2Rain);
            this.panelMiscInfo.Controls.Add(this.svgImageBox4);
            this.panelMiscInfo.Controls.Add(this.lblHr2Wind);
            this.panelMiscInfo.Controls.Add(this.svgImageBox5);
            this.panelMiscInfo.Controls.Add(this.lblHr2Temp);
            this.panelMiscInfo.Controls.Add(this.svgImageBox6);
            this.panelMiscInfo.Controls.Add(this.lblHr2);
            this.panelMiscInfo.Controls.Add(this.lblHr1Rain);
            this.panelMiscInfo.Controls.Add(this.svgImageBox3);
            this.panelMiscInfo.Controls.Add(this.lblHr1Wind);
            this.panelMiscInfo.Controls.Add(this.svgImageBox2);
            this.panelMiscInfo.Controls.Add(this.lblHr1Temp);
            this.panelMiscInfo.Controls.Add(this.svgImageBox1);
            this.panelMiscInfo.Controls.Add(this.lblHr1);
            this.panelMiscInfo.Location = new System.Drawing.Point(333, 373);
            this.panelMiscInfo.Name = "panelMiscInfo";
            this.panelMiscInfo.Radius = 10;
            this.panelMiscInfo.Size = new System.Drawing.Size(602, 330);
            this.panelMiscInfo.TabIndex = 8;
            this.panelMiscInfo.Thickness = 500F;
            // 
            // lblHr1
            // 
            this.lblHr1.AutoSize = true;
            this.lblHr1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr1.Location = new System.Drawing.Point(25, 14);
            this.lblHr1.Name = "lblHr1";
            this.lblHr1.Size = new System.Drawing.Size(60, 29);
            this.lblHr1.TabIndex = 0;
            this.lblHr1.Text = "Now";
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(33, 67);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(50, 42);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 1;
            this.svgImageBox1.Text = "svgHr1";
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
            // svgImageBox2
            // 
            this.svgImageBox2.Location = new System.Drawing.Point(33, 160);
            this.svgImageBox2.Name = "svgImageBox2";
            this.svgImageBox2.Size = new System.Drawing.Size(50, 42);
            this.svgImageBox2.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox2.SvgImage")));
            this.svgImageBox2.TabIndex = 3;
            this.svgImageBox2.Text = "svgHr1Wind";
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
            // svgImageBox3
            // 
            this.svgImageBox3.Location = new System.Drawing.Point(33, 251);
            this.svgImageBox3.Name = "svgImageBox3";
            this.svgImageBox3.Size = new System.Drawing.Size(50, 42);
            this.svgImageBox3.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox3.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox3.SvgImage")));
            this.svgImageBox3.TabIndex = 5;
            this.svgImageBox3.Text = "svgHr1Rain";
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
            // svgImageBox4
            // 
            this.svgImageBox4.Location = new System.Drawing.Point(261, 251);
            this.svgImageBox4.Name = "svgImageBox4";
            this.svgImageBox4.Size = new System.Drawing.Size(50, 42);
            this.svgImageBox4.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox4.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox4.SvgImage")));
            this.svgImageBox4.TabIndex = 12;
            this.svgImageBox4.Text = "svgHr2Rain";
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
            // svgImageBox5
            // 
            this.svgImageBox5.Location = new System.Drawing.Point(261, 160);
            this.svgImageBox5.Name = "svgImageBox5";
            this.svgImageBox5.Size = new System.Drawing.Size(50, 42);
            this.svgImageBox5.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox5.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox5.SvgImage")));
            this.svgImageBox5.TabIndex = 10;
            this.svgImageBox5.Text = "svgHr2Wind";
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
            // svgImageBox6
            // 
            this.svgImageBox6.Location = new System.Drawing.Point(261, 67);
            this.svgImageBox6.Name = "svgImageBox6";
            this.svgImageBox6.Size = new System.Drawing.Size(50, 42);
            this.svgImageBox6.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox6.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox6.SvgImage")));
            this.svgImageBox6.TabIndex = 8;
            this.svgImageBox6.Text = "svgHr2";
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
            // svgImageBox7
            // 
            this.svgImageBox7.Location = new System.Drawing.Point(507, 251);
            this.svgImageBox7.Name = "svgImageBox7";
            this.svgImageBox7.Size = new System.Drawing.Size(50, 42);
            this.svgImageBox7.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox7.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox7.SvgImage")));
            this.svgImageBox7.TabIndex = 19;
            this.svgImageBox7.Text = "svgHr3Rain";
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
            // svgImageBox8
            // 
            this.svgImageBox8.Location = new System.Drawing.Point(507, 160);
            this.svgImageBox8.Name = "svgImageBox8";
            this.svgImageBox8.Size = new System.Drawing.Size(50, 42);
            this.svgImageBox8.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox8.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox8.SvgImage")));
            this.svgImageBox8.TabIndex = 17;
            this.svgImageBox8.Text = "svgHr3Wind";
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
            // svgImageBox9
            // 
            this.svgImageBox9.Location = new System.Drawing.Point(507, 67);
            this.svgImageBox9.Name = "svgImageBox9";
            this.svgImageBox9.Size = new System.Drawing.Size(50, 42);
            this.svgImageBox9.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox9.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox9.SvgImage")));
            this.svgImageBox9.TabIndex = 15;
            this.svgImageBox9.Text = "svgHr3";
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
            this.Load += new System.EventHandler(this.HomeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panelMiscInfo.ResumeLayout(false);
            this.panelMiscInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox9)).EndInit();
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
        private DevExpress.XtraEditors.SvgImageBox svgImageBox7;
        private Label lblHr3Wind;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox8;
        private Label lblHr3Temp;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox9;
        private Label lblHr3;
        private Label lblHr2Rain;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox4;
        private Label lblHr2Wind;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox5;
        private Label lblHr2Temp;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox6;
        private Label lblHr2;
        private Label lblHr1Rain;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox3;
        private Label lblHr1Wind;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox2;
        private Label lblHr1Temp;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private Label lblHr1;
    }
}
