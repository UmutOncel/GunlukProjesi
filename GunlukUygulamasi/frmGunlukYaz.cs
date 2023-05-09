using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunlukUygulamasi
{
    public partial class frmGunlukYaz : Form
    {
        /// <summary>
        /// Farklı bilgisayarlarda programa girildiğinde _GunlukIsimleri adlı dosyanın bulunmaması durumunda hata vermemesi için _GunlukIsimleri adlı dosya oluşturuldu. Bu dosya bilgisayarda mevcut ise herhangi bir işlem yapmıyor.
        /// </summary>
        public frmGunlukYaz()
        {
            InitializeComponent();

            bool varMi = DosyaVarMi();

            if (!varMi)
            {
                using FileStream fs = new FileStream(_GunlukIsimleri, FileMode.CreateNew, FileAccess.Write);
            }
        }

        public static string _GunlukIsimleri = "GunlukIsimleri.txt";
        public static string _GunlukBasligi;
        public static List<string> _GunlukTarihleriListesi = new List<string>();
        string resimAdi;

        /// <summary>
        /// Başlık ve metinde yazılan yazılar oluşturulan txt dosyasının içine yazılır. Resim eklenirse resim yolu kaydedilir. Günlük başlığı ve tarihleri diğer formlarda kullanılmak için txt dosyası içine yazılır. Yazılmadan önce şifre soruldu. Şifre doğru ise kayıt yapıldı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmSifreGir sifre = new frmSifreGir();
            sifre.ShowDialog();
            if (frmSifreGir._SifreDogruMu)
            {
                if (txtGunlukBasligi.Text.Length > 0 && rtbGunlukMetni.Text.Length > 0)
                {
                    _GunlukBasligi = frmTarihSec._SecilenTarih + " - " + txtGunlukBasligi.Text;
                    using (FileStream fs = new FileStream(_GunlukBasligi, FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter wr = new StreamWriter(fs))
                        {
                            string icerik = txtGunlukBasligi.Text + "\r \n" + rtbGunlukMetni.Text;
                            wr.WriteLine(icerik);
                        }
                    }
                }

                if (pbResim.Image != null)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
                    resimAdi = frmTarihSec._SecilenTarih + " - Resim";
                    pbResim.Image.Save(resimAdi);
                }

                MessageBox.Show($"{_GunlukBasligi} isimli günlük sayfanız başarıyla kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (FileStream fs = new FileStream(_GunlukIsimleri, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter wr = new StreamWriter(fs))
                    {
                        string icerik = _GunlukBasligi + "+" + resimAdi;
                        wr.WriteLine(icerik);
                    }
                }

                string gunluguOlusturulanTarihler = "GünlüğüOluşturulanTarihler.txt";

                using (FileStream fs = new FileStream(gunluguOlusturulanTarihler, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter wr = new StreamWriter(fs))
                    {
                        string icerik = frmTarihSec._SecilenTarih;
                        wr.WriteLine(icerik);
                    }
                }

                _GunlukTarihleriListesi.AddRange(System.IO.File.ReadAllLines(gunluguOlusturulanTarihler));
            }
        }

        /// <summary>
        /// _GunlukIsimleri adında bir dosyanın var olup olmadığını bulan varsa true, yoksa false döndüren
        /// </summary>
        /// <returns></returns>
        private bool DosyaVarMi()
        {
            return File.Exists(_GunlukIsimleri);
        }

        /// <summary>
        /// Resim ekle butonuna tıklayınca kullanıcının resim eklemesi sağlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string resimAdi = ofd.FileName;
                pbResim.Image = Image.FromFile(resimAdi);
            }
        }

        /// <summary>
        /// Eklenen resim silindi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResimSil_Click(object sender, EventArgs e)
        {
            pbResim.Image = null;
        }

        /// <summary>
        /// Textbox içinde bilgilendirme amacıyla yazılmış yazı siler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGunlukBasligi_Click(object sender, EventArgs e)
        {
            if (txtGunlukBasligi.Text == "#BAŞLIĞINIZ#")
            {
                txtGunlukBasligi.Clear();
            }
        }

        /// <summary>
        /// Richtextbox içinde bilgilendirme amacıyla yazılmış yazıyı siler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbGunlukMetni_Click(object sender, EventArgs e)
        {
            if (rtbGunlukMetni.Text == "#NOTLARINIZ#")
            {
                rtbGunlukMetni.Clear();
            }
        }
    }
}
