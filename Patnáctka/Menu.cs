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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPatnactka_Click(object sender, EventArgs e)
        {
            var game = new Form1();
            game.ShowDialog();
            lbPatnactkaSkore.Text = "Nejvyšší dosažené skóre: " + DedVseved.SkorePatnatcka;
        }

        private void btnLisak_Click(object sender, EventArgs e)
        {
            var game = new Form1(true);
            game.ShowDialog();
            lbLisakSkore.Text = "Nejvyšší dosažené skóre: " + DedVseved.SkoreLisak;

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vlatne uhm klikas dokud nemas hotovy obraski");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
