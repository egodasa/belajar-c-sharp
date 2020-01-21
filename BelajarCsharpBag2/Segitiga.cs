using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCsharpBag2
{
    class Segitiga : IBangunDatar
    {
        public float alas, tinggi;
        public float[] sisi;
        public float Luas()
        {
            return (alas * tinggi) / 2;
        }
        public float Keliling()
        {
            float hasil = 0;
            foreach(float s in this.sisi)
            {
                hasil += s;
            }
            return hasil;
        }
    }
}
