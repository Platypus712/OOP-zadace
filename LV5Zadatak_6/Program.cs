using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5Zadatak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int brojBrojeva;
            string sbrojBrojeva; ;

            while (true)
            {
                Console.WriteLine("Koliko brojeva želite učitati: ");
                sbrojBrojeva = Console.ReadLine();
                int.TryParse(Console.ReadLine(), out brojBrojeva);

                if (brojBrojeva < 0 || brojBrojeva > 15)
                {
                    break;
                }
                //treba pitati profesora
            }
        }
    }
}
