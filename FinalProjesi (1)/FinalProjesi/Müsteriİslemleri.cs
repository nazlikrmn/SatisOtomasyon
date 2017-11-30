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
    public partial class Müsteriİslemleri : Form
    {
        public Müsteriİslemleri()
        {
            InitializeComponent();
        }
        public string ad, soyad;
        private void btnmusteriekle_Click(object sender, EventArgs e)
        {
            
            ad = txtmsuteriad.Text;
            soyad = txtmusterisoyad.Text;
            string temp = " ";

            Musteri musteri = new Musteri(ad, soyad);
            musteri.MusteriEkle(musteri);

            if (musteri.musteriListesi == null)
                MessageBox.Show("Hiç kayıtlı müşteri yok.");
            else
            {
                
                foreach (Musteri m in musteri.musteriListesi)
                {
                    temp += m.isim + " " + m.soyad + "\n";
                }


            }
            listmusteri.Items.Add(temp);
            MessageBox.Show("ekleme başarılı!");

            txtmsuteriad.Text = "";
            txtmusterisoyad.Text = "";

           
        }
    }
}
