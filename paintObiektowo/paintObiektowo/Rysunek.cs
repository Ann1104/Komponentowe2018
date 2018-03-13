using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paintObiektowo
{
   public class Rysunek
    {
        private Int32 Szer = 0;
        private Int32 Wys = 0;
        private List<Figura> figury;
        private Color kolorTla;

        Rysunek(Int32 Szerokosc, Int32 Wysokosc, Color kolorTla)
        {
            this.Szer = Szerokosc;
            this.Wys = Wysokosc;
            this.kolorTla = kolorTla;
            figury = new List<Figura>();
        }

        public void Dodaj(Figura f)
        {
            figury.Add(f);
        }

        public void Rysuj( Graphics g)
        {
            g.Clear(kolorTla);
            foreach (Figura f in figury)
            {
                f.Rysuj(g);
            }
        }
    }
}
