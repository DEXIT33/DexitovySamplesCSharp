using System;

namespace ObjemACenaBazenu
{
    class Program
    {
        //Vstupní bod programu
        static void Main(string[] args)
        {
            //Ceny za tisíc litrů vody
            const int pardubiceKC = 84; 
            const int hradecKC = 104;

            //Proměnné, do kterých se uloží rozměry bazénu
            double delkaBazenu;
            double sirkaBazenu;
            double hloubkaBazenu;

            //Získání délek bazénu od uživatele
            Console.WriteLine("Zadejte délku bazénu v metrech:");
            delkaBazenu = ReadLineToDouble();
            Console.WriteLine("Zadejte šířku bazénu v metrech:");
            sirkaBazenu = ReadLineToDouble();
            Console.WriteLine("Zadejte hloubku bazénu v metrech:");
            hloubkaBazenu = ReadLineToDouble();

            //Výpočet objemu a počtu litrů vody
            double objemBazenu = delkaBazenu * sirkaBazenu * hloubkaBazenu;
            double litruVody = objemBazenu * 1000;

            //Finání výpis zpět uživateli
            Console.WriteLine("Bude potřeba {0} litrů vody", litruVody);
            Console.WriteLine("V Pardubicích bude voda stát {0} Kč", objemBazenu * pardubiceKC);
            Console.WriteLine("V Hradci Králové bude voda stát {0} Kč", objemBazenu * hradecKC);
            Console.ReadKey();
        }

        //Pomocná metoda pro získání doublu přes vstup od uživatele
        private static double ReadLineToDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
