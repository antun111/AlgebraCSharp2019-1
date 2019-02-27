using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djeljivi_s_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite prvi broj iz intervala:");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Unesite drugi broj iz intervala:");
                int n = int.Parse(Console.ReadLine());

                if (n < a)
                {
                    throw new Exception("Nepravilan interval.");
                }
                for (int i = a; i < n; i++) ;
                {
                    if (i % 3 == 0)
                    {
                            Console.Write("{0 ", i);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        
        
       
    }
}
