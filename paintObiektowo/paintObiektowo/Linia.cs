using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paintObiektowo
{
    public class Linia : FNieWypelniona
    {
        private Point p;

        public Linia(Color kolorLinii, Int32 gruboscLinii, Point p1, Point p2) : base(kolorLinii, gruboscLinii, p1)
        {
            this.p = p2;
        }

        public override void Rysuj(Graphics g)
        {
            g.DrawLine(new Pen(kolorLinii, gruboscLinii), polozenie, p);
        }
    }
}
