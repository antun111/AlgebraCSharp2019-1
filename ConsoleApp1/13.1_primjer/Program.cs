using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1_primjer
{
    public enum RadniDani
    {
        Ponedjeljak = 1,
        Utorak,
        Srijeda,
        Cetvrtak,
        Petak
    }
    public enum Ocjene
    {
        Nedovoljan = 1,
        Dovoljan,
        Dobar,
        Vrlodobar,
        Odlican
    }
    public enum Katovi
    {
        Prizemlje,
        Prvi,
        Drugi,
        Treci,
        Cetvrti
    }
    class Program
    {
        static void Main(string[] args)
        {
            Firma algebra = new Firma("Algebra d.o.o.);
            algebra.Kat = Katovi.Treci;
        }
    }
    class Firma
    {
    private Katovi Kat;
        private string Naziv;
        

        public Firma(string v)
        {
            this.Naziv = v;
        }

        public Katovi Kat { get => kat; set => Kat = value; }

        public string Naziv { get => naziv; set => naziv = value; }

        public override string ToString()
        {
            string kojiKat = "";
            switch ((int)kat)
            {
                case0: kojiKat = "nultom"; break;
                case1: kojiKat = "prvom"; break;
                case2: kojiKat = "drugom"; break;
                case3: kojiKat = "trećem"; break;
                case4: kojiKat = "četvrtom"; break;

            }
            return "I naše ime je " + this.naziv + " i nalazimo se na " + kojiKat + ";
        }
    }
}
