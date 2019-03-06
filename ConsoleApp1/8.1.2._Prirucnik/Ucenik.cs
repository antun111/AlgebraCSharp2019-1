using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2._Prirucnik
{
    class Ucenik
    {
        public System.DateTime DatumNastanka;
        public string Ime = "";
        public string Prezime = "";
        public int OcjenaIzMatematike = 0;
        public int OcjenaIzEngleskog = 0;
        public int OcjenaIzBiologije = 0;

        public Ucenik()
        {
            this.DatumNastanka = DateTime.Now;
        }

        public Ucenik(string v)
        {
            this.Ime = v;
        }
        public Ucenik(string v, string prez)
        {
            this.Ime = v;
            this.Prezime = prez;
        }

        internal double Prosjek()
        {
            double prosjek = 0;
            prosjek = (double)(OcjenaIzMatematike + OcjenaIzEngleskog + OcjenaIzBiologije) / 3;

            return prosjek;
            //throw new NotOmplementedException();
        }
        public override string ToString()
        {
            return "Moje ime je " + this.Ime + " a moj prosjek je: " + this.Prosjek();
        }
    }
}
