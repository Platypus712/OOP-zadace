//AlkoholnoPice.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_4
{
    class AlkoholnoPice : Pice
    {
        public string postotakAlkohola { get; set; }

        public AlkoholnoPice(string naziv_pica, int velicina_pakiranja, string boja, string cijena, string postotak_alkohola) 
            :base(naziv_pica, velicina_pakiranja, boja, cijena)
        {
            this.postotakAlkohola = postotak_alkohola;
        }
    }
}
