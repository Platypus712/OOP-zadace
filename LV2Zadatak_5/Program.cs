using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2Zadatak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 154.5;

            int minute = (int)x / 60;
            int sekunde = (int)x - minute * 60;
            double stotinke = (x - (double)minute * 60 - (double)sekunde) * 100;

            Console.WriteLine("Minute: {0}, sekunde: {1}, stotinke: {2}", minute, sekunde, stotinke);
        }
    }
}
