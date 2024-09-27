using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Bilgi
{
    internal class LiseOgrencisi : Ogrenci
    {
        private double not1;
        private double not2;

        public LiseOgrencisi(string adSoyad, int okulNo, double not1, double not2, string okulAdi)
            : base(adSoyad, okulNo, OgretimDuzeyi.Lise, okulAdi)
        {
            this.not1 = not1;
            this.not2 = not2;
        }

        public override void NotHesapla()
        {
            double ortalama = (not1 + not2) / 2;
            Console.WriteLine($"Ortalama: {ortalama}");

            if (ortalama >= 85)
                Console.WriteLine("Pekiyi");
            else if (ortalama >= 70)
                Console.WriteLine("İyi");
            else if (ortalama >= 60)
                Console.WriteLine("Orta");
            else if (ortalama >= 50)
                Console.WriteLine("Geçer");
            else
                Console.WriteLine("Tekrar");
        }
    }
}
