//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV8Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Nikola", "je super", "77220395");
            
            Console.WriteLine("Ime osobe: {0}", osoba.ime);
            Console.WriteLine("Prezime osobe: {0}", osoba.prezime);
            Console.WriteLine("OIB osobe: {0}", osoba.OIB);

            Racun racun = new Racun(osoba, 12345262, 121421421);

            Console.WriteLine("\nPodaci vlasnika računa: {0}", racun.podaciVlasnika.ime);
            Console.WriteLine("Broj računa: {0}", racun.brojRacuna);
            Console.WriteLine("Stanje računa: {0}", racun.stanjeRacuna);
        }
    }
}
