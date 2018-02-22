using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramZZamianaPol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dzialanie.Items.Add("+");
            dzialanie.Items.Add("-");
            dzialanie.Items.Add("*");
            dzialanie.Items.Add("/");
            dzialanie.SelectedItem = "+";
        }

        private void bZamien_Click(object sender, EventArgs e)
        {
            String poleTekstowe;
            poleTekstowe = text1.Text;
            text1.Text = text2.Text;
            text2.Text = poleTekstowe;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 wartosc=0;
            // wartosc = Convert.ToInt32(liczba1.Text) + Convert.ToInt32(liczba2.Text);
            //suma.Text = Convert.ToString(wartosc);
            // Convert.ToInt32(liczba1.Text) lub Int32.Parse(liczba1.Text) lub if(Int32.TryParse("35",wartosc)).....else..

            int w;
            if (int.TryParse(liczba1.Text, out w) && int.TryParse(liczba2.Text, out w))
            {
                suma.ForeColor = Color.Black;
                suma.BackColor = Color.White;
                String coRobic = dzialanie.SelectedItem.ToString();
                switch (coRobic)
                {
                    case "+": wartosc = Convert.ToInt32(liczba1.Text) + Convert.ToInt32(liczba2.Text); ; break;
                    case "-": wartosc = Convert.ToInt32(liczba1.Text) - Convert.ToInt32(liczba2.Text); ; break;
                    case "*": wartosc = Convert.ToInt32(liczba1.Text) * Convert.ToInt32(liczba2.Text); ; break;
                    case "/": wartosc = Convert.ToInt32(liczba1.Text) / Convert.ToInt32(liczba2.Text); ; break;
                }
                
                
                suma.Text = Convert.ToString(wartosc);
            }
            else
            {
                //MessageBox.Show("Niepoprawny format pol !!!");
                suma.Text = "Niepoprawny format danych";
                suma.ForeColor = Color.White;
                suma.BackColor = Color.Red;
            }
    
        }

        private void liczba1_TextChanged(object sender, EventArgs e)
        {
            int w;
            if (int.TryParse(liczba1.Text, out w))
            {
                liczba1.BackColor = Color.White;
            }
            else
            {
                liczba1.BackColor = Color.Red;
            }
        }

        private void liczba2_TextChanged(object sender, EventArgs e)
        {
            int w;
            if (int.TryParse(liczba2.Text, out w))
            {
                liczba2.BackColor = Color.White;
            }
            else
            {
                liczba2.BackColor = Color.Red;
            }
        }
    }
}
