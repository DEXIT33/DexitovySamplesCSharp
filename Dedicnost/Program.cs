using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost
{
    class Program
    {
        static void Main(string[] args)
        {
            new Matematika().Soucet(5, 2);
        }
    }

    class Matematika
    {
        public void Soucet(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Soucet(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        public void Pricti(int a)
        {
            a++;
            Console.WriteLine(a);
        }
    }
}
