using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenOlga2
{
    public partial class FinalPunctuation : Form
    {
        private int punctuation;
        private Boolean win;
        private string name;
        Graphics gr;
        public FinalPunctuation(string jugadorName, int points, Boolean wins)
        {
            InitializeComponent();
            Jugador jug = new Jugador(jugadorName, points);
            name = jugadorName;
            punctuation = points;
            win = wins;
            label1.Text = "Gamer name : " + jug.Nom + ". Punctuation: " + jug.Puntuacio;
        }
        public FinalPunctuation()
        {
            InitializeComponent();
        }

        private void FinalPunctuation_Paint(object sender, PaintEventArgs e)
        {
            if (win == false)
            {
                Brush brush = new System.Drawing.SolidBrush(Color.Red);
                Font font = new System.Drawing.Font("Buxton Sketch", 40, FontStyle.Bold);
                gr.DrawString("GAME OVER", font, brush, 25, 25);
            }
            else
            {
                Brush brush = new System.Drawing.SolidBrush(Color.Red);
                Font font = new System.Drawing.Font("Buxton Sketch", 40, FontStyle.Bold);
                gr.DrawString("WIN!", font, brush, 25, 25);
            }
        }

        private void FinalPunctuation_Load(object sender, EventArgs e)
        {
            gr = this.CreateGraphics();
        }
    }
}
