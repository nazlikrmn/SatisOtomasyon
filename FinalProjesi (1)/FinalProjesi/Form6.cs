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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        
        KasaGorevlisi Kasa = KasaGorevlisi.kG();
        //Eklerken tanımlamaya ihtiyacım yoktu fakat kasiyer listesini kullanmalıyım.
        private void btnkasiyerekle_Click(object sender, EventArgs e)
        {
            ulong TcKimlikNo = Convert.ToUInt32(txtno.Text),
                 SgkNo = Convert.ToUInt32(txtsgkno.Text);
            int sifre = Convert.ToInt16(txtsifrebelirle.Text);
            string k = "";
            listkasiyer.Items.Clear();
            
            KasaGorevlisi kasaGorevlisi = new KasaGorevlisi(TcKimlikNo,SgkNo,sifre);
            kasaGorevlisi.ad = txtkasiyerad.Text;
            kasaGorevlisi.soyad = txtkasiyersoyad.Text;
//Yeni bir kasa görevlisi tanımlandı.
            Kasa.KasiyerEkle(kasaGorevlisi);
//Kasa görevlisi listeye eklendi.
            MessageBox.Show(kasaGorevlisi.ad + " " + kasaGorevlisi.soyad +"Eklendi!!");

            foreach (KasaGorevlisi görevli in Kasa.kasiyer)
            {
               
                k += görevli.KasiyerNo + "\t" + görevli.ad + " " + görevli.soyad+"\n";
                
            }
            listkasiyer.Items.Add(k);
            txtkasiyerad.Text = "";
            txtkasiyersoyad.Text = "";
            txtsgkno.Text = "";
            txtno.Text = "";
            txtsifrebelirle.Text = "";
            
            
        }


        private void btncikar_Click(object sender, EventArgs e)
        {
            int KasiyerNo = Convert.ToInt16(txtkasiyerno.Text);
            foreach (KasaGorevlisi k in Kasa.kasiyer)
            {
                if (KasiyerNo == k.KasiyerNo)
                {
                    Kasa.KasiyerCikar(k);
                    MessageBox.Show(k.ad + "Çıkarıldı");
                }
                else
                    continue;
            }   
                     
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
