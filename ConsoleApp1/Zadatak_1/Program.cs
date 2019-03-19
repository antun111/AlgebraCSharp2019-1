using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj: ");
            string broj = Console.ReadLine();

            char[] brojArray = broj.ToCharArray();
            Array.Reverse(brojArray);
            Console.WriteLine("Ispis znamenki naopako: ");
            Console.WriteLine(brojArray);

            Console.ReadKey();



        }
    }
}
