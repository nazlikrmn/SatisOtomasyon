using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
   public class SatısKalemi
    {
        private static SatısKalemi SatisKlm;//Singleton deseni
        private SatısKalemi()
        {

        }
        public static SatısKalemi satisKlm()
        {
            if (SatisKlm == null)
                SatisKlm = new SatısKalemi();
            return SatisKlm;
        }

       public List<string> Kalem = new List<string>();
        public void SatisEkle(string Satilaninadi,int miktar)
        {
            string S_Kalem = Satilaninadi + "\t" + miktar.ToString();
            Kalem.Add(S_Kalem);
        }
    }
}
