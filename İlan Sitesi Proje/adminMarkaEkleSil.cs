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
    public partial class adminMarkaEkleSil : Form
    {
        public int seciliMarkaID = 0;
        public adminMarkaEkleSil()
        {
            InitializeComponent();
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            int seciliMarkaID = this.seciliMarkaID;
            if (seciliMarkaID > 0)
            {
                adminMarkaDuzenle akd = new adminMarkaDuzenle(seciliMarkaID);
                akd.Show();
                this.Close();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int seciliMarkaID = this.seciliMarkaID;
            if (seciliMarkaID > 0)
            {
                DialogResult result = MessageBox.Show("Bu markayı silmek istediğinizden emin misiniz? Bu işlem geri alınamaz.", "Marka Silinecek!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    vt_ayar vt_ayar = new vt_ayar();
                    bool sonuc = vt_ayar.marka_sil(seciliMarkaID);
                    if (sonuc)
                    {
                        MessageBox.Show("Marka başarıyla silindi", "Marka Silindi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.listeGuncelle();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu.", "Marka Silinemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Marka Seçin");
            }
        }

        public void listeGuncelle()
        {
            vt_ayar vt_ayar = new vt_ayar();
            SqlDataAdapter adapter = vt_ayar.marka_listele();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            markaListesi.DataSource = dataTable;
            vt_ayar.connection.Close();

            markaListesi.Columns[0].Visible = false;
            markaListesi.Columns[1].HeaderText = "Marka Adı";
            markaListesi.Columns[1].Width = 350;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka_isim = markaIsmi.Text;
            vt_ayar vt_ayar = new vt_ayar();
            bool sonuc = vt_ayar.marka_ekle(marka_isim);
            if (sonuc)
            {
                MessageBox.Show("Marka başarıyla eklendi.", "Marka Eklendi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.listeGuncelle();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.", "Marka Eklenemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminMarkaEkleSil_Load(object sender, EventArgs e)
        {
            listeGuncelle();
        }

        private void markaListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            duzenle.Enabled = true;
            sil.Enabled = true;

            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = markaListesi.Rows[rowIndex];
                this.seciliMarkaID = (int)row.Cells[0].Value;
            }
            catch { }
        }
    }
}
