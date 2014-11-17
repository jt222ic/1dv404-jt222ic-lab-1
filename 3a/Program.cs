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
            string myString;
            string length;
            myString = Console.ReadLine();    
            length = int.Parse(myString.Length.ToString);
                      

            for (int i = 0; i < length.Length/ 2; i++)
            {
                if (myString[i] == myString[i])
                { Console.WriteLine(length); }
                
            }

            
            


            
            

          
        }
    }
}
