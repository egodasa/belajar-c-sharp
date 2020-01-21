using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCsharpBag2
{
    class Persegi : IBangunDatar
    {
        public float sisi;
        public float Luas()
        {
            return (float) Math.Pow(this.sisi, 3);
        }
        public float Keliling()
        {
            return (float)sisi * 4;
        }
    }
}
