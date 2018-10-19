using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vypíše do konzole zadaný řetězec
            Console.WriteLine("Zadej a");

            //Dosadí do proměnné a zkonvertovaný vstup od uživatele do typu int
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zadej b");
            int b = Convert.ToInt32(Console.ReadLine());

            //Vypíše součet proměnných
            Console.WriteLine("Výsledek je {0}", a);

            //Čeká na stisknutí libovolné klávesy
            Console.ReadKey(); 
        }
    }
}
