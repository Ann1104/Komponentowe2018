using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PierwszyProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();}

        Button bbb;
        private void button1_Click(object sender, EventArgs e)
        {
            //bPowitalny.Text = "Po kliknieciu";
            bPowitalny.Text = "Powitanie";
            /*
            this.bPowitalny.Text = "???";

            
            bbb = new Button();

            if(bbb!=null) // gdyby bbb nie bylo zdefiniowane
            {
                bbb.Text = "!!!";
            }
            */
            /*
            bbb = bPowitalny;

            if(bbb==bPowitalny)//porownanie referencji
            {
                bbb.Text = "!!!!";
            }
            */

            String powitanie = "Cześć " + textBoxImie.Text;

            if (textBoxImie.Text == "")
                powitanie = "Cześć nieznajomy :)";

            MessageBox.Show(powitanie);
        }
    }
}
