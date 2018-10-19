using System;

namespace PocetDnuNarozen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte datum narození");
            DateTime narozen = DateTime.Parse(Console.ReadLine());
            TimeSpan dny = DateTime.Today - narozen;
            Console.WriteLine("Žiješ {0} dní", dny.TotalDays);
            Console.ReadKey(true);
        }
    }
}
