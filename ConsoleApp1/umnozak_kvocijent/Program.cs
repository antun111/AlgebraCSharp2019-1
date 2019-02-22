using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umnozak_kvocijent
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Unesi 1. broj");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi 2. broj");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("umnozak je:{0}", a*b);
            Console.WriteLine("kvocijent je:{0}", (decimal)a / (decimal)b);
            Console.ReadLine();
        }
    }
}
