using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4Zadatak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int polumjer;

            Console.WriteLine("Unesite vrijednost za polumjer kružnice: ");
            int.TryParse(Console.ReadLine(), out polumjer);

            double povrsina = 2 * polumjer * Math.PI;

            if (polumjer <= 0)
            {
                Console.WriteLine("Krivi unos vrijednosti!");
            }
            else
            {
                Console.WriteLine("Opseg kružnice iznosi: {0}", (double)polumjer);
            }


        }
    }
}
