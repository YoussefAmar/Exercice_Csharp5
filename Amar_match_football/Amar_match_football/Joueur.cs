using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_match_football
{
    class Joueur
    {
        private int posSurLeTerrain;

        private Balle laBalle;

        public Joueur(Balle laBalle)
        {
            this.laBalle = laBalle;
        }

        public /*visual*/ void InteragitBalle()
        {
            Console.WriteLine("Je tape la balle avec le pied");
            laBalle.Bouge();

        }

        public /*virtual*/ void avance()
        {
            Console.WriteLine("La position actuelle du "+this+" est "+ posSurLeTerrain);
            posSurLeTerrain += 20;

        }

        public int positionGet
        {
            get { return posSurLeTerrain; }

            set { posSurLeTerrain = value; }
        }

    }
}
