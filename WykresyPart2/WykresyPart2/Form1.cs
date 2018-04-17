using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WykresyPart2
{
    public partial class Form1 : Form
    {
        CheckBox checkBoxSuma = new CheckBox();
        Series suma;

        public Form1()
        {
            InitializeComponent();

            flowLayoutPanel1.Controls.Add(new UserControlFunkcja("Delta", 5, 20, Color.Blue));
            flowLayoutPanel1.Controls.Add(new UserControlFunkcja("Teta", 10, 10, Color.Green));
            flowLayoutPanel1.Controls.Add(new UserControlFunkcja("Alfa", 8, 8, Color.Yellow));
            flowLayoutPanel1.Controls.Add(new UserControlFunkcja("SMR", 16, 4, Color.Red));
            flowLayoutPanel1.Controls.Add(new UserControlFunkcja("Beta", 18, 3, Color.Purple));
            flowLayoutPanel1.Controls.Add(new UserControlFunkcja("Beta2", 35, 7, Color.Silver));

            chart1.Series.Clear();

            checkBoxSuma.CheckedChanged += checkBoxSuma_CheckedChanged;
            checkBoxSuma.Text = "Suma fal";
            checkBoxSuma.Checked = false;

            flowLayoutPanel1.Controls.Add(checkBoxSuma);

            suma = new Series();
            suma.BorderWidth = 3;
            suma.Color = Color.Black;
            suma.ChartType = SeriesChartType.Line;

        }

        private void F_zmianaSerii(UserControlFunkcja sender)
        {
            suma.Points.Clear();


            foreach (DataPoint dp in (flowLayoutPanel1.Controls[0] as UserControlFunkcja).dajSeria().Points)
            {
                suma.Points.Add(new DataPoint(dp.XValue, 0));
            }


            foreach (UserControlFunkcja f in flowLayoutPanel1.Controls)
            {
                Series s = f.dajSeria();
                if (s.Points.Count > 0)
                {
                    for (int i = 0; i < suma.Points.Count; i++)
                    {
                        suma.Points[i].YValues[0] += s.Points[i].YValues[0];
                    }
                }

            }

        }

        private void checkBoxSuma_CheckedChanged(object sender, EventArgs e)
        {
            // nie wiem jeszcze jak to zrobić xD
            if (checkBoxSuma.Checked == true)
            {


            }
            else
            {

            }
        }
    }
}
