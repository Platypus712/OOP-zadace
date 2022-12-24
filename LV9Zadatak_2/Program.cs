//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            OsobnoVozilo auto = new OsobnoVozilo("455hp", "Premium unleaded", 5, 4, "yellow");
            Kamion kamion = new Kamion("16000cc","Diesel", 10, 39270);
            Console.WriteLine("Ispis podataka o autu");
            Console.WriteLine("Snaga motora: {0}", auto.snagaMotora);
            Console.WriteLine("Vrsta goriva: {0}", auto.vrstaGoriva);
            Console.WriteLine("Broj sjedala: {0}", auto.brojSjedala);
            Console.WriteLine("Broj vrata: {0}", auto.brojVrata);
            Console.WriteLine("Boja auta: {0}", auto.bojaVozila);
            Console.WriteLine();
            Console.WriteLine("Ispis podataka o kamionu");
            Console.WriteLine("Snaga motora: {0}", kamion.snagaMotora);
            Console.WriteLine("Vrsta goriva: {0}", kamion.vrstaGoriva);
            Console.WriteLine("Broj kotača: {0}", kamion.brojKotaca);
            Console.WriteLine("Maksimalna dozvoljena nosivost (u Kgs): {0}", kamion.maxDozvoljenaTezinaTereta);
        }
    }
}
