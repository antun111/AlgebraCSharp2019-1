using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjer_5_3_1_1_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}.ALGEBRA", (i + 1).ToString());
            }
            Console.ReadKey();
        }
    }
}
