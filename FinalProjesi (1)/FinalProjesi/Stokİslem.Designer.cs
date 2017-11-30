namespace FinalProjesi
{
    partial class Stokİslem
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
            this.lblbarkodno = new System.Windows.Forms.Label();
            this.lblmiktar = new System.Windows.Forms.Label();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.btnstokekle = new System.Windows.Forms.Button();
            this.liststok = new System.Windows.Forms.ListBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbarkodno
            // 
            this.lblbarkodno.AutoSize = true;
            this.lblbarkodno.Location = new System.Drawing.Point(24, 36);
            this.lblbarkodno.Name = "lblbarkodno";
            this.lblbarkodno.Size = new System.Drawing.Size(58, 13);
            this.lblbarkodno.TabIndex = 0;
            this.lblbarkodno.Text = "Barkod No";
            // 
            // lblmiktar
            // 
            this.lblmiktar.AutoSize = true;
            this.lblmiktar.Location = new System.Drawing.Point(24, 79);
            this.lblmiktar.Name = "lblmiktar";
            this.lblmiktar.Size = new System.Drawing.Size(36, 13);
            this.lblmiktar.TabIndex = 1;
            this.lblmiktar.Text = "Miktar";
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(135, 29);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(100, 20);
            this.txtbarkod.TabIndex = 0;
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(135, 72);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(100, 20);
            this.txtmiktar.TabIndex = 1;
            // 
            // btnstokekle
            // 
            this.btnstokekle.Location = new System.Drawing.Point(160, 117);
            this.btnstokekle.Name = "btnstokekle";
            this.btnstokekle.Size = new System.Drawing.Size(75, 23);
            this.btnstokekle.TabIndex = 3;
            this.btnstokekle.Text = "EKLE";
            this.btnstokekle.UseVisualStyleBackColor = true;
            this.btnstokekle.Click += new System.EventHandler(this.btnstokekle_Click);
            // 
            // liststok
            // 
            this.liststok.FormattingEnabled = true;
            this.liststok.Location = new System.Drawing.Point(12, 159);
            this.liststok.Name = "liststok";
            this.liststok.Size = new System.Drawing.Size(328, 147);
            this.liststok.TabIndex = 5;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(265, 327);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 4;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // Stokİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 391);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.liststok);
            this.Controls.Add(this.btnstokekle);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.txtbarkod);
            this.Controls.Add(this.lblmiktar);
            this.Controls.Add(this.lblbarkodno);
            this.Name = "Stokİslem";
            this.Text = "Stok İşlem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbarkodno;
        private System.Windows.Forms.Label lblmiktar;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Button btnstokekle;
        private System.Windows.Forms.ListBox liststok;
        private System.Windows.Forms.Button btnlistele;
    }
}