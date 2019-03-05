using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            Pozdrav("Pero");
            Pozdrav("Pero", "Perić");
            Console.ReadKey();
        }
        static void Pozdrav( String ime)
        {
            Console.WriteLine("Dobar dan, " + ime + "!");
        }

        static void Pozdrav ( String ime, String prezime)
        {
            Console.WriteLine("Dobar dan, " + ime + " " + prezime + "!");
        }
    }
}
