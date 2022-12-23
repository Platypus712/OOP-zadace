//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV8Zadatak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Televizor televizor = new Televizor("ugašeno", 10, 101);
            Console.WriteLine("Početne informacije oko televizora\nStanje: {0}\nTrenutni program: {1}\nTrenutna razina glasnoće: {2}", televizor.stanje, televizor.trenutniKanal, televizor.glasnoca);
            televizor.stanje = "upaljeno";
            televizor.sljedeciKanal();
            televizor.sljedeciKanal();
            televizor.prethodniKanal();
            televizor.prethodniKanal();
            televizor.povecajGlasnocu();
            televizor.smanjiGlasnocu();
            Console.WriteLine();
            Console.WriteLine("Informacije oko televizora nakon promjene\nStanje: {0}\nTrenutni program: {1}\nTrenutna razina glasnoće: {2}", televizor.stanje, televizor.trenutniKanal, televizor.glasnoca);

        }
    }
}
