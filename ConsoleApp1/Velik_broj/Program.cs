using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velik_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj:");
            int a = int.Parse(Console.ReadLine());

            if (a > 999)
            {
                Console.WriteLine("Broj je velik.");
            }
            else
            {
                Console.WriteLine("Broj nije velik.");
            }
            Console.ReadKey();
          
            
        }
    }
}
