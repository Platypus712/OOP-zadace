//NovaOsoba.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV8Zadatak_3
{
    class NovaOsoba
    {
        private string ime { get; set; }
        private string prezime { get; set; }
        private int danRodenja { get; set; }
        private int mjesecRodenja { get; set; }
        private int godinaRodenja { get; set; }

        public NovaOsoba(string ime, string prezime, int dan_rodenja, int mjesec_rodenja, int godina_rodenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.danRodenja = dan_rodenja;
            this.mjesecRodenja = mjesec_rodenja;
            this.godinaRodenja = godina_rodenja;
        }

        public int starost()
        {
            return DateTime.Now.Year - godinaRodenja;
        }
    }
}
