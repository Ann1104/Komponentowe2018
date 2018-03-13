using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintObiektowo
{
    public partial class Form1 : Form
    {
        Graphics g;
        Point p;

        public Form1()
        {
            InitializeComponent();
            Rysunek r = new Rysunek(Convert.ToInt32(pbRamka.Width), Convert.ToInt32(pbRamka.Height), Color.White);
            g = Graphics.FromImage(pbRamka.Image);
        }
    }
}
