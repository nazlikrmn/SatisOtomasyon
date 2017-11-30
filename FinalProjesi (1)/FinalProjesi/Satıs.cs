using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
  public  class Satıs
    {
        private static Satıs sts;
        private Satıs()
        {

        }
        public static Satıs Sts()
        {
            if (sts == null)
                sts = new Satıs();
            return sts;
        }
        public int satisKodu { get;set; }
        public DateTime tarih = DateTime.Now;
        public const decimal KDV = 0.18M;
       
        public List<string> SatilanListesi = new List<string>();

        public Urun SonUrun { get; private set; }
        public int SonMiktar { get; private set; }
      

        public Satıs(Urun sonUrun,int miktar)
        {
            this.SonMiktar = miktar;
            this.SonUrun = sonUrun;
        }   
        
    }
}
