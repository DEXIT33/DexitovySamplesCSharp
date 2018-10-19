using System;

namespace PythagorasSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Zadejte stranu a pravoúlhlého trojuhelníku:");
            a = ReadLineToDouble();

            Console.WriteLine("Zadejte stranu b pravoúlhlého trojuhelníku:");
            b = ReadLineToDouble();

            c = Math.Sqrt(a * a + b * b);

            Console.WriteLine("Strana c je {0}", c);
            Console.ReadKey();
        }

        private static double ReadLineToDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
