//MotornoVozilo.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_2
{
    class MotornoVozilo
    {
        public string snagaMotora { get; set; }
        public string vrstaGoriva { get; set; }

        public MotornoVozilo(string snaga_motora, string vrsta_goriva)
        {
            this.snagaMotora = snaga_motora;
            this.vrstaGoriva = vrsta_goriva;
        }
    }
}
