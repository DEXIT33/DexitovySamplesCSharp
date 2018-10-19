using System;

namespace PocetDelitelnychCisel
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocet = 0;

            for(int i = 100; i <= 200; i++)
                if (i % 3 == 0)
                    pocet++;

            Console.WriteLine("Čísel je: " + pocet);
            Console.ReadKey(true);
        }
    }
}
