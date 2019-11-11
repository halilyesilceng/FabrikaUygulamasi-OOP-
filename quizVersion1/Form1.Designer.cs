namespace quizVersion1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListeyeEkle = new System.Windows.Forms.Button();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.lblBirim = new System.Windows.Forms.Label();
            this.btnListeyiGoster = new System.Windows.Forms.Button();
            this.txtListeyiGoster = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListeyeEkle
            // 
            this.btnListeyeEkle.Location = new System.Drawing.Point(224, 186);
            this.btnListeyeEkle.Name = "btnListeyeEkle";
            this.btnListeyeEkle.Size = new System.Drawing.Size(196, 23);
            this.btnListeyeEkle.TabIndex = 5;
            this.btnListeyeEkle.Text = "Listeye Ekle";
            this.btnListeyeEkle.UseVisualStyleBackColor = true;
            this.btnListeyeEkle.Click += new System.EventHandler(this.BtnListeyeEkle_Click);
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Location = new System.Drawing.Point(114, 65);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(94, 17);
            this.lblPersonelNo.TabIndex = 1;
            this.lblPersonelNo.Text = "Personel No :";
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(224, 60);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(100, 22);
            this.txtPersonelNo.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(224, 94);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(196, 22);
            this.txtAd.TabIndex = 2;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(152, 99);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(33, 17);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(224, 126);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(196, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(152, 131);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(56, 17);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyad :";
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(224, 158);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(196, 22);
            this.txtBirim.TabIndex = 4;
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(152, 163);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(39, 17);
            this.lblBirim.TabIndex = 7;
            this.lblBirim.Text = "Birim";
            // 
            // btnListeyiGoster
            // 
            this.btnListeyiGoster.Location = new System.Drawing.Point(155, 220);
            this.btnListeyiGoster.Name = "btnListeyiGoster";
            this.btnListeyiGoster.Size = new System.Drawing.Size(474, 23);
            this.btnListeyiGoster.TabIndex = 6;
            this.btnListeyiGoster.Text = "Listeyi Göster";
            this.btnListeyiGoster.UseVisualStyleBackColor = true;
            this.btnListeyiGoster.Click += new System.EventHandler(this.btnListeyiGoster_Click);
            // 
            // txtListeyiGoster
            // 
            this.txtListeyiGoster.Location = new System.Drawing.Point(155, 249);
            this.txtListeyiGoster.Multiline = true;
            this.txtListeyiGoster.Name = "txtListeyiGoster";
            this.txtListeyiGoster.Size = new System.Drawing.Size(474, 202);
            this.txtListeyiGoster.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtListeyiGoster);
            this.Controls.Add(this.btnListeyiGoster);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtPersonelNo);
            this.Controls.Add(this.lblPersonelNo);
            this.Controls.Add(this.btnListeyeEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListeyeEkle;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Button btnListeyiGoster;
        private System.Windows.Forms.TextBox txtListeyiGoster;
    }
}

