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
           
                var subStr = readText.Substring(readText.IndexOf("@"), 13);
                int indexOfFirstAt = readText.IndexOf("@");
                string modifiedReadText = readText.Substring(indexOfFirstAt + 1);
                readText = modifiedReadText;

                if (subStr.Contains("@softwire.com"))
                {
                    counter = counter + 1;
                    Console.WriteLine(counter);
                }
                
            }

          //  Console.WriteLine(readText.Length);
            Console.WriteLine(counter);
            Console.ReadLine();

        }



    }
}
