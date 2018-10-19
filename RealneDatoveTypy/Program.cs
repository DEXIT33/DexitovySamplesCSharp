using System;

namespace RealneDatoveTypy
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());

            float f = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("V a je: {0}", a);
            Console.ReadKey();
        }
    }
}
