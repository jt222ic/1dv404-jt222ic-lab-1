using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 1c
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;                  // variablar för uträkning
            int nextmax;
            int input;
            
            Console.WriteLine("näst största tal :");    // skriv ut nästa största tal
            input = int.Parse(Console.ReadLine());        // inmatning av inparse

            
            
            max = input;             //   max 'r input  
            nextmax = input;          //  next max = input
            
            for (int i = 0; i < 10; i++ )    //  tog for loop istället för while eftersom jag kian inte hoppa ur while loopåen
            {
                if( i != 0) {
                    input = int.Parse(Console.ReadLine());    // om värden i är inte lika med 0 så ska det påbörja köra igenom loopen-
                }

                if (input > max)         // om inputen är större än max så ska max värden uträknas
                {
                    nextmax = max;
                    max = input;
                }

                if ((input > nextmax && input < max) || nextmax == max)  // kganska förvirrande när input är större och när input är mindre än max
                {                                                        // eller när next max är lika med max ska uträkning för nextma
                    nextmax = input;
                }

                Console.WriteLine("nääst {0}   största tal {1}", nextmax, max);   //utskrivning för next max och max

            }   // refrens

        }
    }
}
