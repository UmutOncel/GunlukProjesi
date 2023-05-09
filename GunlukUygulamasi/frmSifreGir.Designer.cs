namespace GunlukUygulamasi
{
    partial class frmSifreGir
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
            btnGiris = new Button();
            txtSifre = new TextBox();
            chkSifreyiGoster = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 0;
            label1.Text = "Şifrenizi Giriniz:";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Ivory;
            btnGiris.Enabled = false;
            btnGiris.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = Color.Black;
            btnGiris.Location = new Point(145, 84);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(96, 30);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(145, 24);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(211, 25);
            txtSifre.TabIndex = 2;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // chkSifreyiGoster
            // 
            chkSifreyiGoster.AutoSize = true;
            chkSifreyiGoster.BackColor = Color.Transparent;
            chkSifreyiGoster.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            chkSifreyiGoster.Location = new Point(145, 55);
            chkSifreyiGoster.Name = "chkSifreyiGoster";
            chkSifreyiGoster.Size = new Size(119, 23);
            chkSifreyiGoster.TabIndex = 3;
            chkSifreyiGoster.Text = "Şifreyi Göster";
            chkSifreyiGoster.UseVisualStyleBackColor = false;
            chkSifreyiGoster.CheckedChanged += chkSifreyiGoster_CheckedChanged;
            // 
            // frmSifreGir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(385, 130);
            Controls.Add(chkSifreyiGoster);
            Controls.Add(txtSifre);
            Controls.Add(btnGiris);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSifreGir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifre Gir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnGiris;
        private TextBox txtSifre;
        private CheckBox chkSifreyiGoster;
    }
}