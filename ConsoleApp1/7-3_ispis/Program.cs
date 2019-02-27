using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi iz intervala [1,100] djeljivi sa 7, ali ne i sa 3.");

            for (int i = 1; i < 100; i++)
            {
                if (i % 7 == 0 && !(i % 3 == 0))
                {
                    Console.Write("{0} ", i.ToString());
                }
            }
            Console.ReadKey();
        }
        
        
        
    }
}
