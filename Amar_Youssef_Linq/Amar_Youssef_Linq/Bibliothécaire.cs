using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_Youssef_Linq
{
    class Bibliothécaire
    {
        public int IdBibliothécaire;
        public int IdLivre;
        public int IdLecteur;
        public string Nom;
        public DateTime Date_Location;

        public Bibliothécaire(int IdBibliothécaire, int IdLivre, int IdLecteur, string Nom, DateTime Date)
        {
            this.IdBibliothécaire = IdBibliothécaire;
            this.IdLivre = IdLivre;
            this.IdLecteur = IdLecteur;
            this.Nom = Nom;
            this.Date_Location = Date;

        }

    }
}
