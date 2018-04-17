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

namespace WykresyPart2
{
    public partial class UserControlFunkcja : UserControl
    {
        private Color kolor;
        private string nazwa;
        private Series seria;

        public UserControlFunkcja()
        {
            InitializeComponent();
        }

        public UserControlFunkcja(string nazwa, int cz, int amp, Color kolor)
        {
            seria = new Series();

            InitializeComponent();

            this.nazwa = nazwa;
            checkBox1.Text = nazwa;
            numericUpDownCzestotliwosc.Value = cz;
            numericUpDownAmplituda.Value = amp;
            this.kolor = kolor;
            checkBox1.Checked = true;

            seria.Name = nazwa;
            seria.Color = kolor;
            seria.ChartType = SeriesChartType.Line;
            przeliczPunkty();
        }

        public delegate void motodaSender(UserControlFunkcja sender);
        public event motodaSender zmianaSerii;

        private void przeliczPunkty()
        {
            seria.Points.Clear();

            for (double x = 0; x <= 2 * Math.PI; x += 0.01)
            {
                double y = Math.Sin(x * (double)numericUpDownCzestotliwosc.Value) * (double)numericUpDownAmplituda.Value /2;
                seria.Points.Add(new DataPoint(x, y));
            }
            /*
            if(zmianaSerii!=null)
            {
                zmianaSerii == null;
            }
            */
        }

        internal Series dajSeria()
        {
            return seria;
        }

        private void numericUpDownCzestotliwosc_ValueChanged(object sender, EventArgs e)
        {
            przeliczPunkty();
        }

        private void numericUpDownAmplituda_ValueChanged(object sender, EventArgs e)
        {
            przeliczPunkty();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                przeliczPunkty();
            }
            else
            {
                seria.Points.Clear();
            }
        }
    }
}
