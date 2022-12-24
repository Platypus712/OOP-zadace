//Pas.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_3
{
    class Pas
    {
        public string tezina { get; set; }
        public string boja { get; set; }
        public string pasmina { get; set; }

        public Pas(string tezina, string boja, string pasmina)
        {
            this.tezina = tezina;
            this.boja = boja;
            this.pasmina = pasmina;
        }
    }
}
