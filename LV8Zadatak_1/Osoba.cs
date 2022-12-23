//Osoba.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV8Zadatak_1
{
    class Osoba
    {
        //private string _ime;

        //public string ime
        //{ 
        //    get
        //    {
        //        return _ime;
        //    }
        //    set
        //    {
        //        _ime = value;
        //    }
        //}

        public string ime { get; set; }
        public string prezime { get; set; }
        public string OIB { get; set; }

        

        public Osoba(string ime, string prezime, string OIB)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.OIB = OIB;
        }
    }

}
