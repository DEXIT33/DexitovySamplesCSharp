using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej hodnotu a:");
            int a = Convert.ToInt32(Console.ReadLine());

            //<, >, >=, <=, ==, !=

            if (a > 10)
                Console.WriteLine("a je větší než 10");
            else
                Console.WriteLine("a je menší nebo rovno 10");

            Console.ReadKey(true);
        }
    }
}
