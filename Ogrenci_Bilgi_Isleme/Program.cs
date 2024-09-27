namespace Ogrenci_Bilgi
{
    internal class Program
    {
        #region Soru
        //     Çeşitli seviyelerdeki öğrenci bilgilerini tutan ve aşağıda verilen işlemleri yapan programı; 
        //Kalıtım, kapsülleme ve isimlendirme standartlarını dikkate alarak yazınız.
        //Kullanılacak bilgiler: Sınıf tanımlama,yapıcı metot kullanımı ve kalıtımı, kalıtım, kapsülleme, list   kullanımı, akış kontrol mekanizmaları kullanımı,

        //Soru: 
        //Tüm öğrenciler(Ogrenci) için saklanacak bilgiler:
        //----------------------------------------
        //    * Ad Soyad(tek özellikte tutulacak)
        //    * Okul Numarası
        //    * Okul Adı = "Açıktan Eğitim"	(Alt sınıflarda tanımlanırsa değişecek)
        //    * Ögretim Duzeyi(IlkOgretim,OrtaOgretim,Lise,Lisans) enum tipinde  4 elemanlı

        //    NOT: Yukarıdaki bilgileri tutmak için bir ArrayList tanımlanacak(sadece bu 4 bilgi tutacak)

        //Tüm öğrenciler(Ogrenci) için uygulanacak işlemler:
        //-----------------------------------------
        //    * Yapıcı metot ile nesne tanımlandığında notlar otomatik olarak ArrayListe eklenecek.(constructer 4     parametre   ile çağırılacak.)
        //    * NotHesapla(): Ekrana "Not Bilgisi Eksik !" yazdıracak.(Alt sınıflarda tanımlanırsa değişecek)


        //LiseOgrencisi için saklanacak bilgiler:
        //---------------------------------------
        //    * Okul Adı
        //    * Not1 (1. sınav notu)
        //    * Not2 (2. sınav notu)


        //LiseOgrencisi için uygulanacak işlemler:
        //----------------------------------------
        //    * Constructer metot 3 özelliği parametre olarak isteyecek.
        //    * NotHesapla(): 2 notun aritmetik ortalamasını alacak ekrana yazdıracak.

        //5	85.00-100	Pekiyi
        //4	70.00-84.99	İyi
        //3	60.00-69.99	Orta
        //2	50.00-59.99	Geçer	
        //1	0 - 49.99	Tekrar

        //LisansOgrencisi için saklanacak bilgiler:
        //-----------------------------------------
        //    * Fakülte
        //    * VizeNotu
        //    * FinalNotu

        //LisansOgrencisi için uygulanacak işlemler:
        //------------------------------------------
        //    * Constructer metot 3 özelliği parametre olarak isteyecek.
        //    * NotHesapla(): vizenin %40 ını finalin %60 ını alıp ortalamayı aşağıdaki gibi derecelendirerek ekrana       yazdıracak.

        //    85.00-100	A
        //    70.00-84.99	B
        //    60.00-69.99	C
        //    50.00-59.99	D
        //    45- 49.99	E
        //    0 - 44.99	F
        //Program sınıfında tanımlanacak metot:

        //OgrenciNotHesapla(Ogrenci ogr)
        //    ogr.NotHesapla

        //Main metodunda yapılacak işlemler:
        //----------------------------------
        //    Lise ve Lisans tipinde ayrı nesne bilgileri girilerek tanımlanacak.
        //    Nesneler OgrenciNotHesapla metoduna parametre olarak gönderilerek not hesaplama metotları çalıştırılacak.
        #endregion

        static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        static void Main(string[] args)
        {
            BilgiGiris bilgiGiris = new BilgiGiris();

            
            while (true)
            {
                try
                {
                    Console.WriteLine("1 - Öğrenci Ekle");
                    Console.WriteLine("2 - Öğrenci Ara");
                    Console.WriteLine("3 - Çıkış");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        OgrenciEkle();
                        Console.WriteLine("1 - Ana menü\n2 - Çıkış");
                        int secim1 = Convert.ToInt32(Console.ReadLine());
                        while (true)
                        {
                            if (secim1 == 1) { Console.Clear(); break; }
                            else if (secim1 == 2) { Environment.Exit(0); }
                            else { Console.WriteLine("Hatalı giriş."); }
                        }
                    }
                    else if (secim == 2)
                    {
                        OgrenciAra();
                        Console.WriteLine("1 - Ana menü\n2 - Çıkış");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        while (true)
                        {
                            if (secim2 == 1) { Console.Clear(); break; }
                            else if (secim2 == 2) { Environment.Exit(0); }
                            else { Console.WriteLine("Hatalı giriş."); }
                        }
                    }
                    else if (secim == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim.");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş, sadece rakam kullanınız.");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
            }
        }
        public static void OgrenciNotHesapla(Ogrenci ogr)
        {
            Console.WriteLine(ogr.OgrenciBilgileri());
            ogr.NotHesapla();
        }
        public static void OgrenciEkle()
        {
            BilgiGiris bilgiGiris = new BilgiGiris();

            Console.WriteLine("Öğrenci türünü seçiniz:\n1 - İlk okul\n2 - Orta okul\n3 - Lise\n4 - Lisans");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                IlkOkul IlkOgr = bilgiGiris.IlkOkulBilgiAl();
                ogrenciler.Add(IlkOgr);
                Console.WriteLine($"Öğrenci eklendi. ID: {IlkOgr.ID}");
            }
            else if (secim == 2)
            {
                OrtaOkul OrtaOgr = bilgiGiris.OrtaOkulBilgiAl();
                ogrenciler.Add(OrtaOgr);
                Console.WriteLine($"Öğrenci eklendi. ID: {OrtaOgr.ID}");
            }
            else if (secim == 3)
            {
                LiseOgrencisi liseOgr = bilgiGiris.LiseOgrenciBilgiAl();
                ogrenciler.Add(liseOgr);
                Console.WriteLine($"Öğrenci eklendi. ID: {liseOgr.ID}");
            }
            else if (secim == 4)
            {
                LisansOgrencisi lisansOgr = bilgiGiris.LisansOgrenciBilgiAl();
                ogrenciler.Add(lisansOgr);
                Console.WriteLine($"Öğrenci eklendi. ID: {lisansOgr.ID}");
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
            }
        }
        public static void OgrenciAra()
        {
            Console.Write("Aranacak öğrenci ID'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Ogrenci ogr = ogrenciler.Find(o => o.ID == id);

            if (ogr != null)
            {
                Console.WriteLine("Öğrenci bulundu:");
                OgrenciNotHesapla(ogr);
            }
            else
            {
                Console.WriteLine("Öğrenci bulunamadı.");
            }
        }
    }
}
