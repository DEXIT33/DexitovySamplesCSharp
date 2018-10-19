using System;

namespace RozdilDatumu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte své datum narození:");
            DateTime narozen = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Zadej datum narození kamaráda nebo někoho s kým se chceš měřit, nemusí to být tvůj kamarád:");
            DateTime narozenKamarad = DateTime.Parse(Console.ReadLine());

            TimeSpan dny = narozenKamarad - narozen;

            Console.WriteLine("Rozdíl toho jak dlouho žijete je {0} dní", Math.Abs(dny.TotalDays));
            Console.ReadKey(true);

            //Ahoj lidi, jak se máte?
        }
    }
}
