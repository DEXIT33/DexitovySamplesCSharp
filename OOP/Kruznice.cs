using System;

namespace OOP
{
    public class Kruznice
    {
        private double polomer;

        public double Polomer
        {
            get => polomer;
            set
            {
                if(polomer >= 0)
                    polomer = value;
                else
                    Console.WriteLine("Špatně zadaný poloměr");
            }         
        }

        public double Obsah()
        {
            return Math.PI * polomer * polomer;
        }

        public double Obvod()
        {
            return 2 * Math.PI * polomer;
        }
    }
}