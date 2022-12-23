//Racun.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV8Zadatak_1
{
    class Racun
    {
        public Osoba podaciVlasnika { get; set; }
        public int brojRacuna { get; set; }
        public int stanjeRacuna { get; set; }

        public Racun(Osoba podaci_vlasnika, int broj_racuna, int stanje_racuna)
        {
            this.podaciVlasnika = podaci_vlasnika;
            this.brojRacuna = broj_racuna;
            this.stanjeRacuna = stanje_racuna;
        }
    }
}
