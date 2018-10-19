using System;

namespace MomentalniCas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.TimeOfDay.TotalSeconds);
            Console.ReadKey();
        }
    }
}
