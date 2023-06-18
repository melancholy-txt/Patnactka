using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patnáctka
{
    public partial class Policko : UserControl
    {
        private int poradi;
        public int Poradi => poradi;    
        private Image obrazek;

        public int X => Location.X / Width;
        public int Y => Location.Y / Height;    

        private int obrazekX;
        private int obrazekY;

        public Action<Policko> OnPolickoClick;
        private Policko()
        {
            InitializeComponent();
        }
        public Policko(int poradi, Image obrazek, Point pozice) : this()
        {
            this.poradi = poradi;
            this.obrazek = obrazek;

            pozice.X *= Width;
            pozice.Y *= Height;

            this.obrazekX = pozice.X;
            this.obrazekY = pozice.Y;
            Location= pozice;
        }

        private void Policko_MouseClick(object sender, MouseEventArgs e)
        {
            OnPolickoClick?.Invoke(this);
        }

        private void Policko_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(obrazek, new Rectangle(0, 0, Width, Height), obrazekX, obrazekY, Width, Height, GraphicsUnit.Pixel);
        }

        
    }
}
