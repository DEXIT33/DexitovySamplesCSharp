using System;

namespace NejmensiCislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int pocetCisel;
            int momentalniCislo = Int32.MaxValue;

            Console.WriteLine("Zadej kolik budeš zadávat čísel:");

            pocetCisel = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < pocetCisel; i++)
            {
                Console.WriteLine("Zadej {0}. číslo:", i + 1);
                int cislo = Convert.ToInt32(Console.ReadLine());
                
                if (cislo < momentalniCislo)
                    momentalniCislo = cislo;
            }

            Console.WriteLine("Nejmenší číslo je {0}", momentalniCislo);
            Console.ReadKey(true);
        }
    }
}
