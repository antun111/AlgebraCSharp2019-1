﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._1_17_manipulacija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9.1.1. Znak u rijeci");
            string recenica = "Danas je suncan dan, zato vam dobar dan!";
            string rijec = "dan";
            char slovo = 'n';

            int brojac = 0;
            for (int i = 0; i < recenica.Length; i++)
            {
                if (recenica[i] == slovo)
                {
                    brojac++;
                }
            }

            Console.WriteLine("9.1.1. Znak u rijeci");
            Console.WriteLine("Znak {0} se u recenici '{1}' pojavljuje {2} puta.", slovo, recenica, brojac);

            //recenica = recenica.ToLower();
            string[] nizrijeci = recenica.Split(' ',',','!');
            brojac = 0;
            for (int i = 0; i < nizrijeci.Length; i++)
            {
                if (nizrijeci[i].ToLower() == rijec.ToLower())
                {
                    brojac++;
                }
            }

            Console.WriteLine("9.1.2. Rijeci u recenici");
            Console.WriteLine("Rijec {0} se u recenici '{1}' pojavljuje {2} puta.", rijec, recenica, brojac);

            Console.WriteLine("9.1.4. Rijeci u novi red");
            for (int i = 0; i < nizrijeci.Length; i++)
            {
                Console.WriteLine(nizrijeci[i]);
            }
            //nizrijeci.
            nizrijeci = recenica.Split(' ');
            Console.WriteLine("Recenica '{0}' ima {1} rijeci.", recenica, nizrijeci.Length);


            Console.ReadKey();
        }
    }
}
