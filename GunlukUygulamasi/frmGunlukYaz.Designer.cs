namespace GunlukUygulamasi
{
    partial class frmGunlukYaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGunlukYaz));
            rtbGunlukMetni = new RichTextBox();
            txtGunlukBasligi = new TextBox();
            btnKaydet = new Button();
            pbResim = new PictureBox();
            btnResimSil = new Button();
            btnResimEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // rtbGunlukMetni
            // 
            rtbGunlukMetni.BackColor = Color.Beige;
            rtbGunlukMetni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbGunlukMetni.ForeColor = Color.SaddleBrown;
            rtbGunlukMetni.Location = new Point(99, 116);
            rtbGunlukMetni.Name = "rtbGunlukMetni";
            rtbGunlukMetni.Size = new Size(250, 321);
            rtbGunlukMetni.TabIndex = 0;
            rtbGunlukMetni.Text = "#NOTLARINIZ#";
            rtbGunlukMetni.Click += rtbGunlukMetni_Click;
            // 
            // txtGunlukBasligi
            // 
            txtGunlukBasligi.BackColor = Color.Beige;
            txtGunlukBasligi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtGunlukBasligi.ForeColor = Color.SaddleBrown;
            txtGunlukBasligi.Location = new Point(99, 81);
            txtGunlukBasligi.Name = "txtGunlukBasligi";
            txtGunlukBasligi.Size = new Size(250, 29);
            txtGunlukBasligi.TabIndex = 1;
            txtGunlukBasligi.Text = "#BAŞLIĞINIZ#";
            txtGunlukBasligi.Click += txtGunlukBasligi_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Transparent;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.DarkGoldenrod;
            btnKaydet.Location = new Point(475, 408);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(128, 29);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // pbResim
            // 
            pbResim.BackColor = Color.Transparent;
            pbResim.BackgroundImageLayout = ImageLayout.Zoom;
            pbResim.Location = new Point(419, 107);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(241, 178);
            pbResim.SizeMode = PictureBoxSizeMode.Zoom;
            pbResim.TabIndex = 0;
            pbResim.TabStop = false;
            // 
            // btnResimSil
            // 
            btnResimSil.BackColor = Color.Transparent;
            btnResimSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnResimSil.ForeColor = Color.DarkGoldenrod;
            btnResimSil.Location = new Point(544, 291);
            btnResimSil.Name = "btnResimSil";
            btnResimSil.Size = new Size(116, 29);
            btnResimSil.TabIndex = 1;
            btnResimSil.Text = "Resim Sil";
            btnResimSil.UseVisualStyleBackColor = false;
            btnResimSil.Click += btnResimSil_Click;
            // 
            // btnResimEkle
            // 
            btnResimEkle.BackColor = Color.Transparent;
            btnResimEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnResimEkle.ForeColor = Color.DarkGoldenrod;
            btnResimEkle.Location = new Point(419, 291);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(116, 29);
            btnResimEkle.TabIndex = 1;
            btnResimEkle.Text = "Resim Ekle";
            btnResimEkle.UseVisualStyleBackColor = false;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // frmGunlukYaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(765, 516);
            Controls.Add(rtbGunlukMetni);
            Controls.Add(pbResim);
            Controls.Add(txtGunlukBasligi);
            Controls.Add(btnResimSil);
            Controls.Add(btnKaydet);
            Controls.Add(btnResimEkle);
            Name = "frmGunlukYaz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Klasör Oluştur ve Günlük Yaz";
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtbGunlukMetni;
        private Button btnKaydet;
        private PictureBox pbResim;
        private Button btnResimEkle;
        private Button btnResimSil;
        private TextBox txtGunlukBasligi;
    }
}