using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class UrunKatalogu : Dukkan
    {
        private static UrunKatalogu K;//singleton deseni --> tek bir urun kataloğu
        private UrunKatalogu()
        {

        }
        public static UrunKatalogu k()
        {
            if (K == null)
                K = new UrunKatalogu();
            return K;
        }

        public List<Urun> urunKatalogu = new List<Urun>();
        public override void Cikar(int barkod)
        {
            foreach (Urun u in urunKatalogu)
            {
                if (u.Urunkodu == barkod)
                    urunKatalogu.Remove(u);
                else
                    continue;
            }
            
        }

        public override void Ekle(Urun u)
        {
            urunKatalogu.Add(u);
        }

        public override string Listele()
        {
            string temp = " ";
            foreach (Urun urun in urunKatalogu)
            {
                temp += "Urunadi:" + urun.UrunAdi + "UrunKodu:" + urun.Urunkodu + "Tanim:" + urun.Tanim + "fiyat:" + urun.BirimFiyati+" ";
            }
            return temp;
        }
    }
}
