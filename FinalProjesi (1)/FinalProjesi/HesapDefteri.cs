using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class HesapDefteri : Dukkan
    {
        private static HesapDefteri defter;//singleton deseni
        private HesapDefteri()
        {

        }
        public static HesapDefteri Defter()
        {
            if (defter == null)
                defter = new HesapDefteri();
            return defter;
        }

        public List<string> BitenUrun = new List<string>();//stok==0 olanlar
        public List<string> StoktakiUrunler = new List<string>();//urun kodu adı ve stok adedi
        public List<string> HesapKaydı = new List<string>();//girdi çıktı işlem listesi

        public void HesapDefterineEkle(int satisKodu,decimal Ucret)
        {
            string Kayıt= satisKodu.ToString()+"\t"+ Ucret.ToString();
            HesapKaydı.Add(Kayıt);
        }

        public override void Ekle(Urun u)
        {
            string Biten = u.UrunAdi;
            BitenUrun.Add(Biten);
            StoktakiUrunler.Remove(Biten);//Biten ürünü stoktan çıkarıp listeye kaydet.
        }

        public override void Cikar(int barkod)
        {
            throw new NotImplementedException();
        }

        public override string Listele()
        {
            string temp = " ";
            foreach (string s in HesapKaydı)
            {
                temp += s+"\n";
            }
            return temp;
        }
    }
}
