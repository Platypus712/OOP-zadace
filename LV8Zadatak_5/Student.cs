//Student.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV8Zadatak_5
{
    class Student
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string nazivUstanove { get; set; }
        public string nazivStudija { get; set; }
        public string email { get; set; }
        public string brojTelefona { get; set; }

        public Student(string ime, string prezime, string naziv_ustanove, string naziv_studija, string email, string broj_telefona)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.nazivUstanove = naziv_ustanove;
            this.nazivStudija = naziv_studija;
            this.email = email;
            this.brojTelefona = broj_telefona;
        }
    }
}
