using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbroj_razlika
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Unesi 1: broj");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi 2. broj");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj je:{0}", a + b);
            Console.WriteLine("Razlika je:{0}", a - b);
            Console.ReadLine();
           
        }
    }
}
