using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjesi
{
    public partial class Stokİslem : Form
    {
        public Stokİslem()
        {
            InitializeComponent();
        }
        UrunKatalogu u=UrunKatalogu.k();
        HesapDefteri hesap = HesapDefteri.Defter();
        private void btnstokekle_Click(object sender, EventArgs e)
        {
           
            int kod = Convert.ToInt16(txtbarkod.Text),sayac=0;
            int EklenecekMiktar = Convert.ToInt16(txtmiktar.Text);
            
            int i;
            foreach (Urun urun1 in u.urunKatalogu)
            {
                if (urun1.Urunkodu == kod)
                {
                    urun1.StoktakiMiktar += EklenecekMiktar;//stoğa x kadar ürün ekle
                    hesap.Ekle(urun1);
                    sayac++;
                    if (hesap.BitenUrun != null)
                    {
                       // foreach (string yenigelen in hesap.BitenUrun)
                            for ( i=hesap.BitenUrun.Count-1;i>0;i--)//Yeni eklenen ürün bitenler listesindeyse kaldır ve stoktakiler e ekle.
                        {

                            if (hesap.BitenUrun[i] == urun1.UrunAdi)
                            {
                                hesap.BitenUrun.Remove(urun1.UrunAdi);
                                hesap.StoktakiUrunler.Add(urun1.UrunAdi);
                                
                                break;
                            }
                            else continue;
                        }
                        MessageBox.Show("ürün eklendi!");
                        
                    }
                   }
                else continue;
            }
            if (sayac == 0)
                MessageBox.Show("Ürün katalogda bulunamadi");
            
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            liststok.Items.Clear();
            string s = "";
            foreach(Urun urun1 in u.urunKatalogu)
            {
                s =" kod: "+ urun1.Urunkodu+" stokmiktarı: " + urun1.StoktakiMiktar+ " ad: " + urun1.UrunAdi + " birimfiyat: "+ urun1.BirimFiyati+" tanım: "+urun1.Tanim+"\n";
                liststok.Items.Add(s);
            }
            
        }
    }
}
