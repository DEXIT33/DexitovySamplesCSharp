using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodeAdvanced
{
    class Lod
    {
        private int _x;
        private int _y;

        public int X
        {
            get => _x;
            set => _x = value;
        }

        public int Y
        {
            get => _y;
            set => _y = value;
        }

        public Lod(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return "Lod: " + _x + "," + _y;
        }
    }
}
