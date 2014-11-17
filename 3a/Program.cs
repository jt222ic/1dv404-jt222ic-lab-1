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
            str = Console.ReadLine();
            
            string presentation;
            presentation = str;
            str.Replace(" ","");
            

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);





            for (int p = 1; p < arr[i].length; p++)
            {

                if (arr[0] == arr[i])
                {

                    foreach (char a in arr)
                    {
                        Console.Write(arr[i]);
                        ++i;
                    }
                }
                


            }
        
    }

}

}


//referens   //http://www.softwareandfinance.com/CSharp/Palindrome.html //