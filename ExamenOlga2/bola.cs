using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace ExamenOlga2
{
    public partial class bola : UserControl
    {
        private int puntuacio;
        ResourceManager rm = Properties.Resources.ResourceManager;
        public bola(int puntuacio)
        {
            InitializeComponent();
            Puntuacio = puntuacio;
            Load_Image(puntuacio);
        }
        public bola()
        {
            InitializeComponent();
        }
        public void Load_Image(int punt)
        {
            if (Puntuacio == 1)
                pictureBox1.Image = (Bitmap)rm.GetObject("bola" + puntuacio);
            if (Puntuacio == 2)
                pictureBox1.Image = (Bitmap)rm.GetObject("bola" + puntuacio);
            if (Puntuacio == 3)
                pictureBox1.Image = (Bitmap)rm.GetObject("bola" + puntuacio);
            if (Puntuacio == 4)
                pictureBox1.Image = (Bitmap)rm.GetObject("bola" + puntuacio);
            if (Puntuacio == 5)
                pictureBox1.Image = (Bitmap)rm.GetObject("bola" + puntuacio);
            if (Puntuacio == 6)
                pictureBox1.Image = (Bitmap)rm.GetObject("bola" + puntuacio);
            if (Puntuacio == 7)
                pictureBox1.Image = (Bitmap)rm.GetObject("bola" + puntuacio);
        }
        public int Puntuacio
        {
            get
            {
                return puntuacio;
            }

            set
            {
                puntuacio = value;
            }
        }
    }
}
