namespace Patnáctka
{
    public partial class Form1 : Form
    {
        Policko[,] polickos;
        int pocetTahu;
        bool jeToLisak;
        public Form1(bool jeToLisak = false)
        {
            InitializeComponent();
            if (jeToLisak)
            {
                VytvorLisaka();
            }
            else
                VytvorPatnactku();
            this.jeToLisak = jeToLisak;
        }

        private void VytvorLisaka()
        {
            Image obrazek = Random.Shared.Next(4) switch
            {
                0 => Image.FromFile("D:Pics/kubin/predator400.png"),
                1 => Image.FromFile("D:Pics/kubin/kuceratroll400.png"),
                2 => Image.FromFile("C:/Users/tovis/OneDrive/Desktop/balin400.png"),
                3 => Image.FromFile("D:Pics/kubin/kubin_art400.jpg"),
                _ => Image.FromFile("D:Pics/kubin/kuceratroll400.png"),
            };
            polickos = new Policko[3, 3];
            int pocitadlo = 0;
            for (int i = 0; i < polickos.GetLength(0); i++)
            {
                for (int j = 0; j < polickos.GetLength(1); j++)
                {
                    if (4 == pocitadlo)
                    {
                        pocitadlo++;
                        continue;
                    }

                    polickos[i, j] = new PolickoL(
                        pocitadlo,
                        obrazek,
                        new Point(j, i)
                        );

                    panel1.Controls.Add(polickos[i, j]);
                    pocitadlo++;
                    polickos[i, j].OnPolickoClick += OnPolickoKlik;
                    polickos[i, j].OnPolickoClick += WinCheck;
                    polickos[i, j].OnPolickoClick += TahyCheck;
                }
            }

            Zamichej();
        }

        private void VytvorPatnactku()
        {
            Image obrazek = Random.Shared.Next(4) switch
            {
                0 => Image.FromFile("D:Pics/kubin/predator400.png"),
                1 => Image.FromFile("D:Pics/kubin/kuceratroll400.png"),
                2 => Image.FromFile("C:/Users/tovis/OneDrive/Desktop/balin400.png"),
                3 => Image.FromFile("D:Pics/kubin/kubin_art400.jpg"),
                _ => Image.FromFile("D:Pics/kubin/kuceratroll400.png"),
            };
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
                    polickos[i, j].OnPolickoClick += WinCheck;
                    polickos[i, j].OnPolickoClick += TahyCheck;
                }
            }

            Zamichej();
        }

        private void TahyCheck(Policko obj)
        {
            pocetTahu++;
            lbTurnCount.Text = "Počet tahů: " + pocetTahu;
        }

        private void Zamichej()
        {
            for (int i = 0; i < 1000; i++)
            {
                OnPolickoKlik(polickos[Random.Shared.Next(polickos.GetLength(1)), Random.Shared.Next(polickos.GetLength(0))]);
            }
        }

        private void OnPolickoKlik(Policko policko)
        {
            //zjisteni zda ma souseda prazdne policko a kontrola vyhry a takovyhle ty mrdky a tak poradi a ja nevim presunuti
            if(policko is not null)
            {
                if (AhojJaJsemTvujSoused(policko.X, policko.Y - 1))
                {
                    ProhodPolicka(policko, policko.X, policko.Y - 1);
                }
                else if (AhojJaJsemTvujSoused(policko.X, policko.Y + 1))
                {
                    ProhodPolicka(policko, policko.X, policko.Y + 1);

                }
                else if (AhojJaJsemTvujSoused(policko.X - 1, policko.Y))
                {
                    ProhodPolicka(policko, policko.X - 1, policko.Y);

                }
                else if (AhojJaJsemTvujSoused(policko.X + 1, policko.Y))
                {
                    ProhodPolicka(policko, policko.X + 1, policko.Y);
                }
            }
        }

        private void WinCheck(Policko unused)
        {
            int wincheck = 0;
            bool isInOrder = true;
            foreach (var policko in polickos)
            {
                if (policko is not null)
                {
                    if(isInOrder)
                    {
                        if (policko.Poradi == wincheck)
                        {
                            isInOrder = true;
                        }
                        else
                        {
                            isInOrder = false;
                        }
                    }
                }
                wincheck++;
            }
            if (isInOrder)
            {
                MessageBox.Show("you won lol");
                if (jeToLisak)
                    DedVseved.SkoreLisak = pocetTahu;
                else
                    DedVseved.SkorePatnatcka = pocetTahu;
                this.Close();
            }
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