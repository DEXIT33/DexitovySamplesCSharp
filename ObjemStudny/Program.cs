using System;

namespace ObjemStudny
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double h;

            Console.WriteLine("Zadej poloměr studny:");
            r = ReadLineToDouble();
            Console.WriteLine("Zadej hloubku studny:");
            h = ReadLineToDouble();

            double vysledek = Math.PI * r * r * h * 1000;

            Console.WriteLine("Objem studny je: {0}", vysledek);
        }

        //Pomocná metoda pro získání doublu přes vstup od uživatele
        private static double ReadLineToDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
