﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_intervalu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj u intervalu od 100 do 200:");
            int a = int.Parse(Console.ReadLine());

            if (a >= 100 && a <= 200)
            {
                Console.Write("Broj je u intervalu [100,200].");
            }
            else
            {
                Console.WriteLine("Broj nije u intervalu [100,200].");
            }
            Console.ReadKey();
           
        
        }
    }
}
