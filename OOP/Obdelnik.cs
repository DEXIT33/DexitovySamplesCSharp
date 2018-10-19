using System;

namespace OOP
{
    public class Obdelnik
    {
        private double a;
        private double b;

        public double A
        {
            get => a;
            set
            {
                if(value >= 0)
                    a = value;
                else
                    throw new ArgumentOutOfRangeException();
            }         
        }
        
        public double B
        {
            get => b;
            set
            {
                if(value >= 0)
                    b = value;
                else
                    throw new ArgumentOutOfRangeException();
            }         
        }

        public double Obsah()
        {
            return a * b;
        }

        public double Obvod()
        {
            return 2 * (a + b);
        }
    }
}