using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    internal class Racun
    {
        public string Broj {  get; set; }
        private decimal Stanje { get; set; }
        public Osoba Vlasnik { get; private set; }

        public Racun(string broj, Osoba vlasnik )
        {
            Broj = broj;
             Vlasnik = vlasnik;
             Stanje = 0;
        }
         
        public void PromeniVlasnika(Osoba o)
        {
            this.Vlasnik = o;
        }
        public decimal Uplata(decimal iznos)
        { Stanje += iznos;
            return  Stanje;
        }
        public decimal Isplata(decimal iznos)
        {
            if (iznos > Stanje)
            {
                Console.WriteLine("Nedovoljno sredstava");
                return Stanje;
            }
            Stanje -= iznos;
            return  Stanje;
        }
        public decimal ProveraStanja()
        {
            Console.WriteLine($"Izvrsena je provera stanja za racun{Broj} -{DateTime.Now}");
            return  Stanje;
        }
        public string Opis()
        {
            return $"Broj racuna je {Broj} vlasnik je {Vlasnik.PunoIme} {Vlasnik.TipKorisnika} lice. Stanje na Racunu je {Stanje}";
        }

    }
}
