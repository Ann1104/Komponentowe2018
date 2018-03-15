using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaintWektorowo
{
    public partial class OknoProgramu : Form
    {
        Graphics g;
        Graphics gp;
        List<Point> punktyRobocze = new List<Point>();
        Rysunek r;
        public OknoProgramu()
        {
            InitializeComponent();
            pictureBoxRamka.Image = new Bitmap(pictureBoxRamka.Width, pictureBoxRamka.Height);
            g = Graphics.FromImage(pictureBoxRamka.Image);
            gp = Graphics.FromImage(pictureBoxRamka.Image);
            r = new Rysunek(pictureBoxRamka.Width, pictureBoxRamka.Height, Color.White);
            r.Rysuj(g);
            pictureBoxRamka.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                punktyRobocze.Clear();
                punktyRobocze.Add(e.Location);
               
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                punktyRobocze.Add(e.Location);
                if (radioButtonProsta.Checked)
                {
                    
                    g.DrawLine(new Pen(buttonKolorLinii.BackColor, Convert.ToInt32(numericUpDownGruboscLinii.Value)), punktyRobocze.First(), e.Location);

                    pictureBoxRamka.Refresh();
                }
                else if (radioButtonKrzywa.Checked)
                {
                    /////
                    pictureBoxRamka.Refresh();
                }
                else if (radioButtonProstokat.Checked)
                {

                    g.FillRectangle(new SolidBrush(buttonKolorWypelnienia.BackColor), Math.Min(punktyRobocze.First().X, e.X),
                                                              Math.Min(punktyRobocze.First().Y, e.Y),
                                                              Math.Abs(punktyRobocze.First().X - e.X),
                                                              Math.Abs(punktyRobocze.First().Y - e.Y));
                    g.DrawRectangle(new Pen(buttonKolorLinii.BackColor, Convert.ToInt32(numericUpDownGruboscLinii.Value)), Math.Min(punktyRobocze.First().X, e.X),
                                                                      Math.Min(punktyRobocze.First().Y, e.Y),
                                                                      Math.Abs(punktyRobocze.First().X - e.X),
                                                                      Math.Abs(punktyRobocze.First().Y - e.Y));
                    pictureBoxRamka.Refresh();
                }
                else if (radioButtonElipsa.Checked)
                {

                    g.FillEllipse(new SolidBrush(buttonKolorWypelnienia.BackColor), Math.Min(punktyRobocze.First().X, e.X),
                                                              Math.Min(punktyRobocze.First().Y, e.Y),
                                                              Math.Abs(punktyRobocze.First().X - e.X),
                                                              Math.Abs(punktyRobocze.First().Y - e.Y));
                    g.DrawEllipse(new Pen(buttonKolorLinii.BackColor, Convert.ToInt32(numericUpDownGruboscLinii.Value)), Math.Min(punktyRobocze.First().X, e.X),
                                                                      Math.Min(punktyRobocze.First().Y, e.Y),
                                                                      Math.Abs(punktyRobocze.First().X - e.X),
                                                                      Math.Abs(punktyRobocze.First().Y - e.Y));
                    pictureBoxRamka.Refresh();
                }


            }
        }

        private void pictureBoxRamka_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                punktyRobocze.Add(e.Location);
                if (radioButtonProsta.Checked)
                {
                    r.Dodaj(new Linia(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, punktyRobocze.First(), punktyRobocze.Last()));
                }
                else if (radioButtonKrzywa.Checked)
                {
                    r.Dodaj(new Krzywa(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, punktyRobocze));
                }
                else if (radioButtonProstokat.Checked)
                {
                    r.Dodaj(new Prostokat(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, buttonKolorWypelnienia.BackColor, punktyRobocze.First(), punktyRobocze.Last()));
                }
                else if (radioButtonElipsa.Checked)
                {
                    r.Dodaj(new Elipsa(buttonKolorLinii.BackColor, (int)numericUpDownGruboscLinii.Value, buttonKolorWypelnienia.BackColor, punktyRobocze.First(), punktyRobocze.Last()));
                }

                r.Rysuj(g);
                pictureBoxRamka.Refresh();
            }
        }

        private void buttonKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog kolorOkno = new ColorDialog();
            if (kolorOkno.ShowDialog() == DialogResult.OK)
            {
                buttonKolorLinii.BackColor = kolorOkno.Color;
            }
        }

        private void buttonKolorWypelnienia_Click(object sender, EventArgs e)
        {
            ColorDialog kolorOkno = new ColorDialog();
            if (kolorOkno.ShowDialog() == DialogResult.OK)
            {
                buttonKolorWypelnienia.BackColor = kolorOkno.Color;
            }
        }
    }
}
