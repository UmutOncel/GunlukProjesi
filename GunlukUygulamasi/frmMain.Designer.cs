namespace GunlukUygulamasi
{
    partial class frmMain
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
            msMain = new MenuStrip();
            tsmSifreIslemleri = new ToolStripMenuItem();
            tsmSifreOlustur = new ToolStripMenuItem();
            tsmSifreGir = new ToolStripMenuItem();
            tsmYeniGunlukSayfasiOlustur = new ToolStripMenuItem();
            msMain.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.BackColor = Color.Lavender;
            msMain.Items.AddRange(new ToolStripItem[] { tsmSifreIslemleri, tsmYeniGunlukSayfasiOlustur });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(831, 24);
            msMain.TabIndex = 1;
            msMain.Text = "menuStrip1";
            // 
            // tsmSifreIslemleri
            // 
            tsmSifreIslemleri.DropDownItems.AddRange(new ToolStripItem[] { tsmSifreOlustur, tsmSifreGir });
            tsmSifreIslemleri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tsmSifreIslemleri.Name = "tsmSifreIslemleri";
            tsmSifreIslemleri.Size = new Size(97, 20);
            tsmSifreIslemleri.Text = "Şifre İşlemleri";
            // 
            // tsmSifreOlustur
            // 
            tsmSifreOlustur.Name = "tsmSifreOlustur";
            tsmSifreOlustur.Size = new Size(180, 22);
            tsmSifreOlustur.Text = "Şifre Oluştur";
            tsmSifreOlustur.Click += tsmSifreOlustur_Click;
            // 
            // tsmSifreGir
            // 
            tsmSifreGir.Name = "tsmSifreGir";
            tsmSifreGir.Size = new Size(180, 22);
            tsmSifreGir.Text = "Şifre Gir";
            tsmSifreGir.Click += tsmSifreGir_Click;
            // 
            // tsmYeniGunlukSayfasiOlustur
            // 
            tsmYeniGunlukSayfasiOlustur.Enabled = false;
            tsmYeniGunlukSayfasiOlustur.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tsmYeniGunlukSayfasiOlustur.Name = "tsmYeniGunlukSayfasiOlustur";
            tsmYeniGunlukSayfasiOlustur.Size = new Size(170, 20);
            tsmYeniGunlukSayfasiOlustur.Text = "Yeni Günlük Sayfası Oluştur";
            tsmYeniGunlukSayfasiOlustur.Click += tsmYeniGunlukSayfasiOlustur_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 453);
            Controls.Add(msMain);
            IsMdiContainer = true;
            MainMenuStrip = msMain;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Günlük Yazma Uygulaması";
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem tsmSifreIslemleri;
        private ToolStripMenuItem tsmSifreOlustur;
        private ToolStripMenuItem tsmSifreGir;
        private ToolStripMenuItem tsmYeniGunlukSayfasiOlustur;
    }
}