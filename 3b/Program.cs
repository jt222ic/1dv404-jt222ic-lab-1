using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3b
{
    class Program
    {
        static void Main(string[] args)
        {

            Fraction getFrac = new Fraction(1,2,3,4);


            Console.WriteLine("En väldigt onödig funktion som skriver ut {0}", getFrac.ToString());


        }
    }


    class Fraction
    {
        private int _Denominator;
        private int _Numerator;
        private int _Denominator2;
        private int _Numerator2;



        public int Denominator
        {
            get { return _Denominator; }
            set
            {

                if (_Denominator == 0)
                {
                    throw new ArgumentException("måste ha ett tal mer än 0");
                }

                _Denominator = value;
            }
        }

        public int Denominator2
        {
            get { return _Denominator2; }
            set
            {
                if (_Denominator2 == 0)
                {
                    throw new ArgumentException("Måste ha ett tal mer än 0");
                }

                _Denominator2 = value;
            }

        }

        public int Numerator2
        {
            get { return _Numerator2; }
            set
            {



                _Numerator2 = value;
            }

        }

        public int Numerator
        {
            get
            {
                return _Numerator;

            }

            set
            {
                _Numerator = value;
            }
        }

        public Fraction(int denominator, int numerator, int denominator2, int numerator2)
        {
            Denominator = denominator;
            Numerator = numerator;
            Denominator2 = denominator2;
            Numerator2 = denominator2;


        }

        public void add()
        {

            Numerator = (Denominator * Numerator2) + (Denominator2 * Numerator);
            Denominator = Denominator * _Denominator2;
        }


        public void multiply()
        {

            Numerator = Numerator * Numerator2;
            Denominator = Denominator * Denominator2;



        }

        public bool isEqualto()
        {
            int Equalo;
            Equalo = Denominator * Numerator2;
            Numerator = Denominator2 * Numerator;
            if ( Equalo == Numerator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }


    }
}



    






