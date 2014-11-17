using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            Console.WriteLine("inmatningen sker här");   
            input = Console.ReadLine();
                  
            int count= 0;
            int countA = 0;    // skapade variabler för att räkna ut för små a och stora A
            

            foreach( char c in input)  // 
            {
                if( c == 'a')          //
                {

                    count+=1; 
                }

                if (c == 'A')
                {
                    countA += 1;
                }

                
                
            }
            Console.WriteLine("antal liten a:{0} antal stor A:{1} inom en sträng", count, countA);
        }
    }

}