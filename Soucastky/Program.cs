using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soucastky
{
    class Program
    {
        static void Main(string[] args)
        {
            double RV;
            double tolerance;
            double RS;

            Console.WriteLine("Zadejte rozměr výkresu:");
            RV = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte toleranci:");
            tolerance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte rozměr součástky:");
            RS = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(RS < RV - tolerance || RS > RV + tolerance ? "Součástka je špatná" : "Součástka je dobrá");

            Console.ReadKey();
        }
    }
}
