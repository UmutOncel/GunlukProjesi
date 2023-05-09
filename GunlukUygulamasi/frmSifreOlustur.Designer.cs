namespace GunlukUygulamasi
{
    partial class frmSifreOlustur
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
            label1 = new Label();
            txtSifre = new TextBox();
            btnSifreOlustur = new Button();
            chkSifreyiGoster = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(245, 19);
            label1.TabIndex = 0;
            label1.Text = "Oluşturmak İstediğiniz Şifreyi Girin:";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(275, 26);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(209, 25);
            txtSifre.TabIndex = 1;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // btnSifreOlustur
            // 
            btnSifreOlustur.BackColor = Color.Ivory;
            btnSifreOlustur.Enabled = false;
            btnSifreOlustur.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifreOlustur.ForeColor = Color.Black;
            btnSifreOlustur.Location = new Point(275, 86);
            btnSifreOlustur.Name = "btnSifreOlustur";
            btnSifreOlustur.Size = new Size(114, 34);
            btnSifreOlustur.TabIndex = 2;
            btnSifreOlustur.Text = "Şifre Oluştur";
            btnSifreOlustur.UseVisualStyleBackColor = false;
            btnSifreOlustur.Click += btnSifreOlustur_Click;
            // 
            // chkSifreyiGoster
            // 
            chkSifreyiGoster.AutoSize = true;
            chkSifreyiGoster.BackColor = Color.Transparent;
            chkSifreyiGoster.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            chkSifreyiGoster.Location = new Point(275, 57);
            chkSifreyiGoster.Name = "chkSifreyiGoster";
            chkSifreyiGoster.Size = new Size(119, 23);
            chkSifreyiGoster.TabIndex = 3;
            chkSifreyiGoster.Text = "Şifreyi Göster";
            chkSifreyiGoster.UseVisualStyleBackColor = false;
            chkSifreyiGoster.CheckedChanged += chkSifreyiGoster_CheckedChanged;
            // 
            // frmSifreOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(516, 138);
            Controls.Add(chkSifreyiGoster);
            Controls.Add(btnSifreOlustur);
            Controls.Add(txtSifre);
            Controls.Add(label1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSifreOlustur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifre Oluştur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSifre;
        private Button btnSifreOlustur;
        private CheckBox chkSifreyiGoster;
    }
}