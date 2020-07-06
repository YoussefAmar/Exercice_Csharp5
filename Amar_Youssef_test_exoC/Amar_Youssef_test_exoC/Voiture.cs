using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_Youssef_test_exoC
{
    class Voiture
    {
        string marque = "";
        int numero_chassis = 0;
        string marche = "arrêt";

        Moteur MonMoteur;

        static int cpt_voiture = 0;

        public Voiture(string marque, Moteur MonMoteur)
        {
            cpt_voiture++;
            Console.WriteLine("Voiture numéro : " + cpt_voiture);
             Console.WriteLine("Marque " + marque );
            this.marque = marque;
            this.numero_chassis = 1000 + cpt_voiture;
            this.MonMoteur = MonMoteur;
           
        }

        public void demarre()
        {

            this.marche = "marche";

            Console.WriteLine("Niveau d'essence de la "+marque +" : "+MonMoteur.essence.ToString()+" l");

            if(MonMoteur.essence <= 0)
            {
                this.marche = "arrêt";
            }

            Console.WriteLine("La voiture est en " + marche);

        }

    } 
        
    
}
