using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VymalbaMistnosti
{
    class Program
    {
        static void Main(string[] args)
        {
            const int pokrytiBarvy = 10; //metrů čtverečních

            double a; //délka
            double b; //šířka
            double v; //výška

            int pocetPlechovek;

            Console.WriteLine("Zadejte délku místnosti");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadejte šířku místnosti");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadejte výšku místnosti");
            v = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadejte počet plechovek");
            pocetPlechovek = Convert.ToInt32(Console.ReadLine());

            double obsahMistnosti = b * v * 2 + a * v * 2;

            Console.WriteLine(pocetPlechovek * pokrytiBarvy >= obsahMistnosti ? "Plechovky budou stačit." : "Plechovky nebudou stačit.");

            Console.ReadKey(true);
        }
    }
}
