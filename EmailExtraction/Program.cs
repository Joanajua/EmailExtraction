using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace EmailExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int i;
          
            string readText = File.ReadAllText(@"../../sample.txt");
           

           for (i=0; i<=readText.Length-13; i++)
            {
               
                var subStr = readText.Substring(i, 13);
                string domain = "@softwire.com";
                if (readText.Substring(i, 13) == domain)
                {
                    counter++;
                    Console.WriteLine(subStr);
                    Console.WriteLine(counter);
                }
                
            }
            Console.WriteLine("i is " + i);

            Console.WriteLine(counter);
            Console.ReadLine();

        }



    }
}
