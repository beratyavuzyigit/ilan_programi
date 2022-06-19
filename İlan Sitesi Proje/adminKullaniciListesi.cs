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
    public partial class adminKullaniciListesi : Form
    {
        public adminKullaniciListesi()
        {
            InitializeComponent();
        }
        public int seciliKullaniciID = 0;
        private void adminKullaniciListesi_Load(object sender, EventArgs e)
        {
            this.listeGuncelle();
        }

        private void kullaniciListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            yasakla.Enabled = true;
            duzenle.Enabled = true;
            sil.Enabled = true;

            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = kullaniciListesi.Rows[rowIndex];
                this.seciliKullaniciID = (int)row.Cells[0].Value;
            }
            catch { }
        }

        private void kullaniciListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int seciliKullaniciID = this.seciliKullaniciID;
            if (seciliKullaniciID > 0)
            {
                DialogResult result = MessageBox.Show("Bu kullanıcıyı ve tüm ilanlarını silmek istediğinizden emin misiniz? Bu işlem geri alınamaz.", "Kullanıcı ve İlanları Silinecek!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    vt_ayar vt_ayar = new vt_ayar();
                    bool sonuc = vt_ayar.kullanici_sil(seciliKullaniciID);
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
                MessageBox.Show("Lütfen Bir Kullanıcı Seçin");
            }
        }

        public void listeGuncelle()
        {
            vt_ayar vt_ayar = new vt_ayar();
            SqlDataAdapter adapter = vt_ayar.kullanici_listele();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            kullaniciListesi.DataSource = dataTable;
            vt_ayar.connection.Close();

            kullaniciListesi.Columns[0].Visible = false;
            kullaniciListesi.Columns[1].HeaderText = "Müşteri Adı";
            kullaniciListesi.Columns[2].HeaderText = "Müşteri Soyadı";
            kullaniciListesi.Columns[3].HeaderText = "Müşteri E-Posta Adresi";
            kullaniciListesi.Columns[4].HeaderText = "Müşteri Telefon Numarası";
            kullaniciListesi.Columns[5].HeaderText = "Üyelik Tipi";

            kullaniciListesi.Columns[3].Width = 200;
            kullaniciListesi.Columns[4].Width = 200;
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            int seciliKullaniciID = this.seciliKullaniciID;
            if (seciliKullaniciID > 0)
            {
                adminKullaniciDuzenle akd = new adminKullaniciDuzenle(seciliKullaniciID);
                akd.Show();
                this.Close();
            }
        }

        private void yasakla_Click(object sender, EventArgs e)
        {
            vt_ayar vt_ayar = new vt_ayar();
            bool sonuc = vt_ayar.kullanici_yasakla(seciliKullaniciID);
            if (sonuc)
            {
                MessageBox.Show("Kullanıcı başarıyla yasaklandı!", "Kullanıcı Yasaklandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.listeGuncelle();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.", "Kullanıcı Yasaklanamadı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchText.Text;

            vt_ayar vt_ayar = new vt_ayar();
            SqlDataAdapter adapter = vt_ayar.kullanici_like_ile_listele(search);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            kullaniciListesi.DataSource = dataTable;
            vt_ayar.connection.Close();

            kullaniciListesi.Columns[0].Visible = false;
            kullaniciListesi.Columns[1].HeaderText = "Müşteri Adı";
            kullaniciListesi.Columns[2].HeaderText = "Müşteri Soyadı";
            kullaniciListesi.Columns[3].HeaderText = "Müşteri E-Posta Adresi";
            kullaniciListesi.Columns[4].HeaderText = "Müşteri Telefon Numarası";
            kullaniciListesi.Columns[5].HeaderText = "Üyelik Tipi";

            kullaniciListesi.Columns[3].Width = 200;
            kullaniciListesi.Columns[4].Width = 200;
        }
    }
}
