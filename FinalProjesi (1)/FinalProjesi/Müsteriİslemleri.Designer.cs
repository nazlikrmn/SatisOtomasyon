namespace FinalProjesi
{
    partial class Müsteriİslemleri
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
            this.lblmusteriad = new System.Windows.Forms.Label();
            this.lblmusterisoyad = new System.Windows.Forms.Label();
            this.txtmsuteriad = new System.Windows.Forms.TextBox();
            this.txtmusterisoyad = new System.Windows.Forms.TextBox();
            this.btnmusteriekle = new System.Windows.Forms.Button();
            this.listmusteri = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblmusteriad
            // 
            this.lblmusteriad.AutoSize = true;
            this.lblmusteriad.Location = new System.Drawing.Point(12, 37);
            this.lblmusteriad.Name = "lblmusteriad";
            this.lblmusteriad.Size = new System.Drawing.Size(22, 13);
            this.lblmusteriad.TabIndex = 0;
            this.lblmusteriad.Text = "AD";
            // 
            // lblmusterisoyad
            // 
            this.lblmusterisoyad.AutoSize = true;
            this.lblmusterisoyad.Location = new System.Drawing.Point(12, 69);
            this.lblmusterisoyad.Name = "lblmusterisoyad";
            this.lblmusterisoyad.Size = new System.Drawing.Size(44, 13);
            this.lblmusterisoyad.TabIndex = 1;
            this.lblmusterisoyad.Text = "SOYAD";
            // 
            // txtmsuteriad
            // 
            this.txtmsuteriad.Location = new System.Drawing.Point(109, 30);
            this.txtmsuteriad.Name = "txtmsuteriad";
            this.txtmsuteriad.Size = new System.Drawing.Size(100, 20);
            this.txtmsuteriad.TabIndex = 0;
            // 
            // txtmusterisoyad
            // 
            this.txtmusterisoyad.Location = new System.Drawing.Point(109, 62);
            this.txtmusterisoyad.Name = "txtmusterisoyad";
            this.txtmusterisoyad.Size = new System.Drawing.Size(100, 20);
            this.txtmusterisoyad.TabIndex = 1;
            // 
            // btnmusteriekle
            // 
            this.btnmusteriekle.Location = new System.Drawing.Point(134, 132);
            this.btnmusteriekle.Name = "btnmusteriekle";
            this.btnmusteriekle.Size = new System.Drawing.Size(75, 23);
            this.btnmusteriekle.TabIndex = 2;
            this.btnmusteriekle.Text = "EKLE";
            this.btnmusteriekle.UseVisualStyleBackColor = true;
            this.btnmusteriekle.Click += new System.EventHandler(this.btnmusteriekle_Click);
            // 
            // listmusteri
            // 
            this.listmusteri.FormattingEnabled = true;
            this.listmusteri.Location = new System.Drawing.Point(304, 12);
            this.listmusteri.Name = "listmusteri";
            this.listmusteri.Size = new System.Drawing.Size(312, 342);
            this.listmusteri.TabIndex = 6;
            // 
            // Müsteriİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 362);
            this.Controls.Add(this.listmusteri);
            this.Controls.Add(this.btnmusteriekle);
            this.Controls.Add(this.txtmusterisoyad);
            this.Controls.Add(this.txtmsuteriad);
            this.Controls.Add(this.lblmusterisoyad);
            this.Controls.Add(this.lblmusteriad);
            this.Name = "Müsteriİslemleri";
            this.Text = "Müşteri İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmusteriad;
        private System.Windows.Forms.Label lblmusterisoyad;
        private System.Windows.Forms.TextBox txtmsuteriad;
        private System.Windows.Forms.TextBox txtmusterisoyad;
        private System.Windows.Forms.Button btnmusteriekle;
        private System.Windows.Forms.ListBox listmusteri;
    }
}