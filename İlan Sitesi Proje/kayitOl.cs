using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace İlan_Sitesi_Proje
{
    public partial class kayitOl : Form
    {
        public kayitOl()
        {
            InitializeComponent();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaProgram anaProgram = new anaProgram();
            anaProgram.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            anaProgram anaProgram = new anaProgram();
            anaProgram.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string musteriAd = ad.Text;
            string musteriSoyad = soyad.Text;
            string musteriMail = mail.Text;
            string musteriTelefon = tel.Text;
            string musteriSifre = sifre.Text;
            string musteriSifreTekrar = sifreTekrar.Text;
            int uyelikTipi = uyelik.SelectedIndex + 1;

            if (musteriAd != "" && musteriSoyad != "" && musteriMail != "" && musteriTelefon != "" && musteriSifre != "" && musteriSifreTekrar != "" && uyelikTipi >= 0)
            {
                if (musteriSifre == musteriSifreTekrar)
                {
                    fonksiyonlar fonksiyonlar = new fonksiyonlar();
                    string musteriSifreMD5 = fonksiyonlar.MD5Hash(musteriSifre);

                    object[] kullanici_data = {
                        musteriAd,
                        musteriSoyad,
                        musteriMail,
                        musteriTelefon,
                        musteriSifreMD5,
                        uyelikTipi,
                    };

                    vt_ayar vt_ayar = new vt_ayar();
                    bool sonuc = vt_ayar.kullanici_olustur(kullanici_data);
                    vt_ayar.connection.Close();

                    if (sonuc)
                    {
                        MessageBox.Show("Üyelik kaydınız gerçekleşti ancak tekrar giriş yapmanız gerekecektir.");
                        anaProgram f1 = new anaProgram();
                        f1.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt gerçekleşmedi. Bu E-Posta adresi daha önce alınmış olabilir.");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor.");
                }
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurmak zorunludur.");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
