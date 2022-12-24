//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pas pas = new Pas("25,5kg", "smeđe", "ovčari");
            KucniLjubimac kucniljubimac = new KucniLjubimac("25,5kg", "smeđe", "ovčari", "Nikola", "Pustišek");
            Console.WriteLine("Ispis podataka o psu:");
            Console.WriteLine("Tezina: {0}", pas.tezina);
            Console.WriteLine("Boja: {0}", pas.boja);
            Console.WriteLine("Pasmina: {0}", pas.pasmina);
            Console.WriteLine();
            Console.WriteLine("Ispis podataka o kućnom ljubimcu");
            Console.WriteLine("Tezina: {0}", kucniljubimac.tezina);
            Console.WriteLine("Boja: {0}", kucniljubimac.boja);
            Console.WriteLine("Pasmina: {0}", kucniljubimac.pasmina);
            Console.WriteLine("Ime vlasnika: {0}", kucniljubimac.imeVlasnika);
            Console.WriteLine("Prezime vlasnika: {0}", kucniljubimac.prezimeVlasnika);
        }
    }
}
