using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patnáctka
{
    internal class PolickoL : Policko
    {
        public PolickoL(int poradi, Image obrazek, Point pozice) : base(poradi, obrazek, pozice)
        {
            this.Size = new Size(133, 133);
            this.poradi = poradi;
            this.obrazek = obrazek;

            pozice.X *= Width;
            pozice.Y *= Height;

            this.obrazekX = pozice.X;
            this.obrazekY = pozice.Y;
            Location = pozice;
        }
    }
}
