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
    public partial class Object : Form
    {

        ObjectModel_MySystem_ model = new ObjectModel_MySystem_(1);
        int x10ON = 0;

        public Object()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.Input1++;
            lblInput1.Text = (model.Input1+ model.Input2-model.Input3).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            model.Input1--;
            lblInput1.Text = (model.Input1 + model.Input2 - model.Input3).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            model.Input3++;
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            model.Input3--;
            
        }

        private void tmSimulation_Tick(object sender, EventArgs e)
        {
            chSimulation1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chSimulation1.Series[0].Points.AddXY(model.Time, model.GetValueWaterLvL());

            chSimulation1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chSimulation1.Series[1].Points.AddXY(model.Time, model.GetValueConc());
            
           
            lblResult1.Text = model.Output1.ToString("F2");
            lblInput1.Text = (model.Input1 + model.Input2 - model.Input3).ToString();
            lblResult2.Text = model.Output2.ToString("F2");
           
        }

        private void bSpeedUp_Click(object sender, EventArgs e)
        {
            switch (x10ON)
            {
                case 0:
                    tmSimulation.Interval = tmSimulation.Interval / 10;
                    x10ON = 1;
                    break;
                case 1:
                    tmSimulation.Interval = tmSimulation.Interval * 10;
                    x10ON = 0;
                    break;
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {

            tmSimulation.Interval = 1000;
            tmSimulation.Start();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            tmSimulation.Stop();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            tmSimulation.Stop();
            model.Time = 0;
            model.Input1 = 0;
            model.Input2 = 0;
            model.Input3 = 0;
            chSimulation1.Series[0].Points.Clear();
            tmSimulation.Interval = 1000;
            tmSimulation.Start();
        }

      

        private void Button7_Click(object sender, EventArgs e)
        {
            model.Input2++;
            lblInput1.Text = (model.Input2 + model.Input1 - model.Input3).ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            model.Input2--;
            lblInput1.Text = (model.Input2 + model.Input1 - model.Input3).ToString();
        }



        private void Button3_Click(object sender, EventArgs e)
        {
            model.Input3--;

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            model.Input3++;
        }
    }
}
