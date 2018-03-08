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
        List<Image> listaCofania = new List<Image>(); //typ gemeryczny, szablon
        List<Image> listaPonawiania = new List<Image>();
        public Form1()
        {
            InitializeComponent();

            ramka.Image = new Bitmap(ramka.Width, ramka.Height);
            ramka.BackColor = Color.White;
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

            listaCofania.Add(new Bitmap(ramka.Image));
            listaPonawiania.Clear();
            // ramka.Image lub ramka.Image.Clone() as Image
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pioro.Width = Convert.ToInt32(numericUpDown1.Value);
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap|*.bmp|Plik typu jpg|*.jpg";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                ramka.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
           
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap|*.bmp|Plik typu jpg|*.jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                ramka.Image = new Bitmap(ofd.FileName);
                g = Graphics.FromImage(ramka.Image);
                ramka.Refresh();
            }
        }

        private void wyczyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            ramka.Refresh();
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (listaCofania.Count > 1)
            {
                listaPonawiania.Add(listaCofania.Last());
                listaCofania.Remove(listaCofania.Last());
                ramka.Image = listaCofania.Last();
                g = Graphics.FromImage(ramka.Image);
                ramka.Refresh();
            } 
            
            /*
            foreach(int element in listaCofania)
            {

            }

            lista.addrange - mozna dodać listę do listy o ile ich typy przechowywane sa takie same
            */

        }

        private void ponówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listaPonawiania.Count > 0)
            {
                listaCofania.Add(listaPonawiania.Last());
                listaPonawiania.Remove(listaPonawiania.Last());
                ramka.Image = listaPonawiania.Last();
                g = Graphics.FromImage(ramka.Image);
                ramka.Refresh();
            }
        }
    }
}
