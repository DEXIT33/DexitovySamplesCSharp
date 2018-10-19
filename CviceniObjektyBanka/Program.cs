using System;

namespace CviceniObjektyBanka
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var banka = new Banka(555, 90000);
            
            banka.Uloz(50);
            banka.Vypis(555);
            banka.Vypis(556);
            banka.Vyber(50, 555);
            banka.Vyber(50, 556);
            banka.Vypis(555);
            banka.ZmenPin(555, 556);
            banka.ZmenPin(557, 555);
            banka.ZmenPin(556, 555);
            banka.Vypis(555);
            banka.Vyber(50, 555);
            banka.Vypis(555);
        }
    }
}