using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_match_football
{
    class Attaquant : Joueur
    {
        public Attaquant(Balle laBalle) : base(laBalle)
        {
            positionGet = 100;
        }

        public /*override*/ new void avance()
        {
            if (positionGet < 200)
                base.avance();
            if (positionGet < 150)
                Console.WriteLine("Moi attaquant je fais attention au hors-jeu");
        }

        public void MarquerUnBut()
        {
            Console.WriteLine("Bravo, l'attaquant à marquer un but!!!");
        }
    }
}
