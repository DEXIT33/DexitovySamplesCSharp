using System;

namespace OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kvadr kvadr = new Kvadr(5, 5, 3);

            kvadr.A = 5556;
            kvadr.B = 4355;
            kvadr.C = 2541;
            
            Console.WriteLine(kvadr.Povrch);
            Console.WriteLine(kvadr.Objem);
        }
    }
}