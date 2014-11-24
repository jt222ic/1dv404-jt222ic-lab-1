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

            do
            {
                int a = 0;
                int b = 0;
                int c = 0;
                int d = 0;
                Fraction getfrac = null;

                try
                {
                    Console.Clear();

                    Menu();

                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 0:
                            return;
                        case 1:
                        case 2:
                        case 3:
                            a = ReadFractionValue("Skriv in den första täljaren: ");
                            b = ReadFractionValue("Skriv in den första nämnaren: ");
                            c = ReadFractionValue("Skriv in den andra täljaren: ");
                            d = ReadFractionValue("Skriv in den andra nämnaren: ");
                            getfrac = new Fraction(a, b, c, d);
                            break;
                        case 4:
                            a = ReadFractionValue("Skriv in täljaren: ");
                            b = ReadFractionValue("Skriv in nämnaren: ");
                            getfrac = new Fraction(a, b);
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("En väldigt onödig funktion som skriver ut {0}", getfrac.ToString());
                            Console.ResetColor();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();

                    }
                    if (choice == 1)
                    {
                        getfrac.add();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0}/{1} + {2}/{3} = {4}", a, b, c, d, getfrac.ToString());
                        Console.ResetColor();
                    }
                    else if (choice == 2)
                    {
                        getfrac.multiply();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0}/{1} * {2}/{3} = {4}", a, b, c, d, getfrac.ToString());
                        Console.ResetColor();
                    }
                    else if (choice == 3)
                    {
                        if (getfrac.isEqualto() == true)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("De angivna bråken är jämna!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("De angivna bråken är inte jämna.");
                            Console.ResetColor();
                        }

                    }



                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("FEL! Se till så att siffran är inom intervallet och att du inte skriver in bokstäver.");
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("========================================================");
                Console.WriteLine("= Klicka valfri tangent för att göra om - ESC avslutar =");
                Console.WriteLine("========================================================");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }


        static void Menu()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("===================================================");
            Console.WriteLine("=                                                 =");
            Console.WriteLine("=                    Bråk tal                     =");
            Console.WriteLine("=                                                 =");
            Console.WriteLine("===================================================");
            Console.ResetColor();
            Console.WriteLine("\n 0.Avsluta.\n\n 1. Addera 2 bråktal\n\n 2. Multiplicera 2 bråktal\n\n 3. Jämnaföra 2 bråktal\n\n 4. Bara skriva in ett bråktal och få det utskrivet");
            Console.WriteLine("===================================================");
            Console.WriteLine();
            Console.ResetColor();
        }

        static int ReadFractionValue(string promt)
        {
            int value;

            while (true)
            {
                Console.Write(promt);
                string input = Console.ReadLine();
                try
                {
                    value = int.Parse(input);
                    return value;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("FEL! {0} är inte i önskat format, var vänlig och ange ett tal.", input);
                    Console.ResetColor();
                }
            }


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

        public Fraction(int numerator, int denominator)
            : this(numerator, denominator, 1, 1)
        {

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



    






