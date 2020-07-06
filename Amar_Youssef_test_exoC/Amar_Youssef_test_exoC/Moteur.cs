using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_Youssef_test_exoC
{
    class Moteur
    {
       private int Essence = 0;
       private int Puissance;

        public Moteur(int Essence, int Puissance)
        {
            this.Essence = Essence;
            this.Puissance = 50;

        }

        public Moteur(int Puissance)
        {
            this.Essence = 0;
            this.Puissance = 50;
        }

        public int essence
        {

            get { return this.Essence; }


            set
            {

                if (value <= 0)
                    {
                    Essence = 0;
                    }
                else {Essence = value;}

            }
        }
            
    }
}
