using System;

namespace BelajarCsharpBag2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manusia man1 = new Manusia();
            Segitiga s1 = new Segitiga();
            s1.sisi = new float[] { 1.2F, 3.4F, 5.1F};
            man1.TampilkanDataDiri();
            Console.WriteLine(Convert.ToInt32(s1.Keliling()));
        }
    }
}
