using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._1_datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši tekst: ");
            string upisano = Console.ReadLine();

            //Kreiranje handle-a
            FileStream fs1 = new FileStream("Proba.txt", FileMode.Create);

            //Zapisivanje u datoteku
            StreamWriter sw = new StreamWriter(fs1);

            sw.WriteLine(upisano);

            sw.Flush();

            sw.Close();
            fs1.Close();

            //Čitanje datoteke
            FileStream fs2 = new FileStream("Proba.txt", FileMode.Open);

            StreamReader sr = new StreamReader(fs2);

            string procitano = sr.ReadToEnd();          

            sr.Close();
            fs2.Close();

            Console.WriteLine(procitano);
            Console.ReadKey();
        }
    }
}
