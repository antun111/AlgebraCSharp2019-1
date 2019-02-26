using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_prvih_100_brojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suma prvih 100
            Console.WriteLine("\n\nSuma prvih 100");
            int suma = 0;
            for (int i =0; i < 5; i++)
            {
                Console.Write("{0} ", suma += i);
            }
            Console.ReadKey();
        }
    }
}
