//Pice.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_4
{
    class Pice
    {
        public string nazivPica { get; set; }
        public int velicinaPakiranja { get; set; }
        public string boja { get; set; }
        public string cijena { get; set; }

        public Pice(string naziv_pica, int velicina_pakiranja, string boja, string cijena)
        {
            this.nazivPica = naziv_pica;
            this.velicinaPakiranja = velicina_pakiranja;
            this.boja = boja;
            this.cijena = cijena;
        }
    }
}
