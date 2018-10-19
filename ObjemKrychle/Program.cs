using System;

namespace ObjemKrychle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej hranu krychle v metrech:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Objem krychle je: {0} litrů.", a * a * a * 1000);
            Console.ReadKey();
        }
    }
}
