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
    public partial class anaProgram : Form
    {
        public int musteriID = 0;
        public string musteriMail = null;
        public anaProgram(int musteriID = 0)
        {
            this.musteriID = musteriID;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verileri_cek();
            if (this.musteriID > 0)
            {
                vt_ayar vt_ayar = new vt_ayar();
                object[] kullanici_data = (object[])vt_ayar.kullanici_ID_ile_veri_getir(this.musteriID);
                vt_ayar.connection.Close();

                this.musteriID = (int)kullanici_data[0];
                this.musteriMail = (string)kullanici_data[3];
                this.giris_actions(kullanici_data);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.musteriID != 0)
            {
                ilanVer f3 = new ilanVer(this.musteriID);
                f3.Show();
                this.Hide();
            }
            else
            {
                girisYap f2 = new girisYap();
                f2.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ilanListeleme f5 = new ilanListeleme(this.musteriID);
            f5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayitOl f4 = new kayitOl();
            f4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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

                this.giris_actions(kullanici_data);

                if (beniHatirla.Checked)
                {
                    string config = "mail = " + musteriMail + "\nsifre = " + musteriSifre;
                    config_edit(config);
                }
            }
            else
            {
                hata_label.Text = "Müşteri E-Posta veya Şifreniz Hatalı";
                hata_label.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.musteriID = 0;

            girisPanel.Visible = true;
            uyePanel.Visible = false;

            merhaba_label.Text = "Hoş geldiniz, Kullanıcı";
            adminButton.Visible = false;

            config_delete();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            adminAnaMenu f7 = new adminAnaMenu(this.musteriID);
            f7.Show();
            this.Hide();
        }

        private void giris_actions(object[] kullanici_data)
        {
            girisPanel.Visible = false;
            uyePanel.Visible = true;

            this.musteriID = (int)kullanici_data[0];
            this.musteriMail = (string)kullanici_data[3];
            string musteriAd = (string)kullanici_data[1];

            merhaba_label.Text = "Hoş geldiniz, " + musteriAd;

            if ((int)kullanici_data[5] == 3)
            {
                adminButton.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uyePaneli up = new uyePaneli(this.musteriID);
            up.Show();
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
        public void verileri_cek()
        {
            try
            {
                string[] veriler = System.IO.File.ReadAllLines("config.txt");
                string[] parts;
                string ayar_ad, ayar;
                foreach (var item in veriler)
                {
                    parts = item.Split('=');
                    ayar_ad = parts[0].Trim();
                    ayar = parts[1].Trim();
                    if (ayar_ad == "mail")
                        mail.Text = ayar;
                    else if (ayar_ad == "sifre")
                        sifre.Text = ayar;
                }

                button4.PerformClick();
            }
            catch { }
        }

        public void config_delete()
        {
            File.Delete(@"config.txt");
        }
    }
}
