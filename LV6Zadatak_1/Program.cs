using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.WriteLine("Unesite broj: ");
            broj = int.Parse(Console.ReadLine());

            if (broj > 0)
            {
                obrnuto(broj);
            }
            else
            {
                Console.WriteLine("Unesite pozitivni broj!!");
            }
        }

        private static void obrnuto(int broj)
        {
            string stringBroj = broj.ToString();

            for (int i = stringBroj.Length - 1; i >= 0; i--)
            {
                Console.Write(stringBroj[i]);
            }
            Console.WriteLine();
        }
    }
}
