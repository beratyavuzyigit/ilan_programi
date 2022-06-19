using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace İlan_Sitesi_Proje
{
    public partial class ilanVer : Form
    {
        public int musteriID;
        public ilanVer(int musteriID)
        {
            this.musteriID = musteriID;
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaProgram f1 = new anaProgram(this.musteriID);
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "İlan Görsellerini Seçin";
            fdlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            fdlg.FilterIndex = 2;
            fdlg.Multiselect = false;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                gorselPath.Text = fdlg.FileName;
                byte[] gorsel = System.IO.File.ReadAllBytes(gorselPath.Text);
                fonksiyonlar funcs = new fonksiyonlar();
                ilanGorsel.Image = funcs.ByteToImage(gorsel);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Byte[] gorsel = new Byte[64];
            Array.Clear(gorsel, 0, gorsel.Length);

            try
            {
                gorsel = System.IO.File.ReadAllBytes(gorselPath.Text);
            }
            catch
            {
                try
                {
                    System.Drawing.Bitmap bitmap1 = İlan_Sitesi_Proje.Properties.Resources.resim_yok;
                    fonksiyonlar func = new fonksiyonlar();
                    gorsel = func.ImageToByteArray(bitmap1);
                }
                catch { }
            }
            object[] ilan_data = {
                this.musteriID,
                textBox1.Text,
                textBox2.Text,
                comboBox4.SelectedItem,
                int.Parse(textBox3.Text),
                int.Parse(textBox4.Text),
                comboBox5.SelectedItem,
                comboBox6.SelectedItem,
                int.Parse(textBox7.Text),
                int.Parse(textBox8.Text),
                comboBox1.SelectedIndex,
                comboBox2.SelectedIndex,
                comboBox3.SelectedIndex,
                gorsel
            };

            vt_ayar vt_ayar = new vt_ayar();
            bool sonuc = vt_ayar.ilan_ekle(ilan_data);

            if (sonuc)
            {
                DialogResult cevap = MessageBox.Show("İlan başarıyla kaydedildi. Yönetim onayından sonra ilanınız yayınlanacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cevap == DialogResult.OK)
                {
                    anaProgram f2 = new anaProgram();
                    f2.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("İlan eklenirken bir hata oluştu. Lütfen daha sonra tekrar deneyiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(İlan_Sitesi_Proje.Properties.Resources.resim_yok);
            ilanGorsel.Image = bmp;
            vt_ayar vt_ayar = new vt_ayar();
            SqlDataReader markalar = vt_ayar.marka_getir();
            while (markalar.Read())
            {
                comboBox5.Items.Add(markalar["marka_isim"].ToString());
            }
            vt_ayar.connection.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Items.Clear();

            vt_ayar vt_ayar = new vt_ayar();
            SqlDataReader modeller = vt_ayar.model_getir(comboBox5.SelectedIndex + 1);
            while (modeller.Read())
            {
                comboBox6.Items.Add(modeller["model_isim"].ToString());
            }
            vt_ayar.connection.Close();

            comboBox6.SelectedIndex = 0;
        }
    }
}
