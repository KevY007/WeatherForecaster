using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecaster
{
    internal class Graphing
    {
        private ChartControl chart = null;

        public Graphing(ChartControl chart) 
        { 
            this.chart = chart;

            chart.Series.Clear();
            chart.Legends.Clear();
        }

        public void Map(Weather w) 
        { 

        }
    }
}
