namespace Patnáctka
{
    public partial class Form1 : Form
    {
        Policko[,] polickos; 
        public Form1(bool jeToLisak = false)
        {
            InitializeComponent();
            if (jeToLisak)
            {
                VytvorLisaka();
            }
            else
                VytvorPatnactku();
        }

        private void VytvorLisaka()
        {
            throw new NotImplementedException();
        }

        private void VytvorPatnactku()
        {
            Image obrazek = Image.FromFile("C:/Users/tovis/OneDrive/Desktop/balin400.png");
            polickos = new Policko[4,4];
            int pocitadlo = 0;
            for (int i = 0; i < polickos.GetLength(0); i++)
            {
                for (int j = 0; j < polickos.GetLength(1); j++)
                {
                    if (polickos.Length - 1 == pocitadlo)
                        continue;
                    polickos[i, j] = new Policko(
                        pocitadlo,
                        obrazek,
                        new Point(j, i)
                        );

                    panel1.Controls.Add(polickos[i, j]);
                    pocitadlo++;
                    polickos[i, j].OnPolickoClick += OnPolickoKlik;
                }
            }
        }

        private void OnPolickoKlik(Policko policko)
        {
            //zjisteni zda ma souseda prazdne policko a kontrola vyhry a takovyhle ty mrdky a tak poradi a ja nevim presunuti
            if (AhojJaJsemTvujSoused(policko.X, policko.Y - 1))
            {
                ProhodPolicka(policko, policko.X, policko.Y - 1);
            }
            else if(AhojJaJsemTvujSoused(policko.X, policko.Y + 1))
            {
                ProhodPolicka(policko, policko.X, policko.Y + 1);

            }
            else if(AhojJaJsemTvujSoused(policko.X - 1, policko.Y))
            {
                ProhodPolicka(policko, policko.X - 1, policko.Y);

            }
            else if(AhojJaJsemTvujSoused(policko.X + 1, policko.Y))
            {
                ProhodPolicka(policko, policko.X + 1, policko.Y);
            }


            //wip checkovani vyhry
            int wincheck = 0;
            bool isInOrder = false;
            foreach (var pole in polickos)
            {
                if(pole is not null)
                {
                    if (pole.Poradi == wincheck)
                    {
                        isInOrder = true;
                    }
                    else
                        isInOrder = false;
                }
                wincheck++;            
            }
            if (isInOrder)
                MessageBox.Show("you won lol");
        }

        private void ProhodPolicka(Policko policko, int x, int y)
        {
            polickos[policko.Y, policko.X] = null;
            policko.Location = new Point(x * policko.Width, y * policko.Height);
            polickos[policko.Y, policko.X] = policko;

        }

        public bool AhojJaJsemTvujSoused(int x, int y)
        {
            if (x < polickos.GetLength(1) && y < polickos.GetLength(0) && x >= 0 && y >= 0 && polickos[y, x] is null)
                return true;
            return false;
        }
    }
}