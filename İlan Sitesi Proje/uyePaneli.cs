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
    public partial class uyePaneli : Form
    {
        public int musteriID;
        public uyePaneli(int musteriID)
        {
            this.musteriID = musteriID;
            InitializeComponent();
        }

        private void uyePaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaProgram f1 = new anaProgram(musteriID);
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int musteriID = this.musteriID;
            kullaniciDuzenle kd = new kullaniciDuzenle(musteriID);
            kd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeIlanlariGoruntule uig = new uyeIlanlariGoruntule(musteriID);
            uig.Show();
        }
    }
}
