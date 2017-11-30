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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Ürünler", 100, HorizontalAlignment.Left);
            for (int i = 0; i < 100; i++)
            {
                listView1.Columns[0].Width = 1100;
            }

        }

        Form1 frm1 = new Form1();
        UrunKatalogu urunKatalogu = UrunKatalogu.k();

       

        private void btnyeniekle_Click(object sender, EventArgs e)
        {
            Urun u = new Urun(Convert.ToDecimal(txtfiyat.Text), Convert.ToInt16(txtbarkotNO.Text));
            u.Tanim = txttanim.Text;
            u.UrunAdi = txtmarka.Text;

            urunKatalogu.Ekle(u);     
                   
            MessageBox.Show("ürün ekleme başarılı");//Yeni ürün girilebilmesi için textBox ları temizler.
            txtbarkotNO.Text = "";
            txtfiyat.Text = "";
            txtmarka.Text = "";
            txttanim.Text = "";

            Stokİslem stk = new Stokİslem();
            stk.Show();
            this.Hide();
            
            
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            int Barkod = Convert.ToInt16(txtbarkotNO.Text);
            urunKatalogu.Cikar(Barkod);
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string a=urunKatalogu.Listele();
            string eklenecek = " ";
            foreach (char karakter in a)
            {
                if(karakter==' ')
                {
                    listView1.Items.Add(eklenecek);
                    eklenecek = " ";
                }
                else
                {
                    eklenecek += karakter;
                }
            }
        }
    }
}
