using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_match_football
{
    class Defenseur : Joueur
    {
        public Defenseur(Balle laBalle) : base(laBalle)
        {
            positionGet = 20;
        }

        public /*override*/ new void avance()
        {
            if (positionGet < 100)
                base.avance();
        }
    }
}
