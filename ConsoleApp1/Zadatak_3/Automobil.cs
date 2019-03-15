using System;

namespace Zadatak_3
{
    internal class Automobil
    {

        private string nazivAutomobila;
        private int godinaProizvodnje;
        private double osnovnaCijena;

        public string NazivAutomobila { get => nazivAutomobila; set => nazivAutomobila = value; }
        public int GodinaProizvodnje { get => godinaProizvodnje; set => godinaProizvodnje = value; }
        public double OsnovnaCijena { get => osnovnaCijena; set => osnovnaCijena = value; }

        public int Starost()
        {
            int godine = DateTime.Now.Year - GodinaProizvodnje;
            return godine;

        }

        public double Cijena()
        {
            double cijena = 0;
            if (this.osnovnaCijena <= 70000)
            {
                cijena = osnovnaCijena * 1.3;
            }
            else if (this.osnovnaCijena < 100000)
            {
                cijena = osnovnaCijena * 1.4;
            }
            else
            {
                cijena = osnovnaCijena * 1.5;
            }
            return cijena;
        }

    }
}