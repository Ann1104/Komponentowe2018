using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPaintWektorowo
{
    class Rysunek
    {
        private Int32 wysokosc;
        private Int32 szerokosc;
        private List<Figura> figury;
        private Color kolorTla;

        public Rysunek(int szerokosc, int wysokosc, Color kolorTla)
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            this.kolorTla = kolorTla;
            this.figury = new List<Figura>();
        }

        public void Rysuj(Graphics g)
        {
            g.Clear(kolorTla);
            foreach (Figura f in figury)
            {
                f.Rysuj(g);
            }
        }

        internal void Dodaj(Figura f)
        {
            figury.Add(f);
        }
    }
}
