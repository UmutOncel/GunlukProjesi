namespace GunlukUygulamasi
{
    partial class frmGunlukOku
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
            rtbGunluk = new RichTextBox();
            pbResim = new PictureBox();
            ofdGunlukOku = new OpenFileDialog();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // rtbGunluk
            // 
            rtbGunluk.Enabled = false;
            rtbGunluk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbGunluk.Location = new Point(32, 218);
            rtbGunluk.Name = "rtbGunluk";
            rtbGunluk.Size = new Size(661, 189);
            rtbGunluk.TabIndex = 2;
            rtbGunluk.Text = "";
            // 
            // pbResim
            // 
            pbResim.BackColor = Color.Transparent;
            pbResim.BackgroundImageLayout = ImageLayout.Zoom;
            pbResim.Enabled = false;
            pbResim.Location = new Point(32, 23);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(346, 189);
            pbResim.SizeMode = PictureBoxSizeMode.Zoom;
            pbResim.TabIndex = 3;
            pbResim.TabStop = false;
            // 
            // ofdGunlukOku
            // 
            ofdGunlukOku.FileName = "openFileDialog1";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Gainsboro;
            btnKaydet.Enabled = false;
            btnKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(601, 413);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(92, 32);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // frmGunlukOku
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6_Oku;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(720, 457);
            Controls.Add(btnKaydet);
            Controls.Add(pbResim);
            Controls.Add(rtbGunluk);
            Name = "frmGunlukOku";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Günlük Oku";
            Load += frmGunlukOku_Load;
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox rtbGunluk;
        private PictureBox pbResim;
        private OpenFileDialog ofdGunlukOku;
        private Button btnKaydet;
    }
}