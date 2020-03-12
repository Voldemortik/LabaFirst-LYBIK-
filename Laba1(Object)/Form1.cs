using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1_Object_
{
    public partial class Form1 : Form
    {
        ObjectModel model = new ObjectModel(1);
        int x10ON = 0 ;

        public Form1()
        {
            InitializeComponent();
            Object form = new Object();
            form.Show();
        }

        private void bUp_Click(object sender, EventArgs e)
        {
            model.Input++;
        }

        private void dDown_Click(object sender, EventArgs e)
        {
            model.Input--;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            chSimulation.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            tmSimulation.Interval = 1000;
            tmSimulation.Start();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            tmSimulation.Stop();
        }

        private void bSpeedUp_Click(object sender, EventArgs e)
        {
            switch (x10ON)
            {
                case 0:
                    tmSimulation.Stop();
                    tmSimulation.Interval = tmSimulation.Interval / 10;
                    tmSimulation.Start();
                    x10ON = 1;
                    break;
                case 1:
                    tmSimulation.Stop();
                    tmSimulation.Interval = tmSimulation.Interval * 10;
                    tmSimulation.Start();
                    x10ON = 0;
                    break;
            }
        }

        private void tmSimulation_Tick(object sender, EventArgs e)
        {
            chSimulation.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chSimulation.Series[0].Points.AddXY(model.Time, model.GetValue());
            lblResult.Text = model.Output.ToString();
            lblInput.Text = model.Input.ToString();
        }

        private void ChSimulation_Click(object sender, EventArgs e)
        {

        }
        
    }
}
