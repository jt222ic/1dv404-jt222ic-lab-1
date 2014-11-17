using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int odd= 0;            // variablar 
            int even = 0;
            int zero = 0;
               

            while (true )  // skapar en while sats för att det ska loopar för ConsoleKey " uträkning sker under knapptryck.
            {

                ConsoleKeyInfo input = Console.ReadKey();         // input med tilläg av ConsoleKeyinput -läsa in inmatningen
                
                if (input.Key== ConsoleKey.Enter)    // om inmatningen är lika med Enter så stängs konsolen av
                { break; }

                int number = int.Parse(input.KeyChar.ToString());  // värden som skrivs in som jag har omvandlat från keychar till string sedan int Parse.

                if ( number == 0)    // om värden är lika med noll sker uträkning för 0
                {
                    zero+=1;

                }
                else
                switch (number % 2)     /// uträkning nför jämna och udda

                {

                    case 0: 
                        even +=1;
                        break;
                    case 1:

                        odd +=1;
                        break;
                    }
                    
                Console.WriteLine("zero : {0} even : {1} odd : {2}", zero, even, odd);   // resultaten av uträkningen
                

            }

        }
    }
}
