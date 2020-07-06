using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_abstract
{
    public abstract class abst_class
    {
        private int variable1;
        public abst_class()
        {
            variable1 = 1;
        }
        abstract public void Methode1();

        abstract public void Methode2();

         public void Methode3()
        {
            Console.WriteLine("Cette méthode marche partout {0}",variable1);
        }
    }
}
