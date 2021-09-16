using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GasolineBlending
{
    public partial class RON : UserControl
    {
        public RON()
        {
            InitializeComponent();
        }

        private void btnBlend_Click(object sender, EventArgs e)
        {
            try
            {
                double P1i = double.Parse(txtRON1.Text.ToString());
                double P2i = double.Parse(txtRON2.Text.ToString());

                double P1 = P1i; double P2 = P2i;
                double x2 = Math.Abs((90 - P1i) / (P2i - P1i));
                double x1 = 1 - x2; double x3 = x1 + x2;
                double Poi = 70; double Po = Poi; double P = 0;
                double h = 1; double tol = 0.1;
                double A = 1; double n = 0;
                double f = (-x3 * Po) + (x1 * P1) + (x2 * P2);
                List<double> iter = new List<double>();
                List<double> RON = new List<double>();

                while (A >= tol)
                {
                    double k1 = f;

                    P1 = P1i + 0.5 * h;
                    P2 = P2i + 0.5 * h;
                    Po = Poi + 0.5 * k1 * h;
                    double k2 = (-x3 * Po) + (x1 * P1) + (x2 * P2);

                    Po = Poi + 0.5 * k2 * h;
                    double k3 = (-x3 * Po) + (x1 * P1) + (x2 * P2);

                    P1 = P1i + h;
                    P2 = P2i + h;
                    Po = Poi + k3 * h;
                    double k4 = (-x3 * Po) + (x1 * P1) + (x2 * P2);

                    P = Math.Round((Poi + ((k1 + (2 * k2) + (2 * k3) + k4) * h) / 6), 1);
                    RON.Add(P);

                    A = Math.Round(Math.Abs(P - Poi), 1);
                    Poi = P;

                    n = n + 1;
                    iter.Add(n);
                }

                double length = iter.LongCount();
                for (int i = 0; i < length; i++)
                {
                    if (i == 0)
                    {
                        lblRON1.Text = RON[i].ToString();
                        lblTime1.Text = iter[i].ToString();
                    }
                    if (i == 1)
                    {
                        lblRON2.Text = RON[i].ToString();
                        lblTime2.Text = iter[i].ToString();
                    }
                    if (i == 2)
                    {
                        lblRON3.Text = RON[i].ToString();
                        lblTime3.Text = iter[i].ToString();
                    }
                    if (i == 3)
                    {
                        lblRON4.Text = RON[i].ToString();
                        lblTime4.Text = iter[i].ToString();
                    }
                    if (i == 4)
                    {
                        lblRON5.Text = RON[i].ToString();
                        lblTime5.Text = iter[i].ToString();
                    }
                    if (i == 5)
                    {
                        lblRON6.Text = RON[i].ToString();
                        lblTime6.Text = iter[i].ToString();
                    }
                    if (i + 1 == length)
                    {
                        lblRON7.Text = RON[i].ToString();
                        lblTime7.Text = iter[i].ToString();
                    }
                    i = i;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            


            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtRON1.Text = string.Empty;
            txtRON2.Text = string.Empty;
            lblRON1.Text = string.Empty;
            lblRON2.Text = string.Empty;
            lblRON3.Text = string.Empty;
            lblRON4.Text = string.Empty;
            lblRON5.Text = string.Empty;
            lblRON6.Text = string.Empty;
            lblRON7.Text = string.Empty;
            lblTime1.Text = string.Empty;
            lblTime2.Text = string.Empty;
            lblTime3.Text = string.Empty;
            lblTime4.Text = string.Empty;
            lblTime5.Text = string.Empty;
            lblTime6.Text = string.Empty;
            lblTime7.Text = string.Empty;
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();
            chart1.Series.Clear();
            chart1.ChartAreas.Add("chart1");
            chart1.Series.Add("RON");
            chart1.Series["RON"].ChartArea = "chart1";
            chart1.Series["RON"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Titles.Add("Graph of PMS RON against Time(hrs)");
            chart1.ChartAreas[0].AxisX.Title = "Time (hrs)";
            chart1.ChartAreas[0].AxisY.Title = "RON";

            chart1.Series["RON"].Points.AddXY(lblTime1.Text, lblRON1.Text);
            chart1.Series["RON"].Points.AddXY(lblTime2.Text, lblRON2.Text);
            chart1.Series["RON"].Points.AddXY(lblTime3.Text, lblRON3.Text);
            chart1.Series["RON"].Points.AddXY(lblTime4.Text, lblRON4.Text);
            chart1.Series["RON"].Points.AddXY(lblTime5.Text, lblRON5.Text);
            chart1.Series["RON"].Points.AddXY(lblTime6.Text, lblRON6.Text);
            chart1.Series["RON"].Points.AddXY(lblTime7.Text, lblRON7.Text);
            
            
        }
    }
}
