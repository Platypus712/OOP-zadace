//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV9Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Nikola", "Pustišek", "26345184651");
            Student student = new Student("Nikola", "Pustišek", "26345184651", "77220395", "Informacijski sustavi", 2022);
            Console.WriteLine("Ispis podataka o osobi");
            Console.WriteLine("Ime osobe: {0}", osoba.ime);
            Console.WriteLine("Prezime osobe: {0}", osoba.prezime);
            Console.WriteLine("OIB osobe: {0}", osoba.OIB);
            Console.WriteLine();
            Console.WriteLine("Ispis podataka o studentu");
            Console.WriteLine("Ime studenta: {0}", student.ime);
            Console.WriteLine("Prezime studenta: {0}", student.prezime);
            Console.WriteLine("OIB studenta: {0}", student.OIB);
            Console.WriteLine("JMBAG studenta: {0}", student.JMBAG);
            Console.WriteLine("Naziv studija studenta: {0}", student.nazivStudija);
            Console.WriteLine("Nastavna godina studenta: {0}", student.nastavnaGodina);

        }
    }
}
