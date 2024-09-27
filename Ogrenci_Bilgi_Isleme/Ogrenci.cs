using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Bilgi
{
    internal enum OgretimDuzeyi
    {
        IlkOkul,
        OrtaOkul,
        Lise,
        Lisans
    }
    internal class Ogrenci
    {
        private static int idSayac = 1;
        public int ID { get; private set; }
        private string adSoyad;
        private int okulNo;
        private string okulAdi;
        private OgretimDuzeyi ogretimDuzeyi;
        protected ArrayList ogrenciBilgileri = new ArrayList();

        public Ogrenci(string adSoyad, int okulNo, OgretimDuzeyi ogretimDuzeyi, string okulAdi)
        {
            this.ID = idSayac++;
            this.adSoyad = adSoyad;
            this.okulNo = okulNo;
            this.okulAdi = okulAdi;
            this.ogretimDuzeyi = ogretimDuzeyi;

            ogrenciBilgileri.Add(adSoyad);
            ogrenciBilgileri.Add(okulNo);
            ogrenciBilgileri.Add(okulAdi);
            ogrenciBilgileri.Add(ogretimDuzeyi);

        }
        public virtual void NotHesapla()
        {
            Console.WriteLine("Not Bilgisi Eksik!");
        }
        public string OgrenciBilgileri()
        {
            return $"ID: {ID}, Ad Soyad: {adSoyad}, Okul No: {okulNo}, Okul: {okulAdi}, Öğretim Düzeyi: {ogretimDuzeyi}";
        }
    }
}
