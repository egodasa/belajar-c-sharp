using System;
using System.Collections.Generic;
using System.Text;

namespace BelajarCsharpBag2
{
    class Manusia
    {
        public string Nama;
        public int TinggiBadan;
        public float BeratBadan;
        public char GolDarah;
        public bool Jk; // jika Jk = true, maka jenis kelamin cewek
        public Manusia(string nama = "-", int tinggiBadan = 0, float beratBadan = 0.0F, string golDarah = "-", bool jk = false)
        {
            this.Nama = nama;
            this.TinggiBadan = tinggiBadan;
            this.BeratBadan = beratBadan;
            this.GolDarah = Convert.ToChar(golDarah);
            this.Jk = jk;
        }
        public void TampilkanDataDiri()
        {
            Console.WriteLine("Nama Saya : " + Nama);
            Console.WriteLine("Tinggi Badan : " + TinggiBadan);
            Console.WriteLine("Berat Badan : " + BeratBadan);
            Console.WriteLine("Golongan Darah : " + GolDarah);
            if(this.Jk == true)
            {
                Console.WriteLine("Jenis Kelamin : Perempuan");
            }
            else
            {
                Console.WriteLine("Jenis Kelamin : Laki-laki");
            }
            
        }
    }
    
}
