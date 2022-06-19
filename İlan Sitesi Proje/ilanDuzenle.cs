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

namespace İlan_Sitesi_Proje
{
    public partial class ilanDuzenle : Form
    {
        public int ilanID = 0;
        public bool ilanDurum = true;
        public ilanDuzenle(int ilanID, bool ilanDurum = true)
        {
            this.ilanID = ilanID;
            this.ilanDurum = ilanDurum;
            InitializeComponent();
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

        private void ilanDuzenle_Load(object sender, EventArgs e)
        {
            vt_ayar vt_ayar = new vt_ayar();
            SqlDataReader markalar = vt_ayar.marka_getir();
            while (markalar.Read())
            {
                marka.Items.Add(markalar["marka_isim"].ToString());
            }
            vt_ayar.connection.Close();

            int ilanID = this.ilanID;
            SqlDataReader reader = vt_ayar.ilan_getir(ilanID);
            reader.Read();

            int musteriID = (int)reader[1];
            string ilanBaslik = (string)reader[2];
            string ilanAciklama = (string)reader[3];
            string ilanSehir = (string)reader[4];
            int aracFiyat = (int)reader[5];
            int aracKm = (int)reader[6];
            string aracMarka = (string)reader[7];
            string aracModel = (string)reader[8];
            int aracMotorHacmi = (int)reader[9];
            int aracYil = (int)reader[10];
            int aracDurum = (int)reader[11];
            int aracTakas = (int)reader[12];
            int aracKimden = (int)reader[13];
            if (reader[14] != DBNull.Value)
            {
                byte[] aracGorsel = (byte[])reader[14];

                fonksiyonlar funcs = new fonksiyonlar();
                ilanGorsel.Image = funcs.ByteToImage(aracGorsel);
            }

            vt_ayar.connection.Close();

            marka.SelectedItem = aracMarka;
            fiyat.Text = aracFiyat.ToString();
            baslik.Text = ilanBaslik;
            aciklama.Text = ilanAciklama;
            km.Text = aracKm.ToString();
            marka.SelectedItem = aracMarka;
            model.SelectedItem = aracModel;
            yil.Text = aracYil.ToString();
            motorHacmi.Text = aracMotorHacmi.ToString();
            durum.SelectedIndex = aracDurum;
            kimden.SelectedIndex = aracKimden;
            takas.SelectedIndex = aracTakas;
            sehir.SelectedItem = ilanSehir;
        }

        private void marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.Items.Clear();
            vt_ayar vt_ayar = new vt_ayar();
            SqlDataReader modeller = vt_ayar.model_getir(marka.SelectedIndex + 1);
            while (modeller.Read())
            {
                model.Items.Add(modeller["model_isim"].ToString());
            }
            vt_ayar.connection.Close();
            model.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Byte[] gorsel = new Byte[64];
            Array.Clear(gorsel, 0, gorsel.Length);
            bool gorselDegissin = false;
            bool ilanOnayli = this.ilanDurum;
            if (this.ilanDurum)
            {

            }
            if (gorselPath.Text != null && System.IO.File.Exists(gorselPath.Text))
            {
                gorsel = System.IO.File.ReadAllBytes(gorselPath.Text);
                gorselDegissin = true;
            }

            object[] ilan_data = {
                this.ilanID,
                baslik.Text,
                aciklama.Text,
                sehir.SelectedItem,
                int.Parse(fiyat.Text),
                int.Parse(km.Text),
                marka.SelectedItem,
                model.SelectedItem,
                int.Parse(motorHacmi.Text),
                int.Parse(yil.Text),
                durum.SelectedIndex,
                kimden.SelectedIndex,
                takas.SelectedIndex,
                gorsel,
                gorselDegissin,
                ilanOnayli
            };

            vt_ayar vt_ayar = new vt_ayar();
            bool sonuc = vt_ayar.ilan_guncelle(ilan_data);

            if (sonuc)
            {
                DialogResult cevap = MessageBox.Show("İlan başarıyla güncellendi. Yönetim onayından sonra ilanınız yayınlanacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cevap == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("İlan eklenirken bir hata oluştu. Lütfen daha sonra tekrar deneyiniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ilanDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminIlanListesi ail = new adminIlanListesi();
            ail.listeGuncelle();
        }
    }
}
