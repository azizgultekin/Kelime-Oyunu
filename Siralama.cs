using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace Yazilim_Gelistirme_Lab_Proje
{
    public partial class Siralama : Form
    {
        public Siralama()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlDataAdapter da;
        DataSet ds;
        public int i=0;
     
        private void Siralama_Load(object sender, EventArgs e)
        {
            griddoldur();
            DataGridView veriTablosu = dataGridView1;
            string file = "C:\\Users\\Aziz GÜLTEKİN\\Desktop\\Yazilim_Gelistirme_Lab_Proje\\İlk5.txt";
            FileStream stream = File.Create(file);
            StreamWriter sw = new StreamWriter(stream);
            foreach (DataGridViewColumn sutun in veriTablosu.Columns)
            {
                sw.Write(sutun.HeaderText + "     ");
            }
            sw.WriteLine("\n");
            foreach (DataGridViewRow satir in veriTablosu.Rows)
            {
                i++;
                sw.Write(i + ". ");
                foreach (DataGridViewCell hucre in satir.Cells)
                {
                    sw.Write(hucre.Value.ToString() + "     ");
                }
                sw.Write("\n");
                if (i==5)
                {
                    break;
                }
            }
            sw.Close();
        }
        void baglantiKontrol()
        {
            con = new MySqlConnection("Server=localhost;Database=yaz_lab_proje;user=root;Pwd=123456789;SslMode=none");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void Siralama_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            this.Hide();          
            a.Show();
        }
        void griddoldur()
        {
            baglantiKontrol();
            da = new MySqlDataAdapter("Select ad_soyad as Adı_Soyadı,puan as Puanı,sure as Süresi,oynanilan_zaman as Oynanılan_Zaman From Siralama ORDER BY puan DESC, sure", con);
            ds = new DataSet();
            da.Fill(ds, "Siralama");
            dataGridView1.DataSource = ds.Tables["Siralama"];
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
