using System;

namespace radekProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string[]{"a", "b", "c", "d", "e"}[new Random().Next(0, 6)]);
        }
    }
}
