using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    class Ödeme
    {
        private static Ödeme Odeme;//singleton deseni
        private Ödeme()
        {

        }
        public static Ödeme odeme()
        {
            if (Odeme == null)
                Odeme = new Ödeme();
            return Odeme;
        }

        public decimal OdemeMiktari { get;private set; }
        public string OdemeSekli { get;private set; }

        public KasaGorevlisi Kasa
        {
            get
            {
                return kasa;
            }

            set
            {
                kasa = value;
            }
        }

        public Satıs Satis
        {
            get
            {
                return satis;
            }

            set
            {
                satis = value;
            }
        }

        public Ödeme(decimal Odenecek,string Odemesekli)
        {
            this.OdemeSekli = Odemesekli;
            this.OdemeMiktari = Odenecek;
        }
        Satıs satis=Satıs.Sts();
        KasaGorevlisi kasa=KasaGorevlisi.kG();
        Musteri m =Musteri.Mstr();

        public string SatisSonu()
        {
            string temp = " ";
            foreach(string u in satis.SatilanListesi)
            {
                temp += u;
            }
            return temp + "\n\n" + "\nÖdeme şekli:" + OdemeSekli
                    + "\nKasiyer:\n" + kasa.ad + kasa.soyad +"\nTarih:" + satis.tarih.ToString();
        }

    }
}
