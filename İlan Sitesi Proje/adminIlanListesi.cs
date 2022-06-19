﻿using System;
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
    public partial class adminIlanListesi : Form
    {
        public adminIlanListesi()
        {
            InitializeComponent();
        }

        private void adminIlanListesi_Load(object sender, EventArgs e)
        {
            this.listeGuncelle();
        }

        public int seciliIlanID = 0;

        public void listeGuncelle()
        {
            vt_ayar vt_ayar = new vt_ayar();
            SqlDataAdapter adapter = vt_ayar.ilan_listele();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            ilanListesi.DataSource = dataTable;
            vt_ayar.connection.Close();

            DataGridViewColumn column = ilanListesi.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ((DataGridViewImageColumn)ilanListesi.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            ilanListesi.Columns[0].Visible = false;
            ilanListesi.Columns[1].HeaderText = "Görsel";
            ilanListesi.Columns[2].HeaderText = "İlan Başlığı";
            ilanListesi.Columns[3].HeaderText = "Fiyat";
            ilanListesi.Columns[4].HeaderText = "KM";
            ilanListesi.Columns[5].HeaderText = "Marka Model";
            ilanListesi.Columns[6].HeaderText = "Araç Yıl";
        }

        private void ilanListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            duzenle.Enabled = true;
            sil.Enabled = true;

            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = ilanListesi.Rows[rowIndex];
                this.seciliIlanID = (int)row.Cells[0].Value;
            }
            catch { }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int seciliIlanID = this.seciliIlanID;
            if (seciliIlanID > 0)
            {
                DialogResult result = MessageBox.Show("Bu ilanı silmek istediğinizden emin misiniz? Bu işlem geri alınamaz.", "Seçili İlan Silinecek!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    vt_ayar vt_ayar = new vt_ayar();
                    bool sonuc = vt_ayar.ilan_sil(seciliIlanID);
                    if (sonuc)
                    {
                        MessageBox.Show("Kayıt başarıyla silindi", "Kayıt Silindi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.listeGuncelle();
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu.", "Kayıt Silinemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir İlan Seçin");
            }
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            int seciliIlanID = this.seciliIlanID;
            if (seciliIlanID > 0)
            {
                ilanDuzenle id = new ilanDuzenle(seciliIlanID);
                id.Show();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchText.Text;

            vt_ayar vt_ayar = new vt_ayar();
            SqlDataAdapter adapter = vt_ayar.ilan_like_ile_listele(search);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            ilanListesi.DataSource = dataTable;
            vt_ayar.connection.Close();

            DataGridViewColumn column = ilanListesi.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ((DataGridViewImageColumn)ilanListesi.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            ilanListesi.Columns[0].Visible = false;
            ilanListesi.Columns[1].HeaderText = "Görsel";
            ilanListesi.Columns[2].HeaderText = "İlan Başlığı";
            ilanListesi.Columns[3].HeaderText = "Fiyat";
            ilanListesi.Columns[4].HeaderText = "KM";
            ilanListesi.Columns[5].HeaderText = "Marka Model";
            ilanListesi.Columns[6].HeaderText = "Araç Yıl";
        }
    }
}
