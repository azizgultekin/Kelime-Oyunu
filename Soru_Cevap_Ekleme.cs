using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Yazilim_Gelistirme_Lab_Proje
{
    public partial class Soru_Cevap_Ekleme : Form
    {
        public Soru_Cevap_Ekleme()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        void baglantiKontrol()
        {
            con = new MySqlConnection("Server=localhost;Database=yaz_lab_proje;user=root;Pwd=123456789;SslMode=none");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void soru_cevap_Ekle()
        {
            if(textBox1.TextLength == 4)
            {
                baglantiKontrol();
                DateTime bugun = DateTime.Now;
                MySqlCommand ekle = new MySqlCommand("insert into harf_sayisi_4 (Soru,Cevap) values ('" + richTextBox1.Text + "','" + textBox1.Text + "')", con);
                ekle.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Soru ve Cevabınız başarılı bir şekilde veritabanına eklenmiştir.");
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
            else if(textBox1.TextLength == 5)
            {
                baglantiKontrol();
                DateTime bugun = DateTime.Now;
                MySqlCommand ekle = new MySqlCommand("insert into harf_sayisi_5 (Soru,Cevap) values ('" + richTextBox1.Text + "','" + textBox1.Text + "')", con);
                ekle.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Soru ve Cevabınız başarılı bir şekilde veritabanına eklenmiştir.");
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
            else if (textBox1.TextLength == 6)
            {
                baglantiKontrol();
                DateTime bugun = DateTime.Now;
                MySqlCommand ekle = new MySqlCommand("insert into harf_sayisi_6 (Soru,Cevap) values ('" + richTextBox1.Text + "','" + textBox1.Text + "')", con);
                ekle.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Soru ve Cevabınız başarılı bir şekilde veritabanına eklenmiştir.");
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
            else if (textBox1.TextLength == 7)
            {
                baglantiKontrol();
                DateTime bugun = DateTime.Now;
                MySqlCommand ekle = new MySqlCommand("insert into harf_sayisi_7 (Soru,Cevap) values ('" + richTextBox1.Text + "','" + textBox1.Text + "')", con);
                ekle.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Soru ve Cevabınız başarılı bir şekilde veritabanına eklenmiştir.");
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
            else if (textBox1.TextLength == 8)
            {
                baglantiKontrol();
                DateTime bugun = DateTime.Now;
                MySqlCommand ekle = new MySqlCommand("insert into harf_sayisi_8 (Soru,Cevap) values ('" + richTextBox1.Text + "','" + textBox1.Text + "')", con);
                ekle.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Soru ve Cevabınız başarılı bir şekilde veritabanına eklenmiştir.");
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
            else if (textBox1.TextLength == 9)
            {
                baglantiKontrol();
                DateTime bugun = DateTime.Now;
                MySqlCommand ekle = new MySqlCommand("insert into harf_sayisi_9 (Soru,Cevap) values ('" + richTextBox1.Text + "','" + textBox1.Text + "')", con);
                ekle.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Soru ve Cevabınız başarılı bir şekilde veritabanına eklenmiştir.");
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
            else if (textBox1.TextLength == 10)
            {
                baglantiKontrol();
                DateTime bugun = DateTime.Now;
                MySqlCommand ekle = new MySqlCommand("insert into harf_sayisi_10 (Soru,Cevap) values ('" + richTextBox1.Text + "','" + textBox1.Text + "')", con);
                ekle.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Soru ve Cevabınız başarılı bir şekilde veritabanına eklenmiştir.");
                richTextBox1.Text = "";
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Cevabınızın harf sayısını kontrol edniz!!!");
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label20_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text.ToString();
            int sonuc;
            sonuc = String.Compare("'",a);
            if (sonuc == -1)
            {
                a = a.Replace("'", " ");
                richTextBox1.Text = a;
            }
            soru_cevap_Ekle();
            pictureBox1.Visible = false;
            label20.Visible = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
            if (richTextBox1.TextLength!=0 && textBox1.TextLength!=0)
            {
                label20.Visible = true;
                pictureBox1.Visible = true;
            }
        }
        private void Soru_Cevap_Ekleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            this.Hide();
            a.Show();
        }
    }
}
