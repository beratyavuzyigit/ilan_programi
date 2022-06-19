using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace İlan_Sitesi_Proje
{
    public partial class ilanDetay : Form
    {
        public int ilanID;
        public ilanDetay(int ilanID)
        {
            this.ilanID = ilanID;
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int ilanID = this.ilanID;
            vt_ayar vt_ayar = new vt_ayar();
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
                pictureBox1.Image = funcs.ByteToImage(aracGorsel);
            }

            vt_ayar.connection.Close();

            markaModel.Text = aracMarka + " > " + aracModel;
            string paraFormat = string.Format("{0:C0} TL", aracFiyat);
            paraFormat = paraFormat.Substring(1, paraFormat.Length - 1);
            fiyat.Text = paraFormat;

            baslik.Text = ilanBaslik;

            aciklama.Text = ilanAciklama;

            ilanNo.Text = this.ilanID.ToString();

            string aracKmFormat = string.Format("{0:C0}", aracKm);
            aracKmFormat = aracKmFormat.Substring(1, aracKmFormat.Length - 1);
            kilometre.Text = aracKmFormat;

            marka.Text = aracMarka;

            model.Text = aracModel;

            yil.Text = aracYil.ToString();

            motorhacmi.Text = aracMotorHacmi.ToString() + " cc";

            if (aracDurum == 0)
            {
                durum.Text = "Sıfır";
            }else if (aracDurum == 1)
            {
                durum.Text = "İkinci El";
            }

            if (aracKimden == 0)
            {
                kimden.Text = "Sahibinden";
            }
            else if (aracKimden == 1)
            {
                kimden.Text = "Galeriden";
            }

            if (aracTakas == 0)
            {
                takas.Text = "Evet";
            }
            else if (aracKimden == 1)
            {
                takas.Text = "Hayır";
            }

            telefon.Text = ilanSehir;

            object[] kullanici_data = (object[])vt_ayar.kullanici_ID_ile_veri_getir(musteriID);

            adSoyad.Text = (string)kullanici_data[1] + " " + (string)kullanici_data[2];
            telefon.Text = (string)kullanici_data[3];
            mail.Text = (string)kullanici_data[4];
        }

        private void fiyat_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
