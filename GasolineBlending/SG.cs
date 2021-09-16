using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasolineBlending
{
    public partial class SG : UserControl
    {
        public SG()
        {
            InitializeComponent();
        }

        private void btnBlend_Click(object sender, EventArgs e)
        {
            try
            {
                double P1i = double.Parse(txtSG1.Text.ToString());
                double P2i = double.Parse(txtSG2.Text.ToString());

                double P1 = P1i;
                double P2 = P2i;
                double x2 = Math.Abs((0.7 - P1i) / (P2i - P1i));
                double x1 = 1 - x2;
                double x3 = x1 + x2;
                double Poi = 11;
                double P = 0;
                double Po = Poi;
                double h = 1;
                double tol = 0.01;
                double A = 1;
                double n = 0;
                double f = (-x3 * Po) + (x1 * P1) + (x2 * P2);
                List<double> iter = new List<double>();
                List<double> SG = new List<double>();

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

                    P = Math.Round((Poi + ((k1 + (2 * k2) + (2 * k3) + k4) * h) / 6), 2);
                    SG.Add(P);

                    A = Math.Round(Math.Abs(P - Poi), 2);
                    Poi = P;

                    n = n + 1;
                    iter.Add(n);
                }

                double length = iter.LongCount();
                for (int i = 0; i < length; i++)
                {
                    if (i == 0)
                    {
                        lblSG1.Text = SG[i + 3].ToString();
                        lblTime1.Text = iter[i + 3].ToString();
                    }
                    if (i == 1)
                    {
                        lblSG2.Text = SG[i + 3].ToString();
                        lblTime2.Text = iter[i + 3].ToString();
                    }
                    if (i == 2)
                    {
                        lblSG3.Text = SG[i + 3].ToString();
                        lblTime3.Text = iter[i + 3].ToString();
                    }
                    if (i == 3)
                    {
                        lblSG4.Text = SG[i + 3].ToString();
                        lblTime4.Text = iter[i + 3].ToString();
                    }
                    if (i == 4)
                    {
                        lblSG5.Text = SG[i + 3].ToString();
                        lblTime5.Text = iter[i + 3].ToString();
                    }
                    if (i == 5)
                    {
                        lblSG6.Text = SG[i + 3].ToString();
                        lblTime6.Text = iter[i + 3].ToString();
                    }
                    if (i + 1 == length)
                    {
                        lblSG7.Text = SG[i].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtSG1.Text = string.Empty;
            txtSG2.Text = string.Empty;
            lblSG1.Text = string.Empty;
            lblSG2.Text = string.Empty;
            lblSG3.Text = string.Empty;
            lblSG4.Text = string.Empty;
            lblSG5.Text = string.Empty;
            lblSG6.Text = string.Empty;
            lblSG7.Text = string.Empty;
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
            chart1.Series.Add("SG");
            chart1.Series["SG"].ChartArea = "chart1";
            chart1.Series["SG"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Titles.Add("Graph of PMS SG against Time(hrs)");
            chart1.ChartAreas[0].AxisX.Title = "Time (hrs)";
            chart1.ChartAreas[0].AxisY.Title = "SG";

            chart1.Series["SG"].Points.AddXY(lblTime1.Text, lblSG1.Text);
            chart1.Series["SG"].Points.AddXY(lblTime2.Text, lblSG2.Text);
            chart1.Series["SG"].Points.AddXY(lblTime3.Text, lblSG3.Text);
            chart1.Series["SG"].Points.AddXY(lblTime4.Text, lblSG4.Text);
            chart1.Series["SG"].Points.AddXY(lblTime5.Text, lblSG5.Text);
            chart1.Series["SG"].Points.AddXY(lblTime6.Text, lblSG6.Text);
            chart1.Series["SG"].Points.AddXY(lblTime7.Text, lblSG7.Text);
        }
    }
}
