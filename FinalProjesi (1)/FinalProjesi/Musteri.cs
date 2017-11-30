using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
   public class Musteri
    {
        private static Musteri mstr;
        private Musteri()
        {

        }
        public static Musteri Mstr()
        {
            if (mstr==null)

                mstr = new Musteri();
            return mstr;
        }
        
        public string isim { get; set; }
        public string soyad { get; set; }
        public int MusteriNumarasi = 0;

        public List<Musteri> musteriListesi = new List<Musteri>();
       
        public Musteri(string Ad,string Soyad)
        {
            this.isim = Ad;
            this.soyad = Soyad;
            MusteriNumarasi++;
        }
        public void MusteriEkle(Musteri m)
        {
            musteriListesi.Add(m);
        }



    }
}