using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_match_football
{
    class Entraineur
    {
        private Joueur[] lesJoueurs;
        public Entraineur(Joueur[] lesJoueurs)
        {
            this.lesJoueurs = lesJoueurs;
        }

        public void panique()
        {
            Console.WriteLine("C'est la panique");
            for (int i = 0; i < lesJoueurs.Length; i++)
                lesJoueurs[i].avance();
        }
    }
}
