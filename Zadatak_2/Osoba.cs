using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
   internal class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string PunoIme { get { return $"{Ime} {Prezime}"; } }
        public Tip TipKorisnika {  get; set; }

        public Osoba(string ime, string prezime, Tip tip)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            TipKorisnika = tip;
        }


        public void PromeniPrezime (string prezime)
        {
            this.Prezime = prezime;
        }

        

    }
    public enum Tip
    {
        Pravno,
        Fizicko
    }
}
