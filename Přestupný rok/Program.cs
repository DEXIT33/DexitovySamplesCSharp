using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestupny_rok
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Zadejte rok:");

                int rok = Convert.ToInt32(Console.ReadLine());

                //Rok je přestupný tehdy, pokud je bezezbytku dělitelný 4 a zároveň není dělitelný 100 nebo je bezezbytku dělitelný 400
                if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
                    Console.WriteLine("Rok je přestupný");
                else
                    Console.WriteLine("Rok není přestupný");

                Console.WriteLine();
            }           
        }
    }
}
