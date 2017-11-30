using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
   public class UrunTanimi
    {
        public int Urunkodu { get;private set; }
        public string Tanim { get; set; }
        public decimal BirimFiyati { get;private set; }
        public UrunTanimi(decimal birimFiyat,int kod)
        {
            this.BirimFiyati = birimFiyat;
            this.Urunkodu = kod;
        }
        public UrunTanimi(int urunKodu)
        {
            this.Urunkodu = urunKodu;
        }

    }
}
