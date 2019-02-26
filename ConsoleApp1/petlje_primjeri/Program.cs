using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlje_primjeri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ispis svih brojeva 0,1,2... 99
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0", i);
            }
            Console.WriteLine("");

            //Ispis svih brojeva 16,18,20... 88
            for (int i = 16; i < 89; i+=2)
            {
                Console.Write("{0", i);
            }
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
