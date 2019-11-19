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
            //int length;
            // 
            // {
            //if (input.Substring(i, 13) == '@softwire.com')

            //    counter = counter + 1;

            //  }
            //print (counter);
            //  public static string ReadAllText(string path);
            string readText = File.ReadAllText(@"../../sample.txt");
           // string softwire


           for (i=0; i<=readText.Length-13; i++)
            {
                // readText.indexOf();
                //readText.Length > 0 && readText.Length <= 12
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

          //  Console.WriteLine(readText.Length);
            Console.WriteLine(counter);
            Console.ReadLine();

        }



    }
}
