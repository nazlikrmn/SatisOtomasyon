namespace FinalProjesi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblbarkot = new System.Windows.Forms.Label();
            this.txtbarkot = new System.Windows.Forms.TextBox();
            this.listurunkod = new System.Windows.Forms.ListView();
            this.btnurunislem = new System.Windows.Forms.Button();
            this.lblmiktar = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblalısverisdetay = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.rdonakit = new System.Windows.Forms.RadioButton();
            this.rdokart = new System.Windows.Forms.RadioButton();
            this.lblodencektutar = new System.Windows.Forms.Label();
            this.txtodencektutar = new System.Windows.Forms.TextBox();
            this.btnkasiyer = new System.Windows.Forms.Button();
            this.btnmusteriislemleri = new System.Windows.Forms.Button();
            this.btnstokislemleri = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSepettenCikar = new System.Windows.Forms.Button();
            this.btnHDefteriGöster = new System.Windows.Forms.Button();
            this.btnSKalemiGöster = new System.Windows.Forms.Button();
            this.chcsonmus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbarkot
            // 
            this.lblbarkot.AutoSize = true;
            this.lblbarkot.Location = new System.Drawing.Point(9, 37);
            this.lblbarkot.Name = "lblbarkot";
            this.lblbarkot.Size = new System.Drawing.Size(57, 13);
            this.lblbarkot.TabIndex = 0;
            this.lblbarkot.Text = "Barkot NO";
            // 
            // txtbarkot
            // 
            this.txtbarkot.Location = new System.Drawing.Point(93, 30);
            this.txtbarkot.Name = "txtbarkot";
            this.txtbarkot.Size = new System.Drawing.Size(120, 20);
            this.txtbarkot.TabIndex = 1;
            // 
            // listurunkod
            // 
            this.listurunkod.Location = new System.Drawing.Point(12, 159);
            this.listurunkod.Name = "listurunkod";
            this.listurunkod.Size = new System.Drawing.Size(620, 158);
            this.listurunkod.TabIndex = 2;
            this.listurunkod.UseCompatibleStateImageBehavior = false;
            // 
            // btnurunislem
            // 
            this.btnurunislem.Location = new System.Drawing.Point(748, 113);
            this.btnurunislem.Name = "btnurunislem";
            this.btnurunislem.Size = new System.Drawing.Size(101, 52);
            this.btnurunislem.TabIndex = 3;
            this.btnurunislem.Text = "Ürün İşlemleri";
            this.btnurunislem.UseVisualStyleBackColor = true;
            this.btnurunislem.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // lblmiktar
            // 
            this.lblmiktar.AutoSize = true;
            this.lblmiktar.Location = new System.Drawing.Point(9, 66);
            this.lblmiktar.Name = "lblmiktar";
            this.lblmiktar.Size = new System.Drawing.Size(36, 13);
            this.lblmiktar.TabIndex = 6;
            this.lblmiktar.Text = "Miktar";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(93, 56);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // lblalısverisdetay
            // 
            this.lblalısverisdetay.AutoSize = true;
            this.lblalısverisdetay.Location = new System.Drawing.Point(9, 143);
            this.lblalısverisdetay.Name = "lblalısverisdetay";
            this.lblalısverisdetay.Size = new System.Drawing.Size(89, 13);
            this.lblalısverisdetay.TabIndex = 8;
            this.lblalısverisdetay.Text = "Alışveriş Detayları";
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(12, 383);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(75, 23);
            this.btnhesapla.TabIndex = 9;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // rdonakit
            // 
            this.rdonakit.AutoSize = true;
            this.rdonakit.Location = new System.Drawing.Point(12, 360);
            this.rdonakit.Name = "rdonakit";
            this.rdonakit.Size = new System.Drawing.Size(50, 17);
            this.rdonakit.TabIndex = 10;
            this.rdonakit.TabStop = true;
            this.rdonakit.Text = "Nakit";
            this.rdonakit.UseVisualStyleBackColor = true;
            // 
            // rdokart
            // 
            this.rdokart.AutoSize = true;
            this.rdokart.Location = new System.Drawing.Point(77, 360);
            this.rdokart.Name = "rdokart";
            this.rdokart.Size = new System.Drawing.Size(73, 17);
            this.rdokart.TabIndex = 11;
            this.rdokart.TabStop = true;
            this.rdokart.Text = "Kredi Kartı";
            this.rdokart.UseVisualStyleBackColor = true;
            // 
            // lblodencektutar
            // 
            this.lblodencektutar.AutoSize = true;
            this.lblodencektutar.Location = new System.Drawing.Point(2, 422);
            this.lblodencektutar.Name = "lblodencektutar";
            this.lblodencektutar.Size = new System.Drawing.Size(85, 13);
            this.lblodencektutar.TabIndex = 13;
            this.lblodencektutar.Text = "Ödenecek Tutar";
            // 
            // txtodencektutar
            // 
            this.txtodencektutar.Enabled = false;
            this.txtodencektutar.Location = new System.Drawing.Point(113, 415);
            this.txtodencektutar.Name = "txtodencektutar";
            this.txtodencektutar.ReadOnly = true;
            this.txtodencektutar.Size = new System.Drawing.Size(100, 20);
            this.txtodencektutar.TabIndex = 14;
            // 
            // btnkasiyer
            // 
            this.btnkasiyer.Location = new System.Drawing.Point(748, 171);
            this.btnkasiyer.Name = "btnkasiyer";
            this.btnkasiyer.Size = new System.Drawing.Size(101, 58);
            this.btnkasiyer.TabIndex = 15;
            this.btnkasiyer.Text = "Kasiyer İşlemleri";
            this.btnkasiyer.UseVisualStyleBackColor = true;
            this.btnkasiyer.Click += new System.EventHandler(this.btnkasiyer_Click);
            // 
            // btnmusteriislemleri
            // 
            this.btnmusteriislemleri.Location = new System.Drawing.Point(748, 235);
            this.btnmusteriislemleri.Name = "btnmusteriislemleri";
            this.btnmusteriislemleri.Size = new System.Drawing.Size(103, 65);
            this.btnmusteriislemleri.TabIndex = 16;
            this.btnmusteriislemleri.Text = "Müşteri İşlemleri";
            this.btnmusteriislemleri.UseVisualStyleBackColor = true;
            this.btnmusteriislemleri.Click += new System.EventHandler(this.btnmusteriislemleri_Click);
            // 
            // btnstokislemleri
            // 
            this.btnstokislemleri.Location = new System.Drawing.Point(746, 306);
            this.btnstokislemleri.Name = "btnstokislemleri";
            this.btnstokislemleri.Size = new System.Drawing.Size(103, 71);
            this.btnstokislemleri.TabIndex = 17;
            this.btnstokislemleri.Text = "Stok İşlemleri";
            this.btnstokislemleri.UseVisualStyleBackColor = true;
            this.btnstokislemleri.Click += new System.EventHandler(this.btnstokislemleri_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 106);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(96, 23);
            this.btnekle.TabIndex = 18;
            this.btnekle.Text = "Sepete Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 19;
            this.button1.Text = "Terminal Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
            // 
            // btnSepettenCikar
            // 
            this.btnSepettenCikar.Location = new System.Drawing.Point(152, 106);
            this.btnSepettenCikar.Name = "btnSepettenCikar";
            this.btnSepettenCikar.Size = new System.Drawing.Size(101, 23);
            this.btnSepettenCikar.TabIndex = 21;
            this.btnSepettenCikar.Text = "Sepetten Çıkar";
            this.btnSepettenCikar.UseVisualStyleBackColor = true;
            this.btnSepettenCikar.Click += new System.EventHandler(this.btnSepettenCikar_Click);
            // 
            // btnHDefteriGöster
            // 
            this.btnHDefteriGöster.Location = new System.Drawing.Point(746, 68);
            this.btnHDefteriGöster.Name = "btnHDefteriGöster";
            this.btnHDefteriGöster.Size = new System.Drawing.Size(101, 39);
            this.btnHDefteriGöster.TabIndex = 22;
            this.btnHDefteriGöster.Text = "Hesap Defterini AÇ";
            this.btnHDefteriGöster.UseVisualStyleBackColor = true;
            this.btnHDefteriGöster.Click += new System.EventHandler(this.btnHDefteriGöster_Click);
            // 
            // btnSKalemiGöster
            // 
            this.btnSKalemiGöster.Location = new System.Drawing.Point(746, 23);
            this.btnSKalemiGöster.Name = "btnSKalemiGöster";
            this.btnSKalemiGöster.Size = new System.Drawing.Size(101, 39);
            this.btnSKalemiGöster.TabIndex = 23;
            this.btnSKalemiGöster.Text = "Satış Kalemini Görüntüle";
            this.btnSKalemiGöster.UseVisualStyleBackColor = true;
            this.btnSKalemiGöster.Click += new System.EventHandler(this.btnSKalemiGöster_Click);
            // 
            // chcsonmus
            // 
            this.chcsonmus.AutoSize = true;
            this.chcsonmus.Location = new System.Drawing.Point(173, 360);
            this.chcsonmus.Name = "chcsonmus";
            this.chcsonmus.Size = new System.Drawing.Size(146, 17);
            this.chcsonmus.TabIndex = 24;
            this.chcsonmus.Text = "son müşteri bilgisini kullan";
            this.chcsonmus.UseVisualStyleBackColor = true;
            this.chcsonmus.CheckedChanged += new System.EventHandler(this.chcsonmus_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 464);
            this.Controls.Add(this.chcsonmus);
            this.Controls.Add(this.btnSKalemiGöster);
            this.Controls.Add(this.btnHDefteriGöster);
            this.Controls.Add(this.btnSepettenCikar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnstokislemleri);
            this.Controls.Add(this.btnmusteriislemleri);
            this.Controls.Add(this.btnkasiyer);
            this.Controls.Add(this.txtodencektutar);
            this.Controls.Add(this.lblodencektutar);
            this.Controls.Add(this.rdokart);
            this.Controls.Add(this.rdonakit);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.lblalısverisdetay);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblmiktar);
            this.Controls.Add(this.btnurunislem);
            this.Controls.Add(this.listurunkod);
            this.Controls.Add(this.txtbarkot);
            this.Controls.Add(this.lblbarkot);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ANA MENÜ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbarkot;
        private System.Windows.Forms.TextBox txtbarkot;
        private System.Windows.Forms.ListView listurunkod;
        private System.Windows.Forms.Button btnurunislem;
        private System.Windows.Forms.Label lblmiktar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblalısverisdetay;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.RadioButton rdonakit;
        private System.Windows.Forms.RadioButton rdokart;
        private System.Windows.Forms.Label lblodencektutar;
        private System.Windows.Forms.TextBox txtodencektutar;
        private System.Windows.Forms.Button btnkasiyer;
        private System.Windows.Forms.Button btnmusteriislemleri;
        private System.Windows.Forms.Button btnstokislemleri;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSepettenCikar;
        private System.Windows.Forms.Button btnHDefteriGöster;
        private System.Windows.Forms.Button btnSKalemiGöster;
        private System.Windows.Forms.CheckBox chcsonmus;
    }
}

