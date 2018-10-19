using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HraCisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int cislo = random.Next(0, 100 + 1);

            int pokusy = 0;

            while (true)
            {
                pokusy++;

                Console.WriteLine("Pokus číslo {0}", pokusy);

                bool spravneZdano = false;

                int input = 0;

                Console.WriteLine("Zadejte číslo:");

                while (!spravneZdano)
                {
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                        spravneZdano = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Špatně zadaný vstup.");
                    }
                }

                if(input > cislo) Console.WriteLine("Zadané číslo je větší.");
                else if(input < cislo) Console.WriteLine("Zadané číslo je menší.");
                else break;

                Console.WriteLine();
            }

            Console.WriteLine("Vyhrál jsi, číslo bylo {0}, počet pokusů {1}", cislo, pokusy);
            Console.ReadKey(true);
        }
    }
}
