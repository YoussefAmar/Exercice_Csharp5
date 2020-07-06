using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_Youssef_Linq
{
    class Program
    {
        static List <Lecteur> lec = new List <Lecteur>();
        static List <Livre> liv = new List <Livre>();
        static List <Bibliothécaire> bibli = new List <Bibliothécaire>();

        static void Main(string[] args)
        {
              void RemplirLecteur()
            {
                lec.Add(new Lecteur(1,"Jean",31));
                lec.Add(new Lecteur(2, "Marie", 12));
                lec.Add(new Lecteur(3, "Marc", 27));
                lec.Add(new Lecteur(4, "Phil", 19));
                lec.Add(new Lecteur(5, "Jeanne", 41));

            }

            void RemplirLivre()
            {
                liv.Add(new Livre(1, 193, new DateTime(1998,11,20),"Jean Dujardin","OSS 117"));
                liv.Add(new Livre(2, 208, new DateTime(1940, 02, 13), "Adolf Hitler", "Mein Kampf"));
                liv.Add(new Livre(3, 590, new DateTime(2000, 12, 29), "Donald Trump", "Mein Kampf"));
                liv.Add(new Livre(4, 60, new DateTime(1000, 03, 12), "Jésus", "Mein Kampf"));
                liv.Add(new Livre(5, 1290, new DateTime(2014, 11, 20), "Marc Lambert", "Le Larousse"));
            }

            void RemplirBibli()
            {
                bibli.Add(new Bibliothécaire(1, 2, 3, "Michelle", new DateTime(2019, 11, 20)));
                bibli.Add(new Bibliothécaire(2, 4, 2, "Michelle", new DateTime(2019, 10, 09)));
                bibli.Add(new Bibliothécaire(3, 5, 5, "Marc", new DateTime(2019, 04, 12)));

            }

            RemplirLecteur();
            RemplirLivre();
            RemplirBibli();

            var r = from l in liv
                    where l.nom is "Mein Kampf"
                    orderby l.Pages
                    select l;
            Console.WriteLine("Livres ayant un 'o' dans leur nom : ");

            foreach (Livre l in r)
            {
                Console.WriteLine(l.IdLivre + " : " + l.nom + " -- " + l.auteur);
            }
            Console.ReadLine();

            var t = from le in lec
                    where le.Age > 20
                    orderby le.Age
                    select le;

            Console.WriteLine("Tris selon l'âge des lecteurs de plus de 20 ans : ");

            foreach(Lecteur le in t)
            {
                Console.WriteLine(le.IdLecteur + " : " + le.Nom + " -- " + le.Age + " ans ");
            }
            Console.ReadLine();


            var f = from le in lec
                    join b in bibli
                    on le.IdLecteur equals b.IdLecteur
                    join v in liv
                    on b.IdLivre equals v.IdLivre

                    select new { Identifiant = "Lecteur : " +le.Nom + " -- " +"Identifiant livre : "+ v.IdLivre + " -- " + v.nom +" -- " +v.Pages + " pages " +" -- " +" Dates de publications : " + v.Date_publication + " Dates location : "+ b.Date_Location};

            Console.WriteLine("Information sur les lecteurs et livrent loués : ");

            foreach (var aa in f)
            {
                Console.WriteLine(aa.Identifiant);
            }
            Console.ReadLine();

        }
    }
}
