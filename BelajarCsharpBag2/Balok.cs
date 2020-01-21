using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCsharpBag2
{
    class Balok : IBangunRuang
    {
        public float panjang, lebar, tinggi;
        public float Volume()
        {
            return (float)panjang * lebar * tinggi;
        }
    }
}
