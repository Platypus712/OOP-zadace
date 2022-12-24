//KucniLjubimac.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_3
{
    class KucniLjubimac : Pas
    {
        public string imeVlasnika { get; set; }
        public string prezimeVlasnika { get; set; }
        
        public KucniLjubimac(string tezina, string boja, string pasmina, string ime_vlasnika, string prezime_vlasnika) 
            :base(tezina, boja, pasmina)
        {
            this.imeVlasnika = ime_vlasnika;
            this.prezimeVlasnika = prezime_vlasnika;
        }
    }
}
