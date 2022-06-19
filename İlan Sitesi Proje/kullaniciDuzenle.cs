using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlan_Sitesi_Proje
{
    public partial class kullaniciDuzenle : Form
    {
        public int musteriID;
        public kullaniciDuzenle(int musteriID)
        {
            this.musteriID = musteriID;
            InitializeComponent();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            string musteriAd = ad.Text;
            string musteriSoyad = soyad.Text;
            string musteriMail = mail.Text;
            string musteriTelefon = telefon.Text;
            string musteriSifre = sifre.Text;

            object[] kullanici_data = {
                this.musteriID,
                musteriAd,
                musteriSoyad,
                musteriMail,
                musteriTelefon,
                musteriSifre,
            };

            vt_ayar vt_ayar = new vt_ayar();
            bool sonuc = vt_ayar.kullanici_self_duzenle(kullanici_data);

            if (sonuc)
            {
                MessageBox.Show("Bilgileriniz Güncellendi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.", "Bilgileriniz Düzenlenemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kullaniciDuzenle_Load(object sender, EventArgs e)
        {
            vt_ayar vt_ayar = new vt_ayar();
            object[] kullanici_data = (object[])vt_ayar.kullanici_ID_ile_veri_getir(this.musteriID);

            ad.Text = (string)kullanici_data[1];
            soyad.Text = (string)kullanici_data[2];
            mail.Text = (string)kullanici_data[3];
            telefon.Text = (string)kullanici_data[4];
        }
    }
}
