using System;

namespace MetodyHahahaha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PythagorovaVeta(3, 4));
            Console.WriteLine(ObsahKruznice(4));
            Console.WriteLine(ObjemValce(4, 5));

            Console.ReadKey();
        }

        static double PythagorovaVeta(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        static double ObsahKruznice(double r)
        {
            return r * r * Math.PI;
        }

        static double ObjemValce(double r, double v)
        {
            return ObsahKruznice(r) * v;
        }
    }
}
