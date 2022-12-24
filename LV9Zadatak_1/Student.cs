//Student.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_1
{
    class Student : Osoba
    {
        public string JMBAG { get; set; }
        public string nazivStudija { get; set; }
        public int nastavnaGodina { get; set; }

        public Student(string ime, string prezime, string oib, string jmbag, string naziv_studija, int nastavna_godina) : base(ime, prezime, oib)
        {
            this.JMBAG = jmbag;
            this.nazivStudija = naziv_studija;
            this.nastavnaGodina = nastavna_godina;
        }
    }
}
