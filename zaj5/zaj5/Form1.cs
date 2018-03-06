using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaj5
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pioro;
        Brush pedzel;
        ColorDialog cd;
        Point punkt = new Point(0,0);
        public Form1()
        {
            InitializeComponent();

            ramka.Image = new Bitmap(ramka.Width, ramka.Height);
            
           g = Graphics.FromImage(ramka.Image);

           pioro = new Pen(Color.Turquoise, 4);
           bColor.BackColor = pioro.Color;
           pioro.StartCap = System.Drawing.Drawing2D.LineCap.Round;
           pioro.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            pedzel = new SolidBrush(Color.Purple);

            /*
           g.Clear(Color.Turquoise); //zamalowuje tło na dany kolor

           g.DrawLine(pioro,0, 0, 200, 200);
           g.DrawRectangle(pioro, 50, 50, 200, 200);
           g.FillRectangle(pedzel, 50, 50, 200, 200);

           g.DrawEllipse(pioro, 30, 30, 100, 100);
           g.FillEllipse(pedzel, 30, 30, 100, 100);
           */

            numericUpDown1.Minimum = 1;

            ramka.Refresh();
        }

        private void ramka_MouseMove(object sender, MouseEventArgs e)
        {
            
            if(e.Button == MouseButtons.Left && rbNoLine.Checked)
            {
                
                g.DrawLine(pioro, punkt.X, punkt.Y, e.X, e.Y);
                punkt = e.Location;
                ramka.Refresh();
            }
            
        }

        private void ramka_MouseDown(object sender, MouseEventArgs e)
        {
            punkt = e.Location;
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            cd = new ColorDialog();
            cd.ShowDialog();
            pioro.Color = cd.Color;
            bColor.BackColor = cd.Color;

        }

        private void ramka_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(rbNoLine.Checked || rbLine.Checked)
                {
                    g.DrawLine(pioro, punkt.X, punkt.Y, e.X, e.Y);
                }
                else if (rbRectangle.Checked)
                {
                    g.DrawRectangle(pioro, Math.Min(punkt.X, e.X), Math.Min(punkt.Y, e.Y), Math.Abs(e.X - punkt.X), Math.Abs(e.Y - punkt.Y));
                }
                else if(rbElipse.Checked)
                {
                    g.DrawEllipse(pioro, Math.Min(punkt.X, e.X), Math.Min(punkt.Y, e.Y), Math.Abs(e.X - punkt.X), Math.Abs(e.Y - punkt.Y));
                }
                ramka.Refresh();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pioro.Width = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
