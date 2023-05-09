using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GunlukUygulamasi
{
    public partial class frmSifreOlustur : Form
    {
        public static string _SifreninDosyaAdi = "Sifre.txt";

        /// <summary>
        /// Farklı bilgisayarlarda programa girildiğinde _SifreninDosyaAdi adlı dosyanın bulunmaması durumunda hata vermemesi için _SifreninDosyaAdi adlı dosya oluşturuldu. Bu dosya bilgisayarda mevcut ise herhangi bir işlem yapmıyor.
        /// </summary>
        public frmSifreOlustur()
        {
            InitializeComponent();

            bool varMi = DosyaVarMi();

            if (!varMi)
            {
                using FileStream fs = new FileStream(_SifreninDosyaAdi, FileMode.CreateNew, FileAccess.Write);
                //Dosya yolunda dosya var ise dosya oluşturmayacak yoksa dosya oluşturacak.
            }
        }

        /// <summary>
        /// Kullanıcının girdiği şifreye yeniden ulaşılması amacıyla txt dosyası içinde saklandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSifreOlustur_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(_SifreninDosyaAdi, FileMode.Truncate, FileAccess.Write))
            {
                using (StreamWriter wr = new StreamWriter(fs))
                {
                    if (txtSifre.Text.Contains(" "))
                    {
                        MessageBox.Show("Hatalı giriş! Lütfen şifrenizi oluştururken boşluk bırakmayınız.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string icerik = txtSifre.Text;
                        wr.WriteLine(icerik);
                        MessageBox.Show("Şifreniz başarıyla oluşturuldu. Uygulama girişinde ve içinde bu şifreyi kullanacaksınız. Uygulamayı kullanmaya başlamak için lütfen bu şifre ile giriş yapınız.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        /// <summary>
        /// _SifreninDosyaAdi adında bir dosyanın var olup olmadığını bulan varsa true, yoksa false döndüren metot.
        /// </summary>
        /// <returns></returns>
        private bool DosyaVarMi()
        {
            return File.Exists(_SifreninDosyaAdi);
        }

        /// <summary>
        /// Şifre girilince şifre gir butonun aktif olması sağlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            btnSifreOlustur.Enabled = txtSifre.Text.Length > 0;

            txtSifre.PasswordChar.ToString();
        }

        /// <summary>
        /// CheckBox işaretlenince şifre okunabilir işaretlenmezse şifrenin her karakteri * olarak görünür.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreyiGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}
