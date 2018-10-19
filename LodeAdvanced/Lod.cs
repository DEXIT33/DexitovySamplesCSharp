﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodeAdvanced
{
    class Lod
    {
        private int x;
        private int y;
        private bool potopena = false;

        public bool Potopena
        {
            get => potopena;
            set => potopena = value;
        }

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        public Lod(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}