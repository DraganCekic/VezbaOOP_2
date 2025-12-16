using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Racun r = new Racun("170-00001-12", new Osoba("Marko", "Markovic", Osoba.Tip.Fizicko));  

            Console.WriteLine(r.Opis());
            r.Uplata(1000);
            Console.WriteLine(r.ProveraStanja());
            r.Isplata(500);
            Console.WriteLine(r.ProveraStanja());
            r.Vlasnik.PromeniPrezime("Cekic");
            Console.WriteLine(r.Opis());
        }
    }
}
