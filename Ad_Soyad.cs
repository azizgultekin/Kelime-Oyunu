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
    public partial class Ad_Soyad : Form
    {
        public Ad_Soyad()
        {
            InitializeComponent();
        }
        
        private void Ad_Soyad_Load(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
            textBox2.SelectionStart = textBox2.Text.Length;

            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                pictureBox1.Visible = false;
                label20.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                label20.Visible = true;
            }
            
        }

        private void label20_Click(object sender, EventArgs e)
        {
            Kelime_Oyunu k = new Kelime_Oyunu();
            k.yazi = textBox1.Text + " " + textBox2.Text;
            this.Hide();
            k.Show();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void Ad_Soyad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            this.Hide();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
