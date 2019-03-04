using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1_primjeri
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracija
            int?[] niz = new int?[3];

            //init
            niz[0] = 55;
            niz[2] = null;
            niz[1] = 22;
            try
            {
                for (int i = 0; i < niz.Length; i++)
                {
                    if (niz[i] == null)
                    {
                        throw new Exception("Niz ne sadrži inicijalizirane vrijednosti na indexu " + i);
                    }
                    Console.WriteLine(i + 1 + ": " + niz[i]);
                }
            }
            catch (IndexOutOfRangeException ioorex)
            {
                Console.WriteLine("Pokušali ste dohvatiti nepostojeći član niza. \n" + ioorex.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
