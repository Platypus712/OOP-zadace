using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = 184;
            int jedinice = broj % 10;
            int stotice = broj / 100;
            int desetice = (broj - jedinice - stotice*100) / 10;

            Console.WriteLine("Jedinica: {0}, desetica: {1}, stotica: {2}", jedinice, desetice, stotice);
        }
    }
}
