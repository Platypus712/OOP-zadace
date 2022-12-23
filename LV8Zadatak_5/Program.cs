//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV8Zadatak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Nikola", "Pustišek", "VVG", "Informacijski sustavi", "nikolapustisek@gmail.com", "098/913-6305");
            Console.WriteLine("Podaci za traženu osobu: \nIme: {0}\nPrezime: {1}" +
                "\nNaziv visokoškolske ustanove: {2}\nNaziv studija: {3}\nEmail: {4}\nBroj telefona: {5}",
                student.ime, student.prezime, student.nazivUstanove, student.nazivStudija, student.email, student.brojTelefona);
        }
    }
}
