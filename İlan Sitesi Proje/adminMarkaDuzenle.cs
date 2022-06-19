using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlan_Sitesi_Proje
{
    public partial class adminMarkaDuzenle : Form
    {
        public int markaID;
        public adminMarkaDuzenle(int markaID)
        {
            this.markaID = markaID;
            InitializeComponent();
        }

        private void adminMarkaDuzenle_Load(object sender, EventArgs e)
        {
            vt_ayar vt_ayar = new vt_ayar();
            string marka_isim = vt_ayar.marka_ID_ile_getir(this.markaID);
            vt_ayar.connection.Close();

            markaIsmi.Text = marka_isim;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int markaID = this.markaID;
            string marka_isim = markaIsmi.Text;

            object[] marka_data = {
                markaID,
                marka_isim
            };

            vt_ayar vt_ayar = new vt_ayar();
            bool sonuc = vt_ayar.marka_duzenle(marka_data);

            if (sonuc)
            {
                MessageBox.Show("Marka Başarıyla Düzenlendi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu.", "Marka Düzenlenemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminMarkaDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminMarkaEkleSil ames = new adminMarkaEkleSil();
            ames.Show();
        }
    }
}
