using System;

namespace PalindromDetektor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej slovo:");
            string moznaJeTohlePalindrom = Console.ReadLine().Replace(" ", "").ToLower();

            char[] pole = moznaJeTohlePalindrom.ToCharArray();
            Array.Reverse(pole);

            if(moznaJeTohlePalindrom.Equals(new String(pole)))
                Console.WriteLine("Je to palindrom");
            else
                Console.WriteLine("Není to palindrom");

            Console.ReadKey();
        }
    }
}
