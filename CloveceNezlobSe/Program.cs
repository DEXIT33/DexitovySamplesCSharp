using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloveceNezlobSe
{
    class Program
    {
        static void Main(string[] args)
        {
            const int policko = 0;
            const int hrac1 = 1;
            const int hrac2 = 2;

            Console.WriteLine("Zvolte si velikost pole:");
           
            int[] pole = new int[Convert.ToInt32(Console.ReadLine())];

            int hrac1Index = 0;
            int hrac2Index = 0;

            Random random = new Random();

            while (true)
            {           
                //Hrac
                int kostka = 0;

                while (kostka < 1 || kostka > 6)
                {
                    Console.WriteLine("Zadejte pocet na kostce od 1 do 6:");
                    kostka = Convert.ToInt32(Console.ReadLine());
                }          

                pole[hrac1Index] = policko;

                hrac1Index += kostka;

                if (hrac1Index >= pole.Length)
                {
                    Console.WriteLine("Vyhral jsi");
                    break;
                }

                if (hrac1Index == hrac2Index)
                {
                    hrac2Index = 0;
                    pole[hrac2Index] = hrac2;
                }
                
                pole[hrac1Index] = hrac1;

                //Pocitac
                kostka = random.Next(0, 7);

                pole[hrac2Index] = policko;

                hrac2Index += kostka;           

                if (hrac2Index >= pole.Length)
                {
                    Console.WriteLine("Prohral jsi");
                    break;
                }

                if (hrac1Index == hrac2Index)
                {
                    hrac1Index = 0;
                    pole[hrac1Index] = hrac1;
                }                    

                pole[hrac2Index] = hrac2;


                for (int i = 0; i < pole.Length; i++)
                {
                    Console.Write(pole[i]);
                }

                Console.WriteLine();

                Console.ReadKey(true);
            }

            Console.ReadKey(true);
        }
    }
}
