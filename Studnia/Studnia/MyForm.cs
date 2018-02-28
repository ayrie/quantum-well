using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNumerics.LinearAlgebra;

namespace Studnia
{
    public partial class MyForm : Form
    {
        double d;
        double V;
        QuantumWell well;

        double step;
        double range;

        int n = 0;

        public MyForm()
        {
            InitializeComponent();

            well = new QuantumWell();

            ActualizeValues();

            well.Schrodinger(step, range);
            DrawChart();
        }

        public void ActualizeValues()
        {
            d = Double.Parse(textBoxWidth.Text);
            V = Double.Parse(textBoxBarrier.Text);
            step = Double.Parse(textBoxStep.Text);
            range = Double.Parse(textBoxRange.Text);
            n = int.Parse(textBoxIndex.Text);

            well.Width = d;
            well.BarrierHeight = V;

            well.Schrodinger(step, range);
            textBoxDisplay.Text = well.EigenVals.MatrixToString();
        }

        public void DrawChart()
        {
            chartEnergy.Series[0].Points.Clear();
            chartFunctions.Series[0].Points.Clear();
            chartFunctions.Series[1].Points.Clear();
            chartFunctions.Series[2].Points.Clear();

            int points = (int)(range / step);
            int wellStart = (int)((range - d)/(2 * step));
            int wellEnd = (int)((range + d) / (2 * step));

            chartFunctions.ChartAreas[0].AxisX.Maximum = range;

            for (int i = 0; i < points; i++)
            {
                if(well.EigenVals[i, 0] < V)
                    chartEnergy.Series[0].Points.AddXY(i, well.EigenVals[i, 0]);

                chartFunctions.Series[0].Points.AddXY(i*step, well.VMatrix[i, i]);

                int j = 0;

                while (i > wellStart && i < wellEnd && well.EigenVals[j, 0] < V)
                {
                    chartFunctions.Series[1].Points.AddXY(i*step, well.EigenVals[j, 0]);
                    j++;
                }

                chartFunctions.Series[2].Points.AddXY(i*step, well.EigenVals[n, 0] + well.EigenVects[i, n]);
            }


        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            ActualizeValues();
            //n = (int)domainUpDownFunIndex.SelectedItem;

            DrawChart();
            
        }
    }
}
