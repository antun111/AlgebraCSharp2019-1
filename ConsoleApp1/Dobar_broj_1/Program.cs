using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobar_broj_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj:");
            int a = int.Parse(Console.ReadLine());

            if (a % 5 == 0 || a % 3 == 0)
            {
                Console.WriteLine("Broj je dobar.");
            }
            else
            {
                Console.WriteLine("Broj nije dobar.");
            }
            Console.ReadKey();
        }
    }
}
