//Kamion.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_2
{
    class Kamion : MotornoVozilo
    {
        public int brojKotaca { get; set; }
        public int maxDozvoljenaTezinaTereta { get; set; }

        public Kamion(string snaga_motora, string vrsta_goriva, int broj_kotaca, int max_dozvoljena_tezina_tereta)
            : base(snaga_motora, vrsta_goriva)
        {
            this.brojKotaca = broj_kotaca;
            this.maxDozvoljenaTezinaTereta = max_dozvoljena_tezina_tereta;
        }
    }
}
