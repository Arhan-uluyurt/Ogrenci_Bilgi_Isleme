using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Bilgi
{
    internal class OrtaOkul : Ogrenci
    {
        public OrtaOkul(string adSoyad, int okulNo, string okulAdi)
            : base(adSoyad, okulNo, OgretimDuzeyi.OrtaOkul, okulAdi)
        {
            
        }
    }
    internal class IlkOkul : Ogrenci
    {
        public IlkOkul(string adSoyad, int okulNo, string okulAdi)
            : base(adSoyad, okulNo, OgretimDuzeyi.IlkOkul, okulAdi)
        {

        }
    }
}
