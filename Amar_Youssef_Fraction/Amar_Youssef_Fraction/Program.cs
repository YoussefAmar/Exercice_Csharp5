using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_Youssef_Fraction
{
    class Program
    {
        static void Main(string[] args)
        { 

            int d = 3;
            Fraction f = new Fraction(3,4);
            Fraction g = f;

            Console.WriteLine("{0}*{1} = {2} ou {3}", d, f.ToString(), (Fraction)d * g, (d*g).ToString());

            //d*((int)g) me donne 0 comme valeur, même avec la bonne méthode associée

            Console.ReadLine();

        }
    }
}
