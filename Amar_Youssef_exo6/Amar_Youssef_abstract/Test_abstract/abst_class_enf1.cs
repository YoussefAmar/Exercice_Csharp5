using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_abstract
{
    public abstract class Abst_class_enf1 : abst_class
    {

        public override void Methode1()
        {
            Console.WriteLine("Methode 1 override");
        }

        public abstract override void Methode2();

    }
 }
 


    
   
