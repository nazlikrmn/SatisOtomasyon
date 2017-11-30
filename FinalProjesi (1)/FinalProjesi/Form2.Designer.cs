namespace FinalProjesi
{
    partial class Form2
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
            this.btnyeniekle = new System.Windows.Forms.Button();
            this.lblbarkotNO = new System.Windows.Forms.Label();
            this.lblmarka = new System.Windows.Forms.Label();
            this.lbltanim = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.txtbarkotNO = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txttanim = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnlistele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnyeniekle
            // 
            this.btnyeniekle.Location = new System.Drawing.Point(54, 157);
            this.btnyeniekle.Name = "btnyeniekle";
            this.btnyeniekle.Size = new System.Drawing.Size(83, 23);
            this.btnyeniekle.TabIndex = 4;
            this.btnyeniekle.Text = "EKLE";
            this.btnyeniekle.UseVisualStyleBackColor = true;
            this.btnyeniekle.Click += new System.EventHandler(this.btnyeniekle_Click);
            // 
            // lblbarkotNO
            // 
            this.lblbarkotNO.AutoSize = true;
            this.lblbarkotNO.Location = new System.Drawing.Point(12, 28);
            this.lblbarkotNO.Name = "lblbarkotNO";
            this.lblbarkotNO.Size = new System.Drawing.Size(57, 13);
            this.lblbarkotNO.TabIndex = 1;
            this.lblbarkotNO.Text = "Barkot NO";
            // 
            // lblmarka
            // 
            this.lblmarka.AutoSize = true;
            this.lblmarka.Location = new System.Drawing.Point(12, 58);
            this.lblmarka.Name = "lblmarka";
            this.lblmarka.Size = new System.Drawing.Size(37, 13);
            this.lblmarka.TabIndex = 2;
            this.lblmarka.Text = "Marka";
            // 
            // lbltanim
            // 
            this.lbltanim.AutoSize = true;
            this.lbltanim.Location = new System.Drawing.Point(12, 85);
            this.lbltanim.Name = "lbltanim";
            this.lbltanim.Size = new System.Drawing.Size(36, 13);
            this.lbltanim.TabIndex = 3;
            this.lbltanim.Text = "Tanım";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(12, 110);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(29, 13);
            this.lblfiyat.TabIndex = 4;
            this.lblfiyat.Text = "Fiyat";
            // 
            // txtbarkotNO
            // 
            this.txtbarkotNO.Location = new System.Drawing.Point(151, 28);
            this.txtbarkotNO.Name = "txtbarkotNO";
            this.txtbarkotNO.Size = new System.Drawing.Size(100, 20);
            this.txtbarkotNO.TabIndex = 0;
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(151, 58);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(100, 20);
            this.txtmarka.TabIndex = 1;
            // 
            // txttanim
            // 
            this.txttanim.Location = new System.Drawing.Point(151, 85);
            this.txttanim.Name = "txttanim";
            this.txttanim.Size = new System.Drawing.Size(100, 20);
            this.txttanim.TabIndex = 2;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(151, 111);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 3;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(176, 157);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 209);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(451, 153);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(339, 375);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 6;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 417);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txttanim);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.txtbarkotNO);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.lbltanim);
            this.Controls.Add(this.lblmarka);
            this.Controls.Add(this.lblbarkotNO);
            this.Controls.Add(this.btnyeniekle);
            this.Name = "Form2";
            this.Text = "Ürün İşlem";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyeniekle;
        private System.Windows.Forms.Label lblbarkotNO;
        private System.Windows.Forms.Label lblmarka;
        private System.Windows.Forms.Label lbltanim;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.TextBox txtbarkotNO;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.TextBox txttanim;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnlistele;
    }
}