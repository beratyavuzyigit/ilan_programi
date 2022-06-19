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
    public partial class adminAnaMenu : Form
    {
        public int musteriID;
        public adminAnaMenu(int musteriID)
        {
            this.musteriID = musteriID;
            InitializeComponent();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaProgram f1 = new anaProgram(musteriID);
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminKullaniciListesi akl = new adminKullaniciListesi();
            akl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminIlanListesi ail = new adminIlanListesi();
            ail.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminOnaysizIlanlar aoi = new adminOnaysizIlanlar();
            aoi.Show();
        }

        private void adminAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminMarkaEkleSil ames = new adminMarkaEkleSil();
            ames.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminModelEkleSil ames = new adminModelEkleSil();
            ames.Show();
        }
    }
}
