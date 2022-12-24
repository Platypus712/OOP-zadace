//Osoba.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_1
{
    class Osoba
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string OIB { get; set; }

        public Osoba(string ime, string prezime, string oib)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.OIB = oib;
        }
    }
}
