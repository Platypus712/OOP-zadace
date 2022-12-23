//Televizor.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV8Zadatak_4
{
    class Televizor
    {
        public string stanje { get; set; }
        public int trenutniKanal { get; set; }
        public int glasnoca { get; set; }
        private const int brojKanala = 10;
        private const int minGlasnoca = 0;
        private const int maxGlasnoca = 100;

        public Televizor(string stanje, int trenutni_kanal, int glasnoca)
        {
            this.stanje = stanje;
            this.trenutniKanal = trenutni_kanal;
            this.glasnoca = glasnoca;
        }

        public void prethodniKanal()
        {
            if (trenutniKanal == 1)
            {
                trenutniKanal = brojKanala; 
            }
            else
            {
                trenutniKanal--;
            }
        }
        
        public void sljedeciKanal()
        {
            if (trenutniKanal >= brojKanala)
            {
                trenutniKanal = 1; 
            }
            else
            {
                trenutniKanal++;
            }
        }
        
        public void povecajGlasnocu()
        {
            if (glasnoca < maxGlasnoca)
            {
                glasnoca++;
            }
            else
            {
                glasnoca = 0;
            }
        }
        
        public void smanjiGlasnocu()
        {
            if (glasnoca <= maxGlasnoca)
            {
                glasnoca--;
            }
            else
            {
                glasnoca = minGlasnoca;
            }
        }
        
        public int ispisiTrenutniKanal()
        {
            return trenutniKanal; 
        }
        
        public int ispisiTrenutnuGlasnocu()
        {
            return glasnoca; 
        }
    }
}
