using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2._2_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite podatak tipa DateTime: ");
            DateTime d1 = DateTime.Parse(Console.ReadLine());

            //Ispisujemo datume
            Console.WriteLine("Datum: ");
            Console.WriteLine(d1);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());

            //Ispisujemo vrijeme
            Console.WriteLine("Vrijeme: ");
            Console.WriteLine(d1.ToShortDateString());

            //Ispis dana u tjednu ( 0 = nedjelja )
            Console.WriteLine("Dan u tjednu: ");
            // Ako ne "kastamo", ispisuju se slovima
            Console.WriteLine(d1.DayOfWeek);
            Console.WriteLine((int)d1.DayOfWeek);

            //Korisničko formatiranje
            //Sistemsko vrijeme ispisujemo na preciznost
            //tisućinke sekunde
            Console.WriteLine("Sada je točno: ");
            d1 = DateTime.Now;

            Console.WriteLine(d1.ToString("MMMM, dddd yyyy HH:mm:ss fff"));

            //Koliko dana ima do nove godina
            //1) Kreiramo novi datum za Novu Godinu
            DateTime dNG = new DateTime(2010, 1, 1);

            //2) Oduzimamo tekući datum od datuma Nove Godine
            TimeSpan ts = dNG.Subtract(d1);

            //3) Ispisujemo koliko ima do Nove Godine
            Console.WriteLine("Do Nove Godine ima: ");
            Console.WriteLine("dana: " + ts.Days);
            Console.WriteLine(" i sati: " + ts.Hours);
            Console.WriteLine("To je ukupno sati: " + ts.TotalHours);
            Console.WriteLine("Ili {0} dana, {1} sati, {2} minuta i {3} sekundi.", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);

            //Povećanje datuma
            Console.WriteLine("Danas je izdana potvrda na 6 mjeseci.");
            DateTime DatumIzdavanja = DateTime.Now;
            DateTime DatumIsteka = DatumIzdavanja.AddMonths(6);
            Console.WriteLine("Datum isteka: {0}", DatumIsteka);

            Console.ReadKey();
        }
    }
}
