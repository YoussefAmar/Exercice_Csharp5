using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_match_football
{
    class Program
    {
        static void Main(string[] args)
        {
            Balle uneBalle = new Balle();
            Joueur[] lesJoueurs = new Joueur[3];
            lesJoueurs[0] = new Gardien(uneBalle);
            lesJoueurs[1] = new Defenseur(uneBalle);
            lesJoueurs[2] = new Attaquant(uneBalle);

            Entraineur unEntraineur = new Entraineur(lesJoueurs);
            Console.WriteLine("  d'abord les joueurs   ");

            for (int i = 0; i < lesJoueurs.Length; i++)
                lesJoueurs[i].InteragitBalle();

            Console.WriteLine("     puis l'entraineur");

            for (int i = 0; i < 6; i++)
                unEntraineur.panique();

            ((Attaquant)lesJoueurs[2]).MarquerUnBut();

            Attaquant Marc = new Attaquant(uneBalle);
            Console.WriteLine(Marc.GetType());

            Console.ReadLine();
        }
    }
}
