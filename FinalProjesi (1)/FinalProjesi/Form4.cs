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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        KasaGorevlisi kasaGörevlisi = KasaGorevlisi.kG();
        Form1 f = new Form1();
        private void btngiris_Click(object sender, EventArgs e)//-------txtkullaniciadi degil txtNumara falan olmali!!!
        {

            int No = Convert.ToInt16(txtkullaniciadi.Text);
            int Sifre = Convert.ToInt16(txtsifre.Text);
            if (Sifre == 1100 && No == 1)
            {
                this.Hide();
                f.Show();
            }
            //Kasiyer numarasina ait bir kasiyer var ise Sifre kontrolü yapar.
            foreach (KasaGorevlisi k in kasaGörevlisi.kasiyer)
            {
                if (No == k.KasiyerNo)
                {
                    if (Sifre == k.KasiyerSifresi)
                    {
                        
                        f.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Yanlis sifre yada Kasiyer Numarasi!");
                        txtkullaniciadi.Text = " ";
                        txtsifre.Text = " ";
                    }
                }
                else continue;
            }

        }
    }
}
