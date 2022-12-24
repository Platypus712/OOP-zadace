//OsobnoVozilo.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_2
{
    class OsobnoVozilo : MotornoVozilo
    {
        public int brojSjedala { get; set; }
        public int brojVrata { get; set; }
        public string bojaVozila { get; set; }

        public OsobnoVozilo(string snaga_motora, string vrsta_goriva, int broj_sjedala, int broj_vrata, string boja_vozila)
            : base(snaga_motora, vrsta_goriva)
        {
            this.brojSjedala = broj_sjedala;
            this.brojVrata = broj_vrata;
            this.bojaVozila = boja_vozila;
        } 
    }
}
