using System;

namespace AutomobilPisemka
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Automobil auto = new Automobil("stříbrná", 500);
            
            Automobil auto2 = new Automobil("černá", 500);
            
            Console.WriteLine(auto);
            
            auto.Zarad();
            
            Console.WriteLine(auto.Dojezd());
            
            auto.Ujed(50);
            
            Console.WriteLine(auto.Dojezd());
            
            auto.Natankuj(9.8);
            
            Console.WriteLine(auto.Dojezd());
            
            Console.WriteLine(auto2);
            
            Console.WriteLine(auto.DojedeDalNez(auto2));
        }
    }
}