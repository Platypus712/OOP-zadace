using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double polumjer;
            double opsegKruga;

            Console.WriteLine("Unesite vrijednost za polumjer kruga: ");
            double.TryParse(Console.ReadLine(), out polumjer);

            opsegKruga = 2 * polumjer * Math.PI;

            if (polumjer <= 0)
            {
                Console.WriteLine("Unesena vrijednost mora biti pozitivna i različita od nule!!!");
            }
            else
            {
                Console.WriteLine("Opseg kruga iznosi: {0}", opsegKruga);
            }
        }
    }
}
