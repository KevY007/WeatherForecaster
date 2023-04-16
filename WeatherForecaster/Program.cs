using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WeatherForecaster
{
    public static partial class Global
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static formMain MainForm = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new formMain();
            Application.Run(MainForm);
        }
    }
}