using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();
        }
        const decimal g = 9.81M;
        const decimal rho = 1.29M;
        const decimal C = 0.15M;
        decimal vx, vy;
        decimal maxH;
        int seriesCounter = 0;

        

        private void button1_Click(object sender, EventArgs e)
        {
            var s = new System.Windows.Forms.DataVisualization.Charting.Series();
            s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            s.BorderWidth = 3;
            chart1.Series.Add(s);
            maxH = 0;
            decimal t = 0;
            decimal x = 0, y = 0;
            decimal step = StepField.Value;
            decimal speed =SpeedField.Value;
            double angle = (double)AngleField.Value * Math.PI / 180;
            decimal cos = (decimal)Math.Cos(angle);
            decimal sin = (decimal)Math.Sin(angle);
            decimal size = SizeField.Value;
            decimal weigth = WeigthField.Value;
            var k = 0.5M * C * rho * size / weigth;

            vx = speed * cos;
            vy = speed * sin;

            chart1.Series[seriesCounter].Points.AddXY(x, y);
            decimal v;
            do
            {
                t += step;

                v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
                vx = vx - k * vx * v * step;
                vy = vy - (g + k * vy * v) * step;
                x = x + vx * step;
                y = y + vy * step;
                if (y > maxH) maxH = y;
                chart1.Series[seriesCounter].Points.AddXY(x, y);
            }
            while (y >= 0);
            seriesCounter++;
            dataGridView1.Rows.Add(step, x, maxH, v);
        }
    }
}
