using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunlukUygulamasi
{
    public partial class frmGunlukOku : Form
    {
        public frmGunlukOku()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Yazıyı richTextBox'a yazan metot.
        /// </summary>
        /// <param name="fileName"></param>
        private void DosyaIceriginiYukle(string dosyaAdi)
        {
            using (FileStream fs = new FileStream(dosyaAdi, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string satir = null;
                do
                {
                    satir = sr.ReadLine();
                    rtbGunluk.Text += satir;
                } while (satir != null);
                sr.Close();
            }
        }

        /// <summary>
        /// Tarih seç formundaki listbox'taki seçilen günlük ismine göre okuma formunun açılması sağlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGunlukOku_Load(object sender, EventArgs e)
        {
            if (frmTarihSec._GunlukTarihi == DateTime.Now.ToString("MM/dd/yyyy"))
            {
                btnKaydet.Enabled = true;
                rtbGunluk.Enabled = true;
            }

            string dosyaAdı = frmTarihSec._GunlukIsmi[0];
            if (!dosyaAdı.Contains("Resim"))
            {
                DosyaIceriginiYukle(dosyaAdı);
            }

            string dosyaAdi = frmTarihSec._GunlukIsmi[1];
            if (dosyaAdi.Contains("Resim"))
            {
                pbResim.Image = Image.FromFile(dosyaAdi);
            }
        }


        /// <summary>
        /// Kullanıcıya aynı günde yazdığı form üzerinde değişiklik yapma imkanı sağlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string dosyaAdı = frmTarihSec._GunlukIsmi[0];
            using (FileStream fs = new FileStream(dosyaAdı, FileMode.Truncate, FileAccess.Write))
            {
                using (StreamWriter wr = new StreamWriter(fs))
                {
                    string icerik = rtbGunluk.Text;
                    wr.WriteLine(icerik);
                }
            }

            MessageBox.Show("Günlük sayfanızda yapılan değişiklikler başarıyla kaydedilmiştir.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (FileStream fs = new FileStream(frmGunlukYaz._GunlukIsimleri, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter wr = new StreamWriter(fs))
                {
                    string icerik = dosyaAdı + "+" + frmTarihSec._GunlukIsmi[1];
                    wr.WriteLine(icerik);
                }
            }
        }
    }
}
