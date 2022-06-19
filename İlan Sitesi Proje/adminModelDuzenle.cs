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
    public partial class adminModelDuzenle : Form
    {
        public int modelID;
        public adminModelDuzenle(int modelID)
        {
            this.modelID = modelID;
            InitializeComponent();
        }

        private void adminModelDuzenle_Load(object sender, EventArgs e)
        {
            markaListele();

            vt_ayar vt_ayar = new vt_ayar();
            object[] model_data = (object[])vt_ayar.model_ID_ile_getir(this.modelID);
            vt_ayar.connection.Close();

            int seciliMarkaID = (int)model_data[0];
            string model_isim = (string)model_data[1];

            markaListesi.SelectedIndex = seciliMarkaID - 1;
            modelIsmi.Text = model_isim;
        }

        public void markaListele()
        {
            vt_ayar vt_ayar = new vt_ayar();
            SqlDataReader markalar = vt_ayar.marka_getir();
            while (markalar.Read())
            {
                markaListesi.Items.Add(markalar["marka_isim"].ToString());
            }
            vt_ayar.connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int modelID = this.modelID;
            int markaID = markaListesi.SelectedIndex + 1;
            string model_isim = modelIsmi.Text;

            object[] model_data = {
                modelID,
                markaID,
                model_isim
            };

            vt_ayar vt_ayar = new vt_ayar();
            bool sonuc = vt_ayar.model_duzenle(model_data);

            if (sonuc)
            {
                MessageBox.Show("Model Başarıyla Düzenlendi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.", "Model Düzenlenemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminModelDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminModelEkleSil ames = new adminModelEkleSil();
            ames.Show();
        }
    }
}
