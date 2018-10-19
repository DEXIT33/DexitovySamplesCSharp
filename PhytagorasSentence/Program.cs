using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhytagorasSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Zadejte stranu a:");
            a = ReadLineToDouble();

            Console.WriteLine("Zadejte stranu b:");
            b = ReadLineToDouble();
        }

        private static double ReadLineToDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
