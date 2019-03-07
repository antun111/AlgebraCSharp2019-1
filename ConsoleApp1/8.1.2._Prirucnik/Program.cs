using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2._Prirucnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Što je to nastavnik?");
            Console.WriteLine(Nastavnik.Opis());
            Console.WriteLine("Koji je koeficijent nastavnika?");
            Console.WriteLine(Nastavnik.Koeficijent());

            Nastavnik n1 = new Nastavnik();
            // ne možemo postaviti READ ONLY property
            // n1.Ime = "Claudije";

            // ispis može
            Console.WriteLine("Njegovo ime je " + n1.Ime);

            // OIB možemo postaviti
            n1.Oib = 123345;

            Nastavnik.Koeficijent

            // Ne dozvoljava čitanje oiba
            // Console.WriteLine("Njegov OIB je " + n1.Oib);

            // Ispiši dio OIBa
            Console.WriteLine("Njegov OIB je " + n1.PartialOib + "*********");


            //Instanciraj novi objekt klase Ucenik
            Ucenik uc1 = new Ucenik();

            //Inicijalizacija objekta
            Console.WriteLine("Unesite ime učenika: ");
            uc1.Ime1 = Console.ReadLine();

            Console.WriteLine("Unesite prezime učenika: ");
            uc1.Prezime = Console.ReadLine();

            Console.Write("Unesite ocjenu iz matematike: ");
            uc1.OcjenaIzMatematike = int.Parse(Console.ReadLine());

            Console.Write("Unesite ocjenu iz engleskog: ");
            uc1.OcjenaIzEngleskog = int.Parse(Console.ReadLine());

            Console.Write("Unesite ocjenu iz biologije: ");
            uc1.OcjenaIzBiologije = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Prosjek je: " + uc1.Prosjek());

            //Poziv metode objekta
            Console.WriteLine("Prosjek je " + uc1.Prosjek() + ".");

            //2. objekt instanciran je pomoću 2. konstruktora
            Ucenik uc2 = new Ucenik("Perica");
            Console.WriteLine(uc2.Prezime + " " + uc2.Ime1);

            Console.WriteLine("Ime učenika je " + uc1.Ime1 + " i " + uc2.Ime1);

            //List<Ucenik> ucenici = new List<Ucenik>(); // moze i ovako
            List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2 };
            ucenici.Add(uc1);
            ucenici.Add(uc2);

            
            Console.WriteLine("\nNastavnici");
            List<Nastavnik> nastavnici = new List<Nastavnik>();

            foreach (var item in nastavnici)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
