using System;

namespace PocetPrestupnychRoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok1;
            int rok2;

            int pocetRoku = 0;

            Console.WriteLine("Zadejte 1. rok");
            rok1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zadejte 2. rok");
            rok2 = Convert.ToInt32(Console.ReadLine());

            for (int rok = rok1; rok <= rok2; rok++)
            {
                /*
                 * Rok je přestupný tehdy, pokud je bezezbytku dělitelný 4 
                 * a zároveň není dělitelný 100 nebo je bezezbytku dělitelný 400 
                 */
                if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
                    pocetRoku++;                 
            }

            Console.WriteLine("Počet přestupných roků mezi roky {0} a {1} je {2}.", rok1, rok2, pocetRoku);
            Console.ReadKey(true);
        }
    }
}
