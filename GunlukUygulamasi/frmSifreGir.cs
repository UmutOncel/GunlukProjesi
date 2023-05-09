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
    public partial class frmSifreGir : Form
    {
        public frmSifreGir()
        {
            InitializeComponent();
        }

        public static string _OluşturulanSifre;
        public static string _Sifre;
        public static bool _SifreDogruMu = false;

        /// <summary>
        /// Yeni kullanıcının oluşturduğu şifre ile giriş yapılan şifrenin eşleşmesi sağlandı. Doğru ise giriş yapacak yanlış ise giriş yapamayacak.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string dosyaAdı = frmSifreOlustur._SifreninDosyaAdi;

            using (FileStream fs = new FileStream(dosyaAdı, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string satir = null;
                do
                {
                    satir = sr.ReadLine();
                    _Sifre = satir;
                } while (satir == null);
                sr.Close();
            }

            _OluşturulanSifre = txtSifre.Text;

            if (_OluşturulanSifre == _Sifre)
            {
                MessageBox.Show("Girmiş olduğunuz şifre doğrudur.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _SifreDogruMu = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz şifre yanlıştır. Lütfen yeniden deneyin.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Şifre yazılacak textbox'a bir şey yazılınca giriş yap butonun aktif olması sağlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            btnGiris.Enabled = txtSifre.Text.Length > 0;
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
