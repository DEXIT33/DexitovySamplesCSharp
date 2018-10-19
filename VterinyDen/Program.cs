using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VterinyDen
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour;
            int minutes;
            int seconds;

            Console.WriteLine("Zadejte hodinu:");
            hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zadejte počet minut:");
            minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zadejte počet sekund:");
            seconds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Od začátku dne uplynulo {0} sekund", 
                hour * 3600 + 
                minutes * 60 + 
                seconds);

            Console.ReadKey(true);
        }
    }
}
