using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktorijeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim unesite cijeli pozitivni broj.");
            // 5! = 120 (5*4*3*2*1 =120)
            try
            {
                int a = int.Parse(Console.ReadLine());
                if (a <= 0)
                {
                    throw new Exception("Morate unijeti pozitivan broj.");
                }
                if (a >= 20)
                {
                    throw new Exception("Broj je prevelik, rezultat je veći od dimenzije int 2.147.483.647");
                }

                {
                    int fact = 1;
                    for (int i = a; i > 0; i--)
                    {
                        // Console.WriteLine(i);
                        fact *= i;
                    }

                    Console.WriteLine(fact);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
    public class VeciOdDvajstException : Exception
    {
        public VeciOdDvajstException()
        {

        }
        public VeciOdDvajstException(string message)
            : base(message)
        {
            Console.WriteLine("Dodatno custom oajašnjenje klase Negativenumberexception");
        }
        
    }
} 

  
 

