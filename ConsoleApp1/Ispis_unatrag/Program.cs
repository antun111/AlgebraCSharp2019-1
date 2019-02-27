using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispis_unatrag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Prirodni brojevi iz intervala [1,10] unatrag su:");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}
