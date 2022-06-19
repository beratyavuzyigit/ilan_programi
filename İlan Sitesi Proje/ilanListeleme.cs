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
    public partial class ilanListeleme : Form
    {
        public int musteriID;
        public ilanListeleme(int musteriID = 0)
        {
            this.musteriID = musteriID;
            InitializeComponent();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaProgram f1 = new anaProgram(this.musteriID);
            f1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            marka.SelectedIndex = 0;
            model.SelectedIndex = 0;
            sehir.SelectedIndex = 0;
            durum.SelectedIndex = 0;
            kimden.SelectedIndex = 0;
            takas.SelectedIndex = 0;

            vt_ayar vt_ayar = new vt_ayar();
            SqlDataAdapter adapter = vt_ayar.ilan_listele();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            DataGridViewColumn column = dataGridView1.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].Visible = false;
            ((DataGridViewImageColumn)dataGridView1.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns[1].HeaderText = "İlan Resmi";
            dataGridView1.Columns[2].HeaderText = "İlan Başlığı";
            dataGridView1.Columns[3].HeaderText = "Fiyat";
            dataGridView1.Columns[4].HeaderText = "Kilometre";
            dataGridView1.Columns[5].HeaderText = "Marka Model";
            dataGridView1.Columns[6].HeaderText = "Yıl";
            vt_ayar.connection.Close();
            
            SqlDataReader markalar = vt_ayar.marka_getir();
            while (markalar.Read())
            {
                marka.Items.Add(markalar["marka_isim"].ToString());
            }
            vt_ayar.connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] filtre_data = {
                marka.SelectedItem,
                model.SelectedItem,
                fiyatMin.Text,
                fiyatMax.Text,
                kmMin.Text,
                kmMax.Text,
                yilMin.Text,
                yilMax.Text,
                sehir.SelectedItem,
                durum.SelectedIndex,
                kimden.SelectedIndex,
                takas.SelectedIndex
            };
            vt_ayar vt_ayar = new vt_ayar();
            SqlDataAdapter adapter = vt_ayar.ilan_filtrele(filtre_data);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            DataGridViewColumn column = dataGridView1.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ((DataGridViewImageColumn)dataGridView1.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns[1].HeaderText = "İlan Resmi";
            dataGridView1.Columns[2].HeaderText = "İlan Başlığı";
            dataGridView1.Columns[3].HeaderText = "Fiyat";
            dataGridView1.Columns[4].HeaderText = "Kilometre";
            dataGridView1.Columns[5].HeaderText = "Marka Model";
            dataGridView1.Columns[6].HeaderText = "Yıl";
            vt_ayar.connection.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.Items.Clear();
            model.Items.Add("Hepsi");
            model.SelectedIndex = 0;

            vt_ayar vt_ayar = new vt_ayar();
            SqlDataReader modeller = vt_ayar.model_getir(marka.SelectedIndex);
            while (modeller.Read())
            {
                model.Items.Add(modeller["model_isim"].ToString());
            }
            vt_ayar.connection.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            int ilanID = (int)row.Cells[0].Value;// row.Cells[1].Value;
            ilanDetay f6 = new ilanDetay(ilanID);
            f6.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
