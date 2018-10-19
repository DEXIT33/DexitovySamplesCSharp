using System;

namespace OOP
{
    public class Kvadr
    {
        private double _a;
        private double _b;
        private double _c;
        
        public Kvadr(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new System.ArgumentException("Hrany kvádru musí být větší než nula.");
            
            _a = a;
            _b = b;
            _c = c;
        }
        
        public double A
        {
            get => _a;
            set => _a = value <= 0 ? throw new System.ArgumentException("Hrany kvádru musí být větší než nula.") : value;
        }
        
        public double B
        {
            get => _b;
            set => _b = value <= 0 ? throw new System.ArgumentException("Hrany kvádru musí být větší než nula.") : value;
        }
        
        public double C
        {
            get => _c;
            set => _c = value <= 0 ? throw new System.ArgumentException("Hrany kvádru musí být větší než nula.") : value;
        }
        
        public double Objem => _a * _b * _c;
        
        public double Povrch => 2 * (_a * _b + _a * _c + _b * _c);
    }
}