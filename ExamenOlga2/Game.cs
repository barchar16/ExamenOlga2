using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ExamenOlga2
{
    public partial class Game : Form
    {
        int seconds = 30;
        int punctuation = 0;
        int x, y;
        private int bolasCount = 7;
        private Boolean play = false;
        //private Image[] GokuLeft;
        //private Image[] GokuRight;
        //private Image[] GokuAttack;
        Random random = new Random();
        ArrayList bolas = new ArrayList();
        private string NameGamer;

        public Game()
        {
            //GokuLeft = GenerateImages.GenerarImatges(Properties.Resources.GokuFull, 59, 71, 4, 1);
            //GokuRight = GenerateImages.GenerarImatges(Properties.Resources.GokuFull, 59, 71, 4, 1);
            //GokuAttack = GenerateImages.GenerarImatges(Properties.Resources.GokuFull, 50, 84, 0, 0);
            loadmenu();
            CreateBolas();
            InitializeComponent();
        }
        public Game(string name)
        {
            InitializeComponent();
            loadmenu();
            CreateBolas();
            NameGamer = name;
        }
        public void CreateBolas()
        {
            for (int i = 1; i < 8; i++)
            {

                int b1 = 410;
                int randomNumber = random.Next(1, 500);
                int b2 = randomNumber;
                bola aa = new bola(i);
                aa.Location = new Point(b2, b1);
                bolas.Add(aa);
            }
            for (int i = 0; i < bolas.Count; i++)
            {
                Controls.Add((bola)bolas[i]);
            }
        }
        public void timer_Cronometre()
        {
            seconds--;
            cronometre.Text = "Time left: " + seconds + " seconds";
            if (seconds == 0)
            {
                timer1.Stop();
                FinalPunctuation FP = new FinalPunctuation(NameGamer, punctuation, false);
                FP.Show();
                this.Close();
            }

        }

        public void interseccioBolas()
        {
            for (int p = 0; p < bolas.Count; p++)
            {
                bola b = (bola)bolas[p];
                if (goku.Bounds.IntersectsWith(b.Bounds))
                {
                    punctuation = punctuation + b.Puntuacio;
                    Controls.Remove(b);
                    bolas.Remove(b);
                    bolasCount--;
                }
                if (bolasCount == 0)
                {
                    timer1.Stop();
                    FinalPunctuation FP = new FinalPunctuation(NameGamer, punctuation, true);
                    FP.Show();
                    this.Close();
                }
                
            }
        }

        private void loadmenu()
        {
            MenuStrip menu = new MenuStrip();
            this.Controls.Add(menu);
            ToolStripMenuItem menuItem;

            string[] options = new string[] { "Play Game!", "Pause", "Punctuations", "Exit" };
            foreach (string opcio in options)
            {
                menuItem = new ToolStripMenuItem(opcio, null, childClick);
                menu.Items.Add(menuItem);
                SubMenu(menuItem, opcio);
            }

        }
        public void SubMenu(ToolStripMenuItem MnuItems, string var)
        {
            if (var == "Punctuations")
            {
                string[] row = new string[] { "Open punctuation" };
                foreach (string rw in row)
                {
                    ToolStripMenuItem SSMenu = new ToolStripMenuItem(rw, null, childClick);
                    // SubMenu(SSMenu,rw);  I have included this piece of code to add a Sub-Menu to the New Menu
                    MnuItems.DropDownItems.Add(SSMenu);
                }
            }
        }

        //menú child click
        public void childClick(object sender, System.EventArgs e)
        {
            if (sender.ToString().Equals("Play Game!"))
            {
                play = true;
                timer1.Start();
            }
            else if (sender.ToString().Equals("Pause"))
            {
                play = false;
                timer1.Stop();
            }
            else if (sender.ToString().Equals("Open punctuation"))
            {

            }
            else if (sender.ToString().Equals("Exit"))
            {
                Application.Exit();
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_Cronometre();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            x = goku.Location.X;
            y = goku.Location.Y;
            
                if (keyData == Keys.Up && play == true)
                {
                    for (int o = 0; o < 45; o++)
                    {
                        Thread.Sleep(10);
                        y = y - 5;
                        goku.Location = new Point(x, y);
                    }
                    for (int o = 0; o < 45; o++)
                    {
                        Thread.Sleep(10);
                        y = y + 5;
                        goku.Location = new Point(x, y);
                    }

                }
                if (keyData == Keys.Right && play == true)
                {
                    if (x + 25 > 0 && x + 25 < 526) { x = x + 25; }

                }
                if (keyData == Keys.Left && play == true)
                {
                    if (x - 25 > 0 && x - 25 < 526) { x = x - 25; }

                }
                if (keyData == Keys.Down && play == true)
                {
                    interseccioBolas();
                }
                if (keyData == Keys.Space && play == true)
                {

                }
            
            if (keyData == Keys.Escape)
                {
                    timer1.Stop();
                    FinalPunctuation FP = new FinalPunctuation(NameGamer, punctuation, false);
                    FP.Show();
                    this.Close();
                }



            goku.Location = new Point(x, y);

            return true;

        }
    }
}