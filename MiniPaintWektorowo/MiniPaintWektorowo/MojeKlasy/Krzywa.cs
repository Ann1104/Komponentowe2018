﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace MiniPaintWektorowo
{
    public class Krzywa : FiguraNiewypelniona
    {
        private List<Point> pp;

        public Krzywa(Color kolorLinii, Int32 gruboscLinii, List<Point> pp)
            : base(kolorLinii, gruboscLinii, pp[0])
        {
            this.pp = new List<Point>(pp);
            this.pp.RemoveAt(0);
        }
        public override void Rysuj(Graphics g)
        {
            g.DrawLine(new Pen(kolorLinii, gruboscLinii), polozenie, pp[0]);
            for (int i=0; i<pp.Count-1; i++)
            {
                g.DrawLine(new Pen(kolorLinii, gruboscLinii), pp[i], pp[i+1]);
            }
        }
    }
}