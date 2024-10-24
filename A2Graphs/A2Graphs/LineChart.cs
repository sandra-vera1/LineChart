using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace A2Graphs
{
    public class LineChart : System.Windows.Forms.DataVisualization.Charting.Chart
    {

        public LineChart()
        {

            
        }  
        
        public void InitializeGraph()
        {
            string chartAreaName = "ChartArea1";

            if (this.ChartAreas.IndexOf(chartAreaName) == -1)
            {
                
                this.ChartAreas.Add(new ChartArea(chartAreaName));
            }

            string legendName = "Legend1";

            if (this.Legends.IndexOf(legendName) == -1)
            {
               
                this.Legends.Add(new Legend(legendName));
            }

            
            var objChart = this.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 4; //Terms 
            objChart.AxisX.Title = "Term";

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 4; //GPA
            objChart.AxisY.Title = "GPA";
            objChart.AxisY.Interval = 1;
        }
    }
}
