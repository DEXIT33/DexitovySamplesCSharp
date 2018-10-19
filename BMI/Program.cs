using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double hmotnost;
            double vyska;

            double BMI;

            Console.WriteLine("Zadejte svoji váhu v kilogramech:");
            hmotnost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Zadejte svoji výšku v metrech:");
            vyska = Convert.ToDouble(Console.ReadLine());

            BMI = hmotnost / (vyska * vyska);

            Console.WriteLine("Vaše BMI je {0}", BMI);
            
            if (BMI > 25)
                Console.WriteLine("Vaše BMI je vyšší než ideální");
            else if (BMI >= 18.5 && BMI <= 25)
                Console.WriteLine("Vaše BMI je ideální");
            else
                Console.WriteLine("Vaše BMI je nižší než ideální");

            Console.ReadKey();
        }
    }
}
