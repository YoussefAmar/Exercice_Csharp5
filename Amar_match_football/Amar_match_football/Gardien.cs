using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_match_football
{
    class Gardien : Joueur
    {
        public Gardien(Balle laBalle) : base(laBalle)
        {
            positionGet = 0;
        }

        public /*override*/ new void avance()
        {
            if (positionGet < 10)
                Console.WriteLine("Moi gardien, je peux encore prendre la balle avec les mains");
            if (positionGet < 20)
                base.avance();
        }
    }
}
