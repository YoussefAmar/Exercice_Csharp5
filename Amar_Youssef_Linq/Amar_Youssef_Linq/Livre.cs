using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_Youssef_Linq
{
    class Livre
    {
        public int IdLivre;
        public int Pages;
        public DateTime Date_publication;
        public string auteur;
        public string nom;

        public Livre(int IdLivre, int Pages, DateTime Date, string auteur, string Nom)
        {
            this.IdLivre = IdLivre;
            this.Pages = Pages;
            this.Date_publication = Date;
            this.auteur = auteur;
            this.nom = Nom;
        }

    }
}
