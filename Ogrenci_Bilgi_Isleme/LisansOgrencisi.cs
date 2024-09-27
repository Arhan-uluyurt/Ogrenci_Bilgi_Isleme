using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Bilgi
{
    internal class LisansOgrencisi : Ogrenci
    {
        private string fakulte;
        private double vizeNotu;
        private double finalNotu;

        public LisansOgrencisi(string adSoyad, int okulNo, string fakulte, double vizeNotu, double finalNotu, string okulAdi)
            : base(adSoyad, okulNo, OgretimDuzeyi.Lisans, okulAdi)
        {
            this.fakulte = fakulte;
            this.vizeNotu = vizeNotu;
            this.finalNotu = finalNotu;
        }

        public override void NotHesapla()
        {
            double ortalama = (vizeNotu * 0.4) + (finalNotu * 0.6);
            Console.WriteLine($"Ortalama: {ortalama}");

            if (ortalama >= 85)
                Console.WriteLine("A");
            else if (ortalama >= 70)
                Console.WriteLine("B");
            else if (ortalama >= 60)
                Console.WriteLine("C");
            else if (ortalama >= 50)
                Console.WriteLine("D");
            else if (ortalama >= 45)
                Console.WriteLine("E");
            else
                Console.WriteLine("F");
        }
    }
}
