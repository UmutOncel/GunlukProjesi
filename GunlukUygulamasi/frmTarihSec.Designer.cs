namespace GunlukUygulamasi
{
    partial class frmTarihSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarihSec));
            mcTakvim = new MonthCalendar();
            lblSeciliTarih = new Label();
            btnGunlukOlustur = new Button();
            gbTarihSec = new GroupBox();
            gbGunlukleriListele = new GroupBox();
            btnGunlukListele = new Button();
            lstGunlukler = new ListBox();
            gbTarihSec.SuspendLayout();
            gbGunlukleriListele.SuspendLayout();
            SuspendLayout();
            // 
            // mcTakvim
            // 
            mcTakvim.Location = new Point(12, 28);
            mcTakvim.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            mcTakvim.Name = "mcTakvim";
            mcTakvim.TabIndex = 0;
            mcTakvim.TitleBackColor = Color.SandyBrown;
            mcTakvim.TitleForeColor = Color.SaddleBrown;
            mcTakvim.DateSelected += mcTakvim_DateSelected;
            // 
            // lblSeciliTarih
            // 
            lblSeciliTarih.BackColor = Color.White;
            lblSeciliTarih.BorderStyle = BorderStyle.FixedSingle;
            lblSeciliTarih.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeciliTarih.ForeColor = Color.DarkViolet;
            lblSeciliTarih.Location = new Point(12, 199);
            lblSeciliTarih.Name = "lblSeciliTarih";
            lblSeciliTarih.Size = new Size(234, 32);
            lblSeciliTarih.TabIndex = 1;
            lblSeciliTarih.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGunlukOlustur
            // 
            btnGunlukOlustur.BackColor = Color.Ivory;
            btnGunlukOlustur.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGunlukOlustur.ForeColor = Color.DarkViolet;
            btnGunlukOlustur.Location = new Point(12, 243);
            btnGunlukOlustur.Name = "btnGunlukOlustur";
            btnGunlukOlustur.Size = new Size(234, 32);
            btnGunlukOlustur.TabIndex = 2;
            btnGunlukOlustur.Text = "Tarihi Onayla ve Günlük Oluştur";
            btnGunlukOlustur.UseVisualStyleBackColor = false;
            btnGunlukOlustur.Click += btnGunlukOlustur_Click;
            // 
            // gbTarihSec
            // 
            gbTarihSec.BackColor = Color.Transparent;
            gbTarihSec.Controls.Add(mcTakvim);
            gbTarihSec.Controls.Add(lblSeciliTarih);
            gbTarihSec.Controls.Add(btnGunlukOlustur);
            gbTarihSec.ForeColor = Color.White;
            gbTarihSec.Location = new Point(12, 66);
            gbTarihSec.Name = "gbTarihSec";
            gbTarihSec.Size = new Size(267, 290);
            gbTarihSec.TabIndex = 3;
            gbTarihSec.TabStop = false;
            gbTarihSec.Text = "Tarih Seç";
            // 
            // gbGunlukleriListele
            // 
            gbGunlukleriListele.BackColor = Color.Transparent;
            gbGunlukleriListele.Controls.Add(btnGunlukListele);
            gbGunlukleriListele.Controls.Add(lstGunlukler);
            gbGunlukleriListele.ForeColor = Color.White;
            gbGunlukleriListele.Location = new Point(312, 66);
            gbGunlukleriListele.Name = "gbGunlukleriListele";
            gbGunlukleriListele.Size = new Size(428, 333);
            gbGunlukleriListele.TabIndex = 3;
            gbGunlukleriListele.TabStop = false;
            gbGunlukleriListele.Text = "Günlükleri Listele";
            // 
            // btnGunlukListele
            // 
            btnGunlukListele.BackColor = Color.Ivory;
            btnGunlukListele.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGunlukListele.ForeColor = Color.DarkViolet;
            btnGunlukListele.Location = new Point(6, 293);
            btnGunlukListele.Name = "btnGunlukListele";
            btnGunlukListele.Size = new Size(234, 32);
            btnGunlukListele.TabIndex = 2;
            btnGunlukListele.Text = "Kaydedilen Günlükleri Listele";
            btnGunlukListele.UseVisualStyleBackColor = false;
            btnGunlukListele.Click += btnGunlukListele_Click;
            // 
            // lstGunlukler
            // 
            lstGunlukler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstGunlukler.ForeColor = Color.DarkViolet;
            lstGunlukler.FormattingEnabled = true;
            lstGunlukler.ItemHeight = 17;
            lstGunlukler.Location = new Point(6, 28);
            lstGunlukler.Name = "lstGunlukler";
            lstGunlukler.Size = new Size(410, 259);
            lstGunlukler.TabIndex = 1;
            lstGunlukler.DoubleClick += lstGunlukler_DoubleClick;
            // 
            // frmTarihSec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(750, 492);
            Controls.Add(gbGunlukleriListele);
            Controls.Add(gbTarihSec);
            Name = "frmTarihSec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarih Seç ve Günlük Listesini Gör";
            Load += frmTarihSec_Load;
            gbTarihSec.ResumeLayout(false);
            gbGunlukleriListele.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar mcTakvim;
        private Label lblSeciliTarih;
        private Button btnGunlukOlustur;
        private GroupBox gbTarihSec;
        private GroupBox gbGunlukleriListele;
        private ListBox lstGunlukler;
        private Button btnGunlukListele;
    }
}