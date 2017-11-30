using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
  public  class KasaGorevlisi
    {
        private static KasaGorevlisi KG;
        private KasaGorevlisi()
        {

        }
        public static KasaGorevlisi kG()
        {
            if (KG == null)
                KG = new KasaGorevlisi();
            return KG;
        }
        private ulong TCKimlikno { get; }
        public string ad { get; set; }
        public string soyad { get; set; }
        private ulong SGKno { get; }
        public int KasiyerNo { get; private set; }
        public int KasiyerSifresi { get;private set; }

        public KasaGorevlisi(ulong Tc,ulong Sgk,int sifre)
        {
            this.TCKimlikno = Tc;
            this.SGKno = Sgk;
            this.KasiyerSifresi = sifre;

            Random rnd = new Random();
            //kasiyerno==rnd
           
                this.KasiyerNo = rnd.Next();
           
        }
        
       public List<KasaGorevlisi> kasiyer = new List<KasaGorevlisi>();
        
        public void KasiyerEkle(KasaGorevlisi k)
        {
            kasiyer.Add(k);
        }
        public void KasiyerCikar(KasaGorevlisi k)
        {
            kasiyer.Remove(k);
        }
        
       


    }
}
