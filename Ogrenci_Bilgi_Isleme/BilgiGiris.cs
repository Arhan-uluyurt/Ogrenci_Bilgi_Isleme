using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Bilgi
{
    internal class BilgiGiris
    {
        public IlkOkul IlkOkulBilgiAl()
        {
            Console.Write("Ad Soyad: ");
            string adSoyad = Console.ReadLine();

            Console.Write("Okul adı: ");
            string okulAdi = Console.ReadLine();

            Console.Write("Okul No: ");
            int okulNo = Convert.ToInt32(Console.ReadLine());

            return new IlkOkul(adSoyad, okulNo, okulAdi);
        }

        public OrtaOkul OrtaOkulBilgiAl ()
        {
            Console.Write("Ad Soyad: ");
            string adSoyad = Console.ReadLine();

            Console.Write("Okul adı: ");
            string okulAdi = Console.ReadLine();

            Console.Write("Okul No: ");
            int okulNo = Convert.ToInt32(Console.ReadLine());

            return new OrtaOkul(adSoyad, okulNo, okulAdi);
        }
        public LiseOgrencisi LiseOgrenciBilgiAl()
        {
            Console.Write("Ad Soyad: ");
            string adSoyad = Console.ReadLine();

            Console.Write("Okul adı: ");
            string okulAdi = Console.ReadLine();

            Console.Write("Okul No: ");
            int okulNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Not 1: ");
            double not1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Not 2: ");
            double not2 = Convert.ToDouble(Console.ReadLine());

            return new LiseOgrencisi(adSoyad, okulNo, not1, not2, okulAdi);
        }

        public LisansOgrencisi LisansOgrenciBilgiAl()
        {
            Console.Write("Ad Soyad: ");
            string adSoyad = Console.ReadLine();

            Console.Write("Okul adı: ");
            string okulAdi = Console.ReadLine();

            Console.Write("Okul No: ");
            int okulNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fakülte: ");
            string fakulte = Console.ReadLine();

            Console.Write("Vize Notu: ");
            double vizeNotu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final Notu: ");
            double finalNotu = Convert.ToDouble(Console.ReadLine());

            return new LisansOgrencisi(adSoyad, okulNo, fakulte, vizeNotu, finalNotu, okulAdi);
        }
    }
}
