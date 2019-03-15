using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rijec_kraj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rijeci = new List<string>();         

            while (true)
            {
                Console.WriteLine("Upišite riječ koja počinje slovima A, B ili C: ");
                string rijec = Console.ReadLine();

                if (rijec.ToLower() == "kraj")
                {
                    break;
                }
                else
                {
                    rijeci.Add(rijec);
                }
            }
            List<string> rijeciSaSlovomA = (from rijec in rijeci where rijec.ToLower().StartsWith("a") select rijec).ToList();
            Console.WriteLine();
            Console.Write("Riječi koje počinju sa slovom \"a\" su: ");

            List<string> rijeciSaSlovomB = (from rijec in rijeci where rijec.ToLower().StartsWith("b") select rijec).ToList();
            Console.WriteLine();
            Console.Write("Riječi koje počinju sa slovom \"b\" su: ");

            List<string> rijeciSaSlovomC = (from rijec in rijeci where rijec.ToLower().StartsWith("c") select rijec).ToList();
            Console.WriteLine();
            Console.Write("Riječi koje počinju sa slovom \"c\" su: ");

            foreach (string rijec in rijeci)
            {
                Console.WriteLine(rijec + ",");
            }
            Console.ReadKey();
                                            
                                            


        }
    }
}
