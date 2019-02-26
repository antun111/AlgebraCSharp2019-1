using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobar_broj_2
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
                }
                catch(Exception e)
                {
                Console.WriteLine(Console.ReadLine());
                }
                if (a % 4 == 0 && !(a >= 100))
                {
                Console.WriteLine("Broj je djeljiv sa 4 i nije manji od 100.");
                }
                else
                {
                Console.WriteLine("Broj nije dobar.");
                }
                catch (FormatException e)
                {
                Console.Write("Provjerite je li unešen broj.");
                }
                Console.ReadKey();
        }  
    }
}
