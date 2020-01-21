using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCsharpBag2
{
    class Kubus
    {
        public float sisi;
        public float Volume()
        {
            return (float)Math.Pow(this.sisi, 3);
        }
    }
}
