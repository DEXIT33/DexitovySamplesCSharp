using System;

namespace PrejOpacko
{
    class Program
    {
        static void Main(string[] args)
        {            
            double cenaZbozi;
            double sleva;

            Console.WriteLine("Zadejte cenu zboží:");
            cenaZbozi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte slevu v procentech:");
            sleva = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cena zboží po slevě je {0} korun.", cenaZbozi - cenaZbozi / 100 * sleva);
            Console.ReadKey(true);           
        }
    }
}
