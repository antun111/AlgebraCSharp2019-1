using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priručnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj");
            int a = int.Parse(Console.ReadLine());
            if (a > 10)
            {
                Console.WriteLine("Unesi broj je veći od 10");
            }
            { Console.WriteLine("Uneseni broj NIJE veći od 10");
            }
            Console.ReadKey();
        }
    }
}
