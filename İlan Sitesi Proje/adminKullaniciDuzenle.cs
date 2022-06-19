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
    public partial class adminKullaniciDuzenle : Form
    {
        public int musteriID;
        public adminKullaniciDuzenle(int musteriID)
        {
            this.musteriID = musteriID;
            InitializeComponent();
        }

        private void adminKullaniciDuzenle_Load(object sender, EventArgs e)
        {
            vt_ayar vt_ayar = new vt_ayar();
            object[] kullanici_data = (object[])vt_ayar.kullanici_ID_ile_veri_getir(this.musteriID);

            ad.Text = (string)kullanici_data[1];
            soyad.Text = (string)kullanici_data[2];
            mail.Text = (string)kullanici_data[3];
            telefon.Text = (string)kullanici_data[4];
            tip.SelectedIndex = (int)kullanici_data[5];
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            string musteriAd = ad.Text;
            string musteriSoyad = soyad.Text;
            string musteriMail = mail.Text;
            string musteriTelefon = telefon.Text;
            string musteriSifre = sifre.Text;
            int uyelikTipi = tip.SelectedIndex;

            object[] kullanici_data = {
                this.musteriID,
                musteriAd,
                musteriSoyad,
                musteriMail,
                musteriTelefon,
                musteriSifre,
                uyelikTipi
            };

            vt_ayar vt_ayar = new vt_ayar();
            bool sonuc = vt_ayar.kullanici_duzenle(kullanici_data);

            if (sonuc)
            {
                MessageBox.Show("Kullanıcı Başarıyla Düzenlendi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.", "Kullanıcı Düzenlenemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminKullaniciDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminKullaniciListesi akl = new adminKullaniciListesi();
            akl.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void soyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
