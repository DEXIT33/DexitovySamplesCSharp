using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;


            Console.WriteLine("Zadejte první číslo");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte třetí číslo");
            n3 = Convert.ToDouble(Console.ReadLine());

            //Řešení přes Math.Max();
            //Console.WriteLine("Nejvyšší číslo je {0}", Math.Max(n1, Math.Max(n2, n3)));

            //Řešení přes podmínky;
            if (n2 > n1) n1 = n2;
            if (n3 > n1) n1 = n3;

            Console.WriteLine("Nejvyšší číslo je {0}", n1);

            //Čeká na stisknutí klávesy
            Console.ReadKey(true);
        }
    }
}
