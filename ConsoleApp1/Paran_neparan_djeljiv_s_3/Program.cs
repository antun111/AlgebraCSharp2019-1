using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paran_neparan_djeljiv_s_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj:");
            int a = 0;
                try
                {
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                Console.WriteLine("Broj je paran.");
                }
                {
                if (a % 3 == 0)
                Console.WriteLine("Broj je djeljiv sa 3.");
                }
                else
               
                {
                Console.WriteLine("Broj {0} nije djeljiv sa 3, ostatak je {1}.", a, (a % 3));
                }
                catch (FormatException e)
                {
                Console.WriteLine("Provjeri je li unešen broj?" + e.ToString());
                }

            }
        }
    }
}
