using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace İlan_Sitesi_Proje
{
    public partial class girisYap : Form
    {
        public girisYap()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string musteriMail = mail.Text;
            string musteriSifre = sifre.Text;

            fonksiyonlar fonksiyonlar = new fonksiyonlar();
            string musteriSifreMD5 = fonksiyonlar.MD5Hash(musteriSifre);

            object[] kullanici_data = {
                musteriMail,
                musteriSifreMD5
            };

            vt_ayar vt_ayar = new vt_ayar();
            bool girisSonuc = vt_ayar.kullanici_kontrol(kullanici_data);
            vt_ayar.connection.Close();

            if (girisSonuc)
            {
                kullanici_data = (object[])vt_ayar.kullanici_mail_ile_veri_getir(musteriMail);
                vt_ayar.connection.Close();
                ilanVer f3 = new ilanVer((int)kullanici_data[0]);

                if (beniHatirla.Checked)
                {
                    string config = "mail = " + musteriMail + "\nsifre = " + musteriSifre;
                    config_edit(config);
                }

                f3.Show();
                this.Hide();
            }
            else {
                hata_label.Text = "Müşteri E-Posta veya Şifreniz Hatalı";
                hata_label.Visible = true;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaProgram f1 = new anaProgram();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitOl f4 = new kayitOl();
            f4.Show();
            this.Hide();
        }

        public static void config_edit(string yazilacak_veri)
        {
            string dosya_yolu = @"config.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(yazilacak_veri);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
