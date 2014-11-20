using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3a
{
    class Program
    {
                                                             
        static void Main(string[] args)
        {

            int i = 0;
            
            string str;
            Console.Write("inmatningen sker här :");
            str = Console.ReadLine();
            string mellan;
            
            mellan = str.Replace(" ","");                   // skapar sekvenser 
            

            char[] arr = mellan.ToCharArray();           // skapar char i array men räknas inte som datatypen Array

          
            

           //foreach (char a in arr)              // försöker få fram character a i array 
           //         {
           //             Console.Write(arr[i]);           // räkna ut och läser ut för varje bokstav inom array som jag har inmatat
                      //             ++i;                     
                              //         }
            bool check = false;
           for (int p = 0; p < arr.Length; p++)
           {    
                                                     // går från sista framåt mot den första. första till sista
               if (arr[p] == arr[arr.Length-1-p])        // läser sista och första bokstaven om lika räknas som panoroma
               {
                   Array.Reverse(arr);
                   Console.BackgroundColor = ConsoleColor.Green;
                   
                  check = true;
               }

               else
               {
                   Console.BackgroundColor = ConsoleColor.Red;   // felmeddelandet uppkommer om det inte tillhör panorom.
                   
                   check = false;
                   break;
               }
               

              
           }


            if ( check == true)
            { Console.Write("{0}-----rätt panorm", str); }

            else
            { Console.WriteLine("{0}------detta är Icke!  ", str); }
            
        
    }

}

}


//referens   //http://www.softwareandfinance.com/CSharp/Palindrome.html // inspiration