using System;

namespace Pisemka
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var firma = new Firma(5, 80000);
            firma.PrijmiZamestnance();
            firma.PrijmiZamestnance();
            firma.PrijmiZamestnance();
            
            Console.WriteLine(firma.PrumerNaZamestnance());
            
            firma.PropustZamestnance();
            firma.PropustZamestnance();
            firma.PropustZamestnance();
            
            Console.WriteLine(firma.VlozPenizeNaMzdy(20000));
            Console.WriteLine(firma.PrumerNaZamestnance());
        }
    }
}