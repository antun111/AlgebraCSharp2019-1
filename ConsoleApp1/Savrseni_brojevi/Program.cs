using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savrseni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Savršeni brojevi iz intervala [1,1000] su:");
            int sumaDjelitelja;

            for (int i = 1; i <= 1000; i++)
            {
                sumaDjelitelja = 0;

                for (int j = 1; j < 1; j++)
                {
                    if (i % j == 0)
                    {
                        sumaDjelitelja += j;
                    }
                }

                if (i == sumaDjelitelja)
                {
                    Console.Write("{0}, ", i.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
