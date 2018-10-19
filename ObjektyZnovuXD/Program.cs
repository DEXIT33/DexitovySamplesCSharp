using System;

namespace ObjektyZnovuXD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var clovek = new Clovek(1);
        }

        private class Clovek
        {
            public Clovek(int vek)
            {
                _vek = vek >= 0 && vek <= 120 ? vek : throw new ArgumentException("Věk musí být minimálně 0 a maximálně 120");
            }

            private int _vek;

            public int Vek
            {
                set => _vek = value >= 0 && value <= 120 ? value : throw new ArgumentException("Věk musí být minimálně 0 a maximálně 120");
            }
        }
    }
}