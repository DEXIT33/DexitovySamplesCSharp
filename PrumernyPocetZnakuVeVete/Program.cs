using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrumernyPocetZnakuVeVete
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            Console.WriteLine("Napište větu:");
            text = Console.ReadLine();

            double pocetZnaku = 0;
            double pocetSlov = 1;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                    pocetZnaku++;
                else
                    pocetSlov++;
                    
            }

            Console.WriteLine("V každém slově věty je průměrně {0} znaků", pocetZnaku / pocetSlov);

            Console.ReadKey(true);
        }
    }
}
