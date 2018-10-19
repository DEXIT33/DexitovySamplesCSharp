using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5CiselNejvetsiNejmensi
{
    class Program
    {
        static void Main(string[] args)
        {
            double nejmensi = int.MaxValue;
            double nejvetsi = int.MinValue;
            double soucet = 0;

            Console.WriteLine("Zadejte 5 čísel:");

            for (int i = 0; i < 5; i++)
            {
                int cislo = Convert.ToInt32(Console.ReadLine());

                if (cislo < nejmensi)
                    nejmensi = cislo;
                if (cislo > nejvetsi)
                    nejvetsi = cislo;

                soucet += cislo;
            }

            double prumer = soucet / 5;

            Console.WriteLine("======================================================================");

            Console.WriteLine("Nejmenší: {0}\nNejvětší: {1}\nSoučet: {2}\nPrůměr: {3}\n", nejmensi, nejvetsi, soucet, prumer);

            Console.ReadKey(true);
        }
    }
}
