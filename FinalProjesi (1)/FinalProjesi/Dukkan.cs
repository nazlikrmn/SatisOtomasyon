using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
   public abstract class Dukkan
    {
        public abstract void Ekle(Urun u);
        public abstract void Cikar(int barkod);
        public abstract string Listele();
    }
}
