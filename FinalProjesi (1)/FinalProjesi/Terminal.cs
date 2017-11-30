using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    
    class Terminal
    { 
        public int SeriNo { get; set; }
        public List<Terminal> terminaller = new List<Terminal>();

        public Terminal()
        {
            Random rnd = new Random();
            this.SeriNo=rnd.Next();
        }
        HesapDefteri hesapDef=HesapDefteri.Defter();
        public void SatisaYonlendir(Urun u,int miktar)
        {
            Satıs s = new Satıs(u,miktar);
            
           

            if(u.StoktakiMiktar-s.SonMiktar==0)
            {
                hesapDef.Ekle(u);
            }
        }
    }
}
