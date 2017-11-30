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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void btnekle_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listurunkod.View = View.Details;
            listurunkod.Columns.Add("Ürünler", 100, HorizontalAlignment.Left);
            for (int i = 0; i < 100; i++)
            {
                listurunkod.Columns[0].Width = 1100;
                
            }

        }

        private void btnkasiyer_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }
        Terminal terminal = new Terminal();
        UrunKatalogu katalog =UrunKatalogu.k();//doğru ürünü bulmak için
        SatısKalemi satisK =SatısKalemi.satisKlm();//kayıt
        Satıs satis = Satıs.Sts();
        decimal Ucret { get; set; }
        private void btnekle_Click_1(object sender, EventArgs e)
        {
            int Kod = Convert.ToInt16(txtbarkot.Text);
            int miktar = Convert.ToInt16(numericUpDown1.Value);
            int sayac= 0;

            foreach (Urun u in katalog.urunKatalogu)
            {
                if (u.Urunkodu == Kod)
                {
                    sayac++;
                    terminal.SatisaYonlendir(u, miktar);//Satıştaki değişkenlere ilgili değerler verildi
                    satis.SatilanListesi.Add(u.UrunAdi + (u.BirimFiyati * miktar).ToString()+"\n");
                    listurunkod.Items.Add(u.UrunAdi+"----"+miktar.ToString()+"----"+u.BirimFiyati*miktar);//form1 de gösterildi
                    Ucret +=Convert.ToDecimal(u.BirimFiyati * miktar);
                    satisK.SatisEkle(u.UrunAdi, miktar);
                    txtodencektutar.Text = Ucret.ToString();
                }
                else
                    continue;
            }
            if(sayac==0)
            {
                MessageBox.Show("Ürün bulunamadi");
            }
        }

        private void btnSepettenCikar_Click(object sender, EventArgs e)
        {
            int Kod = Convert.ToInt16(txtbarkot.Text);
            int miktar = Convert.ToInt16(numericUpDown1.Value);
            int sayac = 0;

            foreach (Urun u in katalog.urunKatalogu)
            {
                if (u.Urunkodu == Kod)
                {
                    sayac++;
                    satis.SatilanListesi.Remove(u.UrunAdi + (u.BirimFiyati * miktar).ToString());
                    u.StoktakiMiktar += miktar;
                    listurunkod.Items.Add(miktar + " adet " + u.UrunAdi + "sepetten çıkarıldı");
                    Ucret -= Convert.ToDecimal(u.BirimFiyati * miktar);
                    satisK.Kalem.Remove(u.UrunAdi + "\t" + miktar.ToString());

                }
                else continue;
            }
            if(sayac==0)
            {
                MessageBox.Show("Ürün sepette bulunamadı.");
            }
        }

        HesapDefteri hesapDefteri = HesapDefteri.Defter();
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            Musteri m = Musteri.Mstr();

            if (chcsonmus.Checked == true)
            {
                
                Random rnd = new Random();
                satis.satisKodu = rnd.Next();
                decimal OdemeMiktari = Ucret;

                if (rdokart.Checked == true)
                {
                    Ödeme O = new Ödeme(OdemeMiktari, "Kartla ödeme.");
                    MessageBox.Show("tutar:" + Ucret.ToString() + "TL\n"+"musteri:" + i.ad+" "+i.soyad +"\n"+ O.SatisSonu());
                    listurunkod.Items.Clear();
                }
                else if (rdonakit.Checked == true)
                {
                    Ödeme O1 = new Ödeme(OdemeMiktari, "Nakit ödeme.");
                    MessageBox.Show("tutar:" + Ucret.ToString() + "TL\n" +"musteri:"+i.ad +" "+ i.soyad + "\n"+ O1.SatisSonu());
                    listurunkod.Items.Clear();

                }
                else
                    MessageBox.Show("Lütfen bir ödeme türü seçiniz.");

                //Buraya kadar satılan ürün ve fiyat bildirimi.. Burdan sonra Hesap defteri kaydı.

                hesapDefteri.HesapDefterineEkle(satis.satisKodu, Ucret);
                txtbarkot.Text = "";
                numericUpDown1.Value = 0;
                listurunkod.Items.Clear();

                rdokart.Checked = false;
                rdonakit.Checked = false;
                Ucret = 0;
                for (int i = 0; i < satis.SatilanListesi.Count; i++)
                {
                    satis.SatilanListesi.RemoveAt(i);
                }

            }
            else
            {
                Müsteriİslemleri musteriIsl = new Müsteriİslemleri();
                musteriIsl.Show();
            }

           
        }
        Müsteriİslemleri i = new Müsteriİslemleri();
        private void btnmusteriislemleri_Click(object sender, EventArgs e)
        {
            i.Show();
        }

        private void btnstokislemleri_Click(object sender, EventArgs e)
        {
            Stokİslem s = new Stokİslem();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Terminal YeniTerminal = new Terminal();
            YeniTerminal.terminaller.Add(YeniTerminal);
            MessageBox.Show(YeniTerminal.SeriNo + "Oluşturuldu.");
        }

        private void btnHDefteriGöster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hesapDefteri.Listele());
        }

        private void btnSKalemiGöster_Click(object sender, EventArgs e)
        {
            string kalem = " ";
            foreach (string s in satisK.Kalem)
            {
                kalem += s+"\n";
            }
            MessageBox.Show(kalem);
        }

        private void chcsonmus_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
