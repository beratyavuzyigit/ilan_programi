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
    public partial class adminModelEkleSil : Form
    {
        public int seciliModelID;
        public adminModelEkleSil()
        {
            InitializeComponent();
        }

        private void adminModelEkleSil_Load(object sender, EventArgs e)
        {
            listeGuncelle();
            markaListele();
        }

        public void markaListele()
        {
            markaListesi.SelectedIndex = 0;

            vt_ayar vt_ayar = new vt_ayar();
            SqlDataReader markalar = vt_ayar.marka_getir();
            while (markalar.Read())
            {
                markaListesi.Items.Add(markalar["marka_isim"].ToString());
            }
            vt_ayar.connection.Close();
        }

        public void listeGuncelle()
        {
            vt_ayar vt_ayar = new vt_ayar();
            SqlDataAdapter adapter = vt_ayar.model_listele();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            modelListesi.DataSource = dataTable;
            vt_ayar.connection.Close();

            modelListesi.Columns[0].Visible = false;
            modelListesi.Columns[1].HeaderText = "Marka Adı";
            modelListesi.Columns[2].HeaderText = "Model Adı";
            modelListesi.Columns[1].Width = 190;
            modelListesi.Columns[2].Width = 190;
        }

        private void markaListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            duzenle.Enabled = true;
            sil.Enabled = true;

            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = modelListesi.Rows[rowIndex];
                this.seciliModelID = (int)row.Cells[0].Value;
            }
            catch { }
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            int seciliModelID = this.seciliModelID;
            if (seciliModelID > 0)
            {
                adminModelDuzenle amd = new adminModelDuzenle(seciliModelID);
                amd.Show();
                this.Close();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int seciliModelID = this.seciliModelID;
            if (seciliModelID > 0)
            {
                DialogResult result = MessageBox.Show("Bu modeli silmek istediğinizden emin misiniz? Bu işlem geri alınamaz.", "Model Silinecek!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    vt_ayar vt_ayar = new vt_ayar();
                    bool sonuc = vt_ayar.model_sil(seciliModelID);
                    if (sonuc)
                    {
                        MessageBox.Show("Model başarıyla silindi", "Model Silindi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.listeGuncelle();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu.", "Model Silinemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Marka Seçin");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int markaID = markaListesi.SelectedIndex;
            if (markaID > 0)
            {
                string model_isim = modelIsmi.Text;
                object[] model_data = {
                    markaID,
                    model_isim
                };
                vt_ayar vt_ayar = new vt_ayar();
                bool sonuc = vt_ayar.model_ekle(model_data);
                if (sonuc)
                {
                    MessageBox.Show("Model başarıyla eklendi.", "Model Eklendi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.listeGuncelle();
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu.", "Model Eklenemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Marka seçimi yapmalısınız.", "Marka Seçimi Yapılmadı!", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }
    }
}
