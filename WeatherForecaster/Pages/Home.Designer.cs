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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.lblLowHighSep = new System.Windows.Forms.Label();
            this.panelMiscInfo = new WeatherForecaster.Controls.RoundedPanel();
            this.lblHr3Rain = new System.Windows.Forms.Label();
            this.lblHr2Rain = new System.Windows.Forms.Label();
            this.lblHr3Wind = new System.Windows.Forms.Label();
            this.lblHr2Wind = new System.Windows.Forms.Label();
            this.lblHr3Temp = new System.Windows.Forms.Label();
            this.lblHr2Temp = new System.Windows.Forms.Label();
            this.svgHr3Rain = new DevExpress.XtraEditors.SvgImageBox();
            this.svgHr3Wind = new DevExpress.XtraEditors.SvgImageBox();
            this.svgHr3 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr3 = new System.Windows.Forms.Label();
            this.svgHr2Rain = new DevExpress.XtraEditors.SvgImageBox();
            this.svgHr2Wind = new DevExpress.XtraEditors.SvgImageBox();
            this.svgHr2 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr2 = new System.Windows.Forms.Label();
            this.lblHr1Rain = new System.Windows.Forms.Label();
            this.svgHr1Rain = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr1Wind = new System.Windows.Forms.Label();
            this.svgHr1Wind = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr1Temp = new System.Windows.Forms.Label();
            this.svgHr1 = new DevExpress.XtraEditors.SvgImageBox();
            this.lblHr1 = new System.Windows.Forms.Label();
            this.weatherIconCollection = new DevExpress.Utils.SvgImageCollection(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocationName
            // 
            this.lblLocationName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocationName.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(3, 28);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(1279, 80);
            this.lblLocationName.TabIndex = 0;
            this.lblLocationName.Text = "Katowice";
            this.lblLocationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay
            // 
            this.lblDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDay.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Gray;
            this.lblDay.Location = new System.Drawing.Point(3, 122);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(1279, 36);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "Today";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperature
            // 
            this.lblTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTemperature.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTemperature.Location = new System.Drawing.Point(9, 181);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(1276, 80);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "2 °C";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.separatorControl1.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.separatorControl1.LineThickness = 2;
            this.separatorControl1.Location = new System.Drawing.Point(464, 249);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(358, 30);
            this.separatorControl1.TabIndex = 3;
            // 
            // lblCondition
            // 
            this.lblCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCondition.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.Color.Gray;
            this.lblCondition.Location = new System.Drawing.Point(0, 278);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(1282, 36);
            this.lblCondition.TabIndex = 4;
            this.lblCondition.Text = "Sunny";
            this.lblCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowest
            // 
            this.lblLowest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLowest.BackColor = System.Drawing.Color.Transparent;
            this.lblLowest.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(134)))), ((int)(((byte)(202)))));
            this.lblLowest.Location = new System.Drawing.Point(512, 323);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(109, 36);
            this.lblLowest.TabIndex = 5;
            this.lblLowest.Text = "-5 °C";
            this.lblLowest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHighest
            // 
            this.lblHighest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHighest.BackColor = System.Drawing.Color.Transparent;
            this.lblHighest.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(82)))), ((int)(((byte)(135)))));
            this.lblHighest.Location = new System.Drawing.Point(641, 323);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(97, 36);
            this.lblHighest.TabIndex = 6;
            this.lblHighest.Text = "2 °C";
            this.lblHighest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLowHighSep
            // 
            this.lblLowHighSep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLowHighSep.BackColor = System.Drawing.Color.Transparent;
            this.lblLowHighSep.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowHighSep.ForeColor = System.Drawing.Color.Gray;
            this.lblLowHighSep.Location = new System.Drawing.Point(609, 323);
            this.lblLowHighSep.Name = "lblLowHighSep";
            this.lblLowHighSep.Size = new System.Drawing.Size(41, 36);
            this.lblLowHighSep.TabIndex = 7;
            this.lblLowHighSep.Text = "/";
            this.lblLowHighSep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMiscInfo
            // 
            this.panelMiscInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelMiscInfo.BorderColor = System.Drawing.Color.Transparent;
            this.panelMiscInfo.Controls.Add(this.lblHr3Rain);
            this.panelMiscInfo.Controls.Add(this.lblHr2Rain);
            this.panelMiscInfo.Controls.Add(this.lblHr3Wind);
            this.panelMiscInfo.Controls.Add(this.lblHr2Wind);
            this.panelMiscInfo.Controls.Add(this.lblHr3Temp);
            this.panelMiscInfo.Controls.Add(this.lblHr2Temp);
            this.panelMiscInfo.Controls.Add(this.svgHr3Rain);
            this.panelMiscInfo.Controls.Add(this.svgHr3Wind);
            this.panelMiscInfo.Controls.Add(this.svgHr3);
            this.panelMiscInfo.Controls.Add(this.lblHr3);
            this.panelMiscInfo.Controls.Add(this.svgHr2Rain);
            this.panelMiscInfo.Controls.Add(this.svgHr2Wind);
            this.panelMiscInfo.Controls.Add(this.svgHr2);
            this.panelMiscInfo.Controls.Add(this.lblHr2);
            this.panelMiscInfo.Controls.Add(this.lblHr1Rain);
            this.panelMiscInfo.Controls.Add(this.svgHr1Rain);
            this.panelMiscInfo.Controls.Add(this.lblHr1Wind);
            this.panelMiscInfo.Controls.Add(this.svgHr1Wind);
            this.panelMiscInfo.Controls.Add(this.lblHr1Temp);
            this.panelMiscInfo.Controls.Add(this.svgHr1);
            this.panelMiscInfo.Controls.Add(this.lblHr1);
            this.panelMiscInfo.Location = new System.Drawing.Point(340, 373);
            this.panelMiscInfo.Name = "panelMiscInfo";
            this.panelMiscInfo.Radius = 10;
            this.panelMiscInfo.Size = new System.Drawing.Size(602, 330);
            this.panelMiscInfo.TabIndex = 8;
            this.panelMiscInfo.Thickness = 500F;
            // 
            // lblHr3Rain
            // 
            this.lblHr3Rain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr3Rain.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr3Rain.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr3Rain.Location = new System.Drawing.Point(479, 296);
            this.lblHr3Rain.Name = "lblHr3Rain";
            this.lblHr3Rain.Size = new System.Drawing.Size(108, 24);
            this.lblHr3Rain.TabIndex = 26;
            this.lblHr3Rain.Text = "50%";
            this.lblHr3Rain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHr2Rain
            // 
            this.lblHr2Rain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr2Rain.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr2Rain.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr2Rain.Location = new System.Drawing.Point(237, 296);
            this.lblHr2Rain.Name = "lblHr2Rain";
            this.lblHr2Rain.Size = new System.Drawing.Size(108, 24);
            this.lblHr2Rain.TabIndex = 25;
            this.lblHr2Rain.Text = "50%";
            this.lblHr2Rain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHr3Wind
            // 
            this.lblHr3Wind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr3Wind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr3Wind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr3Wind.Location = new System.Drawing.Point(474, 205);
            this.lblHr3Wind.Name = "lblHr3Wind";
            this.lblHr3Wind.Size = new System.Drawing.Size(122, 22);
            this.lblHr3Wind.TabIndex = 24;
            this.lblHr3Wind.Text = "3 KM/H";
            this.lblHr3Wind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHr2Wind
            // 
            this.lblHr2Wind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr2Wind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr2Wind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr2Wind.Location = new System.Drawing.Point(228, 205);
            this.lblHr2Wind.Name = "lblHr2Wind";
            this.lblHr2Wind.Size = new System.Drawing.Size(122, 22);
            this.lblHr2Wind.TabIndex = 23;
            this.lblHr2Wind.Text = "3 KM/H";
            this.lblHr2Wind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHr3Temp
            // 
            this.lblHr3Temp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr3Temp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr3Temp.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr3Temp.Location = new System.Drawing.Point(475, 115);
            this.lblHr3Temp.Name = "lblHr3Temp";
            this.lblHr3Temp.Size = new System.Drawing.Size(112, 24);
            this.lblHr3Temp.TabIndex = 22;
            this.lblHr3Temp.Text = "2°C";
            this.lblHr3Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHr2Temp
            // 
            this.lblHr2Temp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr2Temp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr2Temp.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr2Temp.Location = new System.Drawing.Point(233, 115);
            this.lblHr2Temp.Name = "lblHr2Temp";
            this.lblHr2Temp.Size = new System.Drawing.Size(112, 24);
            this.lblHr2Temp.TabIndex = 21;
            this.lblHr2Temp.Text = "2°C";
            this.lblHr2Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblHr3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr3.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr3.Location = new System.Drawing.Point(416, 14);
            this.lblHr3.Name = "lblHr3";
            this.lblHr3.Size = new System.Drawing.Size(233, 29);
            this.lblHr3.TabIndex = 14;
            this.lblHr3.Text = "14:00";
            this.lblHr3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblHr2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr2.Location = new System.Drawing.Point(158, 14);
            this.lblHr2.Name = "lblHr2";
            this.lblHr2.Size = new System.Drawing.Size(265, 29);
            this.lblHr2.TabIndex = 7;
            this.lblHr2.Text = "13:00";
            this.lblHr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHr1Rain
            // 
            this.lblHr1Rain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr1Rain.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr1Rain.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr1Rain.Location = new System.Drawing.Point(7, 296);
            this.lblHr1Rain.Name = "lblHr1Rain";
            this.lblHr1Rain.Size = new System.Drawing.Size(108, 24);
            this.lblHr1Rain.TabIndex = 6;
            this.lblHr1Rain.Text = "50%";
            this.lblHr1Rain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblHr1Wind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr1Wind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr1Wind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr1Wind.Location = new System.Drawing.Point(0, 205);
            this.lblHr1Wind.Name = "lblHr1Wind";
            this.lblHr1Wind.Size = new System.Drawing.Size(122, 22);
            this.lblHr1Wind.TabIndex = 4;
            this.lblHr1Wind.Text = "3 KM/H";
            this.lblHr1Wind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblHr1Temp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr1Temp.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr1Temp.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr1Temp.Location = new System.Drawing.Point(3, 115);
            this.lblHr1Temp.Name = "lblHr1Temp";
            this.lblHr1Temp.Size = new System.Drawing.Size(112, 24);
            this.lblHr1Temp.TabIndex = 2;
            this.lblHr1Temp.Text = "2°C";
            this.lblHr1Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblHr1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHr1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHr1.Location = new System.Drawing.Point(-95, 14);
            this.lblHr1.Name = "lblHr1";
            this.lblHr1.Size = new System.Drawing.Size(310, 29);
            this.lblHr1.TabIndex = 0;
            this.lblHr1.Text = "Now";
            this.lblHr1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weatherIconCollection
            // 
            this.weatherIconCollection.Add("weather_hail", "image://svgimages/icon builder/weather_hail.svg");
            this.weatherIconCollection.Add("weather_partlycloudyday", "image://svgimages/icon builder/weather_partlycloudyday.svg");
            this.weatherIconCollection.Add("weather_partlycloudynight", "image://svgimages/icon builder/weather_partlycloudynight.svg");
            this.weatherIconCollection.Add("weather_rain", "image://svgimages/icon builder/weather_rain.svg");
            this.weatherIconCollection.Add("weather_rainandhail", "image://svgimages/icon builder/weather_rainandhail.svg");
            this.weatherIconCollection.Add("weather_rainheavy", "image://svgimages/icon builder/weather_rainheavy.svg");
            this.weatherIconCollection.Add("weather_rainlight", "image://svgimages/icon builder/weather_rainlight.svg");
            this.weatherIconCollection.Add("weather_snow", "image://svgimages/icon builder/weather_snow.svg");
            this.weatherIconCollection.Add("weather_snowfall", "image://svgimages/icon builder/weather_snowfall.svg");
            this.weatherIconCollection.Add("weather_snowfallheavy", "image://svgimages/icon builder/weather_snowfallheavy.svg");
            this.weatherIconCollection.Add("weather_snowfalllight", "image://svgimages/icon builder/weather_snowfalllight.svg");
            this.weatherIconCollection.Add("weather_storm", "image://svgimages/icon builder/weather_storm.svg");
            this.weatherIconCollection.Add("weather_sunny", "image://svgimages/icon builder/weather_sunny.svg");
            this.weatherIconCollection.Add("weather_water", "image://svgimages/icon builder/weather_water.svg");
            this.weatherIconCollection.Add("weather_wind", "image://svgimages/icon builder/weather_wind.svg");
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
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblLocationName);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1285, 721);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panelMiscInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgHr3Rain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr3Wind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr2Rain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr2Wind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr1Rain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr1Wind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgHr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTemperature;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Label lblLowHighSep;
        private Controls.RoundedPanel panelMiscInfo;
        private DevExpress.XtraEditors.SvgImageBox svgHr3Rain;
        private DevExpress.XtraEditors.SvgImageBox svgHr3Wind;
        private DevExpress.XtraEditors.SvgImageBox svgHr3;
        private Label lblHr3;
        private DevExpress.XtraEditors.SvgImageBox svgHr2Rain;
        private DevExpress.XtraEditors.SvgImageBox svgHr2Wind;
        private DevExpress.XtraEditors.SvgImageBox svgHr2;
        private Label lblHr2;
        private Label lblHr1Rain;
        private DevExpress.XtraEditors.SvgImageBox svgHr1Rain;
        private Label lblHr1Wind;
        private DevExpress.XtraEditors.SvgImageBox svgHr1Wind;
        private Label lblHr1Temp;
        private DevExpress.XtraEditors.SvgImageBox svgHr1;
        private Label lblHr1;
        private Label lblHr3Rain;
        private Label lblHr2Rain;
        private Label lblHr3Wind;
        private Label lblHr2Wind;
        private Label lblHr3Temp;
        private Label lblHr2Temp;
        private DevExpress.Utils.SvgImageCollection weatherIconCollection;
    }
}
