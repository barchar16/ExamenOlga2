using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOlga2
{
    class Jugador
    {
        private int puntuacio;
        private string nom;

        public Jugador( string nom,int puntuacio)
        {
            Puntuacio = puntuacio;
            Nom = nom;
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

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }
    }
}
