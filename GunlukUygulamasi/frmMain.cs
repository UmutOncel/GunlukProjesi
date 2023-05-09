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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Şifre oluşturma formu çağrıldı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSifreOlustur_Click(object sender, EventArgs e)
        {
            frmSifreOlustur sifreOlustur = new frmSifreOlustur();
            sifreOlustur.MdiParent = this.MdiParent;
            sifreOlustur.Show();
        }

        /// <summary>
        /// Oluşturulan şifre ile giriş yapılacağı form çağrıldı. Şifre doğru ise Yeni Günlük Oluştur butonu aktif edildi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSifreGir_Click(object sender, EventArgs e)
        {
            frmSifreGir sifreGir = new frmSifreGir();
            sifreGir.MdiParent = this.MdiParent;
            sifreGir.ShowDialog();

            if (frmSifreGir._OluşturulanSifre == frmSifreGir._Sifre)
            {
                tsmYeniGunlukSayfasiOlustur.Enabled = true;
            }
        }

        /// <summary>
        /// Yeni Günlük sayfası oluşturma formu çağrıldı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmYeniGunlukSayfasiOlustur_Click(object sender, EventArgs e)
        {
            frmTarihSec tarihSec = new frmTarihSec();
            tarihSec.MdiParent = this.MdiParent;
            tarihSec.Show();
        }
    }
}
