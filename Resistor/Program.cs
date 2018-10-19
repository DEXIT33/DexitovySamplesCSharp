using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistor
{
    class Program
    {
        static void Main(string[] args)
        {
            double R1;
            double R2;

            Console.WriteLine("Zadej hodnotu odporu R1:");
            R1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadej hodnotu odporu R2:");
            R2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Odpor při seriovém zapojení je {0} a při paralelním zapojení {1}", 
                //Seriové zapojení
                R1 + R2, 
                //Paralelní zapojení
                (R1 * R2) / (R1 + R2)
            );

            Console.ReadKey();
        }
    }
}
