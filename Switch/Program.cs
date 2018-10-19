using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            switch (a)
            {
                case 5:
                case 4:
                    Console.WriteLine("5 nebo 4");
                    break;
                default:
                    Console.WriteLine("něco");
                    break;
            }

            Console.ReadKey(true);
        }
    }
}
