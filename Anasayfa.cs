using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazilim_Gelistirme_Lab_Proje
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void basla_Lbl_Click(object sender, EventArgs e)
        {
            Ad_Soyad ad = new Ad_Soyad();
            this.Hide();
            ad.Show();
        }

        private void ekle_Lbl_Click(object sender, EventArgs e)
        {
            Soru_Cevap_Ekleme s = new Soru_Cevap_Ekleme();
            this.Hide();
            s.Show();
        }

        private void siralama_Lbl_Click(object sender, EventArgs e)
        {
            Siralama si = new Siralama();
            this.Hide();
            si.Show();  
        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
