using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amar_Youssef_Fraction
{
    class Fraction : ICloneable
    {
        #region attribut
        private int nume;
        private int deno;
        #endregion

        #region accesseur
        public int Nume { get => nume; set => nume = value; }
        public int Deno { get => deno; set => deno = value; }
        #endregion
        //Ressource utilisé
        #region methode
        public Fraction(int nume, int deno)
        {
            if (deno == 0)
                throw new ArgumentOutOfRangeException("Le dénominateur ne peut être nul !");
            else
            {
                this.Nume = nume;
                this.Deno = deno;
            }

            Console.WriteLine("PGCD de {0} / {1} => {2}", this.nume, this.deno, pgcd(this.Nume, this.Deno));
            Console.WriteLine();
        }

        public Fraction(Fraction f)
        {
            this.Nume = f.Nume;
            this.Deno = f.Deno;
        }

        public object Clone()
        {
            return new Fraction(this.Nume, this.Deno);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction(0);
            //Simplification des fractions avant de les additionner
            Simplifie(f1);
            Simplifie(f2);

            if (f1.deno != f2.deno)
            {
                res.nume = f1.nume * f2.deno + f2.nume * f1.deno;
                res.deno = f1.deno * f2.deno;
            }

            if (res.deno == 0)
                throw new ArgumentOutOfRangeException("Le dénominateur ne peut être nul !");

            else
            {
                res.nume = f1.nume + f2.nume;
                res.deno = f1.deno;
            }


            Simplifie(res);
        
            return res;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Nume * f2.Nume, f1.Deno * f2.Deno);
        }

        public static implicit operator Fraction(int i)
        {
            return new Fraction(i, 1);
        }

        public static explicit operator float(Fraction f)
        {
            return (float)f.Nume / f.Deno;
        }
        // Methode pgcd réecrite
        private static int pgcd(int n1, int n2)
        {
            int n_temp = 0;

            if (n1 < 0)
            {
                n1 = -n1;
            }

            if (n2 < 0)
            {
                n2 = -n2;
            }
            
            else if (n1 == 0)
            {
                return n2;
            }

            else
            {
                do
                {

                    if (n1 > n2)
                    {
                        n_temp = n1;
                        n1 = n2;
                        n2 = n_temp;
                    }

                    n_temp = n1;
                    n1 = n2 % n1;
                    n2 = n_temp;
                }

                while (n1 != 0);
            }

            return n2;
        }

        private static Fraction Simplifie(Fraction f)
        {
            if (f.nume == 0)
                return new Fraction(0);
            else
            {
                int div;
                div = pgcd(f.nume, f.deno);
                return new Fraction(f.nume / div, f.deno / div);
            }
        }

        public override string ToString()
        {
            return (Nume + "/" + Deno);
        }

        #endregion
    }
}

