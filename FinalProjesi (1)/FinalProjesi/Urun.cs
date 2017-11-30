using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
   public class Urun:UrunTanimi
    {
         public string UrunAdi { get; set; }
        public int StoktakiMiktar { get; set; }
        public Urun(decimal Fiyat,int Kod):base (Fiyat,Kod)
        { }
        public Urun(int kod,int GuncelStok):base(kod)
        {
            this.StoktakiMiktar = GuncelStok;
        }


        
    }
}
