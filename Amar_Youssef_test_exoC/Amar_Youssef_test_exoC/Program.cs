using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_Youssef_test_exoC
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Quantité d'essence dans un voiture normal : ");
            a = Int32.Parse(Console.ReadLine());

            Moteur general = new Moteur(a, 50);

            Moteur vide = new Moteur(50);

            Voiture Henry = new Voiture("Mercedes",general);

            Voiture Phil = new Voiture("Peugeot", general);

            Voiture Jean = new Voiture("Audi", vide);

            Voiture Marc = new Voiture("Golf", general);

            general.essence = a;

            Henry.demarre();

            Phil.demarre();

            Marc.demarre();

            Jean.demarre();

            Console.ReadLine();
            
        }
    }
}
