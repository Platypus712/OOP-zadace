using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4Zadatak_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int prviBroj;
            int drugiBroj;
            int treciBroj;

            Console.WriteLine("Unesite prvi broj: ");
            int.TryParse(Console.ReadLine(), out prviBroj);
            Console.WriteLine("Unesite drugi broj: ");
            int.TryParse(Console.ReadLine(), out drugiBroj);
            Console.WriteLine("Unesite treci broj: ");
            int.TryParse(Console.ReadLine(), out treciBroj);

            if (prviBroj > drugiBroj && prviBroj > treciBroj)
            {
                Console.WriteLine("Prvi broj je najveći!");
            }
            else if (prviBroj < drugiBroj && drugiBroj > treciBroj)
            {
                Console.WriteLine("Drugi broj je najveći!");
            }
            else
            {
                Console.WriteLine("Treci broj je najveći!");
            }


        }
    }
}
