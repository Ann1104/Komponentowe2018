using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paintObiektowo
{
    public abstract class FNieWypelniona : Figura
    {
        protected Color kolorLinii;
        protected Int32 gruboscLinii;
        protected Point polozenie;

        void Figura(Color kolor, Int32 grubosc, Point polozenie)
        {
            kolorLinii = kolor;
            gruboscLinii = grubosc;
            this.polozenie = polozenie;
        }
    }


}
