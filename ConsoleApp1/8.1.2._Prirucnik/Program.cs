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
            //Instanciraj novi objekt klase Ucenik
            Ucenik uc1 = new Ucenik();

            //Inicijalizacija objekta
            Console.WriteLine("Unesite ime učenika: ");
            uc1.Ime = Console.ReadLine();
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
            Console.WriteLine(uc2.Prezime + " " + uc2.Ime);

            Console.WriteLine("Ime učenika je " + uc1.Ime + " i " + uc2.Ime);

            //List<Ucenik> ucenici = new List<Ucenik>(); // moze i ovako
            List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2 };
            ucenici.Add(uc1);
            ucenici.Add(uc2);
            foreach (var item in ucenici)
            {
                Console.WriteLine(item.Ime);
            }
            Console.ReadKey();
        }
    }
}
