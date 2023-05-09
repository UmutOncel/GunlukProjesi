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
    public partial class frmTarihSec : Form
    {
        public frmTarihSec()
        {
            InitializeComponent();
        }

        public static string _SecilenTarih;
        public static string _SecilenGunlukIsmi;
        public static string[] _GunlukIsmi;
        public static string _GunlukTarihi;


        /// <summary>
        /// Takvimde seçili tarih lblSeciliTarih'e yazdırıldı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mcTakvim_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblSeciliTarih.Text = mcTakvim.SelectionStart.ToString("MM/dd/yyyy");
            _SecilenTarih = lblSeciliTarih.Text;
        }

        /// <summary>
        /// Takvimde uygulamaya girilen günden sonraki günlerin seçimi engellendi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTarihSec_Load(object sender, EventArgs e)
        {
            mcTakvim.MaxDate = DateTime.Now;
        }

        /// <summary>
        /// btnGunlukOlustur'a tıklanınca günlük yazma child formunun gelmesi sağlandı. Seçilen tarihli günlük oluşturulmuşsa aynı tarihli günlük seçimi engellendi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGunlukOlustur_Click(object sender, EventArgs e)
        {
            if (frmGunlukYaz._GunlukTarihleriListesi.Contains(_SecilenTarih))
            {
                MessageBox.Show($"{lblSeciliTarih.Text} tarihli bir günlüğünüz mevcuttur. Aynı tarihli birden fazla günlük sayfası oluşturamazsınız.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmGunlukYaz gunlukYaz = new frmGunlukYaz();
                gunlukYaz.MdiParent = this.MdiParent;
                gunlukYaz.Show();
            }
        }

        /// <summary>
        /// Listbox'ta günlük isimlerine tıklayınca Günlük Oku formunun açılması sağlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstGunlukler_DoubleClick(object sender, EventArgs e)
        {
            _SecilenGunlukIsmi = lstGunlukler.SelectedItem.ToString();
            _GunlukIsmi = _SecilenGunlukIsmi.Split('+');
            _GunlukTarihi = _SecilenGunlukIsmi.Substring(0, 10);

            frmGunlukOku gunlukOku = new frmGunlukOku();
            gunlukOku.MdiParent = this.MdiParent;
            gunlukOku.Show();
        }

        /// <summary>
        /// Günlük isimleri listbox içine yazdırıldı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGunlukListele_Click(object sender, EventArgs e)
        {
            lstGunlukler.Items.Clear();
            lstGunlukler.Items.AddRange(System.IO.File.ReadAllLines(frmGunlukYaz._GunlukIsimleri));
        }
    }
}
