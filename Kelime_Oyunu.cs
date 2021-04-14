using System;
using System.IO;
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
    public partial class Kelime_Oyunu : Form
    {
        public Kelime_Oyunu()
        {
            InitializeComponent();
        }

        int k, sorusayac=0, arapuan, tpuan, sorusaysayac=0, sansayac, daksayac=5, harfalsayac = 0, rsayi1, rsayi2,i,dizisayac, sayi, cevaplama_suresi;
        string  cevap;
        public string yazi;
        int[] sayilar = new int[15];
        Random r = new Random();
        Random rastgele = new Random();
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        
        private void label21_Click(object sender, EventArgs e)
        {
            cevapla();
        }
        public void tamam()
        {
            switch (sorusayac)
            {
                case 1:
                case 2:


                    
                    if (textBox1.Text.ToUpper() == cevap)
                    {
                        tpuan += arapuan;
                        textBox1.BackColor = Color.LightGreen;
                        label26.Text = "Tebrikler!!! Doğru Cevap";
                    }

                    else
                    {
                        tpuan -= arapuan;
                        textBox1.BackColor = Color.Red;
                        label26.Text = "Malesef!!! Yanlış Cevap";
                    }

                    label13.Text = tpuan.ToString();
                    label1.Text = cevap[0].ToString();
                    label2.Text = cevap[1].ToString();
                    label3.Text = cevap[2].ToString();
                    label4.Text = cevap[3].ToString();

                    break;

                case 3:
                case 4:

                    if (textBox1.Text.ToUpper() == cevap)
                    {
                        tpuan += arapuan;
                        textBox1.BackColor = Color.LightGreen;
                        label26.Text = "Tebrikler!!! Doğru Cevap";
                    }

                    else
                    {
                        tpuan -= arapuan;
                        textBox1.BackColor = Color.Red;
                        label26.Text = "Malesef!!! Yanlış Cevap";
                    }

                    label13.Text = tpuan.ToString();
                    label1.Text = cevap[0].ToString();
                    label2.Text = cevap[1].ToString();
                    label3.Text = cevap[2].ToString();
                    label4.Text = cevap[3].ToString();
                    label5.Text = cevap[4].ToString();

                    break;

                case 5:
                case 6:


                    if (textBox1.Text.ToUpper() == cevap)
                    {
                        tpuan += arapuan;
                        textBox1.BackColor = Color.LightGreen;
                        label26.Text = "Tebrikler!!! Doğru Cevap";
                    }

                    else
                    {
                        tpuan -= arapuan;
                        textBox1.BackColor = Color.Red;
                        label26.Text = "Malesef!!! Yanlış Cevap";
                    }

                    label13.Text = tpuan.ToString();
                    label1.Text = cevap[0].ToString();
                    label2.Text = cevap[1].ToString();
                    label3.Text = cevap[2].ToString();
                    label4.Text = cevap[3].ToString();
                    label5.Text = cevap[4].ToString();
                    label6.Text = cevap[5].ToString();

                    break;

                case 7:
                case 8:


                    if (textBox1.Text.ToUpper() == cevap)
                    {
                        tpuan += arapuan;
                        textBox1.BackColor = Color.LightGreen;
                        label26.Text = "Tebrikler!!! Doğru Cevap";
                    }

                    else
                    {
                        tpuan -= arapuan;
                        textBox1.BackColor = Color.Red;
                        label26.Text = "Malesef!!! Yanlış Cevap";
                    }

                    label13.Text = tpuan.ToString();
                    label1.Text = cevap[0].ToString();
                    label2.Text = cevap[1].ToString();
                    label3.Text = cevap[2].ToString();
                    label4.Text = cevap[3].ToString();
                    label5.Text = cevap[4].ToString();
                    label6.Text = cevap[5].ToString();
                    label7.Text = cevap[6].ToString();

                    break;

                case 9:
                case 10:

                    if (textBox1.Text.ToUpper() == cevap)
                    {
                        tpuan += arapuan;
                        textBox1.BackColor = Color.LightGreen;
                        label26.Text = "Tebrikler!!! Doğru Cevap";
                    }

                    else
                    {
                        tpuan -= arapuan;
                        textBox1.BackColor = Color.Red;
                        label26.Text = "Malesef!!! Yanlış Cevap";
                    }
                    label13.Text = tpuan.ToString();
                    label1.Text = cevap[0].ToString();
                    label2.Text = cevap[1].ToString();
                    label3.Text = cevap[2].ToString();
                    label4.Text = cevap[3].ToString();
                    label5.Text = cevap[4].ToString();
                    label6.Text = cevap[5].ToString();
                    label7.Text = cevap[6].ToString();
                    label8.Text = cevap[7].ToString();

                    break;

                case 11:
                case 12:

                    if (textBox1.Text.ToUpper() == cevap)
                    {
                        tpuan += arapuan;
                        textBox1.BackColor = Color.LightGreen;
                        label26.Text = "Tebrikler!!! Doğru Cevap";
                    }

                    else
                    {
                        tpuan -= arapuan;
                        textBox1.BackColor = Color.Red;
                        label26.Text = "Malesef!!! Yanlış Cevap";
                    }

                    label13.Text = tpuan.ToString();
                    label1.Text = cevap[0].ToString();
                    label2.Text = cevap[1].ToString();
                    label3.Text = cevap[2].ToString();
                    label4.Text = cevap[3].ToString();
                    label5.Text = cevap[4].ToString();
                    label6.Text = cevap[5].ToString();
                    label7.Text = cevap[6].ToString();
                    label8.Text = cevap[7].ToString();
                    label9.Text = cevap[8].ToString();

                    break;

                case 13:
                case 14:

                    if (textBox1.Text.ToUpper() == cevap)
                    {
                        tpuan += arapuan;
                        textBox1.BackColor = Color.LightGreen;
                        label26.Text = "Tebrikler!!! Doğru Cevap";
                    }

                    else
                    {
                        tpuan -= arapuan;
                        textBox1.BackColor = Color.Red;
                        label26.Text = "Malesef!!! Yanlış Cevap";
                    }

                    label13.Text = tpuan.ToString();
                    label1.Text = cevap[0].ToString();
                    label2.Text = cevap[1].ToString();
                    label3.Text = cevap[2].ToString();
                    label4.Text = cevap[3].ToString();
                    label5.Text = cevap[4].ToString();
                    label6.Text = cevap[5].ToString();
                    label7.Text = cevap[6].ToString();
                    label8.Text = cevap[7].ToString();
                    label9.Text = cevap[8].ToString();
                    label10.Text = cevap[9].ToString();

                    break;

            }
            pictureBox13.Visible = true;
            label22.Visible = true;
            textBox1.Enabled = false;
            label24.Visible = false;
            label27.Visible = false;
            pictureBox16.Visible = false;
            timer2.Enabled = false;
            pictureBox14.Visible = false;
            pictureBox17.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label26.Visible = true;
            label25.Visible = false;
        }
        public void cevapla() 
        {
            label20.Visible = false;
            pictureBox17.Visible = false;
            label21.Visible = false;
            pictureBox14.Visible = false;
            label24.Visible = true;
            label26.Visible = false;
            label27.Visible = true;
            pictureBox16.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = "";
            textBox1.BackColor = Color.DarkGray;
            timer1.Enabled=false;
            timer2.Enabled = true;
            switch (sorusayac)
            {
                case 1:
                case 2:

                     textBox1.MaxLength = 4;
                     break;

                case 3:
                case 4:

                    textBox1.MaxLength = 5;
                    break;

                case 5:
                case 6:

                    textBox1.MaxLength = 6;
                    break;

                case 7:
                case 8:

                    textBox1.MaxLength = 7;
                    break;

                case 9:
                case 10:

                    textBox1.MaxLength = 8;
                    break;

                case 11:
                case 12:

                    textBox1.MaxLength = 9;
                    break;

                case 13:
                case 14:

                    textBox1.MaxLength = 10;
                    break;

            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void Kelime_Oyunu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            if(cevaplama_suresi==0)
            {
                tpuan -= arapuan;
                pictureBox13.Visible = true;
                label24.Visible = true;
                label26.Visible = true;
                pictureBox16.Visible = false;
                label24.Visible = false;
                label27.Visible = false;
                label25.Visible = false;
                label22.Visible = true;
                label26.Text = "Cevap verme süreniz bitti!!!";
                textBox1.BackColor = Color.LightYellow;
                switch (sorusayac)
                {
                    case 1:
                    case 2:

                        label1.Text = cevap[0].ToString();
                        label2.Text = cevap[1].ToString();
                        label3.Text = cevap[2].ToString();
                        label4.Text = cevap[3].ToString();

                        break;

                    case 3:
                    case 4:

                        label1.Text = cevap[0].ToString();
                        label2.Text = cevap[1].ToString();
                        label3.Text = cevap[2].ToString();
                        label4.Text = cevap[3].ToString();
                        label5.Text = cevap[4].ToString();

                        break;

                    case 5:
                    case 6:

                        label1.Text = cevap[0].ToString();
                        label2.Text = cevap[1].ToString();
                        label3.Text = cevap[2].ToString();
                        label4.Text = cevap[3].ToString();
                        label5.Text = cevap[4].ToString();
                        label6.Text = cevap[5].ToString();

                        break;

                    case 7:
                    case 8:

                        label1.Text = cevap[0].ToString();
                        label2.Text = cevap[1].ToString();
                        label3.Text = cevap[2].ToString();
                        label4.Text = cevap[3].ToString();
                        label5.Text = cevap[4].ToString();
                        label6.Text = cevap[5].ToString();
                        label7.Text = cevap[6].ToString();

                        break;

                    case 9:
                    case 10:

                        label1.Text = cevap[0].ToString();
                        label2.Text = cevap[1].ToString();
                        label3.Text = cevap[2].ToString();
                        label4.Text = cevap[3].ToString();
                        label5.Text = cevap[4].ToString();
                        label6.Text = cevap[5].ToString();
                        label7.Text = cevap[6].ToString();
                        label8.Text = cevap[7].ToString();

                        break;

                    case 11:
                    case 12:

                        label1.Text = cevap[0].ToString();
                        label2.Text = cevap[1].ToString();
                        label3.Text = cevap[2].ToString();
                        label4.Text = cevap[3].ToString();
                        label5.Text = cevap[4].ToString();
                        label6.Text = cevap[5].ToString();
                        label7.Text = cevap[6].ToString();
                        label8.Text = cevap[7].ToString();
                        label9.Text = cevap[8].ToString();

                        break;

                    case 13:
                    case 14:

                        label1.Text = cevap[0].ToString();
                        label2.Text = cevap[1].ToString();
                        label3.Text = cevap[2].ToString();
                        label4.Text = cevap[3].ToString();
                        label5.Text = cevap[4].ToString();
                        label6.Text = cevap[5].ToString();
                        label7.Text = cevap[6].ToString();
                        label8.Text = cevap[7].ToString();
                        label9.Text = cevap[8].ToString();
                        label10.Text = cevap[9].ToString();

                        break;

                }
                textBox1.Enabled = false;
                timer2.Enabled = false;
                label13.Text = tpuan.ToString();
                
            }
            cevaplama_suresi = cevaplama_suresi - 1;
            label25.Text = cevaplama_suresi.ToString();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            tamam();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            harfAl();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            sonrakiSoru();
        }

        void baglantiKontrol()
        {
            con = new MySqlConnection("Server=localhost;Database=yaz_lab_proje;user=root;Pwd=123456789;SslMode=none");
            if (con.State == ConnectionState.Closed)
            {
                 con.Open();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (rsayi1)
                {
                    case 1:
                        if (k < 15)
                        {
                            rsayi2 = r.Next(65, 91);
                            label1.Text = ((char)rsayi2).ToString();
                            k++;
                        }
                        else
                        {
                            timer3.Enabled = false;
                            label1.Text = cevap[0].ToString();
                            k = 0;
                        }

                        break;
                    case 2:
                        if (k < 15)
                        {
                            rsayi2 = r.Next(65, 91);
                            label2.Text = ((char)rsayi2).ToString();
                            k++;
                        }
                        else
                        {
                            timer3.Enabled = false;
                            label2.Text = cevap[1].ToString();
                            k = 0;
                        }
                        break;
                    case 3:
                        if (k < 15)
                        {
                            rsayi2 = r.Next(65, 91);
                            label3.Text = ((char)rsayi2).ToString();
                            k++;
                        }
                        else
                        {
                            timer3.Enabled = false;
                            label3.Text = cevap[2].ToString();
                            k = 0;
                        }
                        break;
                    case 4:
                        if (k < 15)
                        {
                            rsayi2 = r.Next(65, 91);
                            label4.Text = ((char)rsayi2).ToString();
                            k++;
                        }
                        else
                        {
                            timer3.Enabled = false;
                            label4.Text = cevap[3].ToString();
                            k = 0;
                        }
                        break;
                    case 5:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label5.Text = ((char)rsayi2).ToString();
                            k++; 
                        }
                        else
                        {
                            timer3.Enabled = false;
                            label5.Text = cevap[4].ToString();
                            k = 0;
                        }
                        break;
                    case 6:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label6.Text = ((char)rsayi2).ToString();
                            k++;
                        }
                        else
                        {
                            timer3.Enabled = false;
                            label6.Text = cevap[5].ToString();
                            k = 0;
                        }
                        break;
                    case 7:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label7.Text = ((char)rsayi2).ToString();
                            k++;
                        }
                        else
                        {
                            timer3.Enabled = false;
                            label7.Text = cevap[6].ToString();
                            k = 0; 
                        }
                        break;
                    case 8:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label8.Text = ((char)rsayi2).ToString();
                            k++;
                        }
                        else
                        {
                            timer3.Enabled = false;
                            label8.Text = cevap[7].ToString();
                            k = 0;
                        }
                        break;
                    case 9:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label9.Text = ((char)rsayi2).ToString();
                            k++;
                        }
                        else
                        {
                            timer3.Enabled = false;
                            label9.Text = cevap[8].ToString();
                            k = 0;
                        }
                        break;
                    case 10:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label10.Text = ((char)rsayi2).ToString();
                            k++;
                        }
                        else
                        {
                            timer3.Enabled = false;
                            label10.Text = cevap[9].ToString();
                            k = 0;
                        }
                        break;
                    default:
                        MessageBox.Show("Hata");
                        break;
                }
            }
            catch
            {
                ;
            }
        }
        public void harfAl()
        {
            i = 0;
            dizisayac++;
            switch (sorusayac)
            {
                case 1:
                case 2:
                    
                    while (i == 0)
                    {   
                        rsayi1 = rastgele.Next(1, 5);
                        int yoksa = Array.IndexOf(sayilar, rsayi1);
                        if (yoksa == -1)
                        {
                            sayilar[dizisayac] = rsayi1;
                            arapuan -= 100;
                            label14.Text = arapuan.ToString();
                            i++;
                            harfalsayac++;
                        }
                    }

                    timer3.Enabled = true;
                    
                    if (harfalsayac == 4)
                    {
                        label20.Visible = false;
                        label21.Visible = false;
                        label22.Visible = true;
                        pictureBox13.Visible = true;
                        pictureBox14.Visible = false;
                        pictureBox17.Visible = false;
                        harfalsayac = 0;
                        timer1.Enabled = false;
                    }

                    break;

                case 3:
                case 4:
                    while (i == 0)
                    {
                        rsayi1 = rastgele.Next(1, 6);
                        int yoksa = Array.IndexOf(sayilar, rsayi1);
                        if (yoksa == -1)
                        {
                            sayilar[dizisayac] = rsayi1;
                            arapuan -= 100;
                            label14.Text = arapuan.ToString();
                            i++;
                            harfalsayac++;
                        }
                    }

                    timer3.Enabled = true;

                    if (harfalsayac == 5)
                    {
                        label20.Visible = false;
                        label21.Visible = false;
                        label22.Visible = true;
                        pictureBox13.Visible = true;
                        pictureBox14.Visible = false;
                        pictureBox17.Visible = false;
                        harfalsayac = 0;
                        timer1.Enabled = false;
                    }

                    break;

                case 5:
                case 6:
                    while (i == 0)
                    {
                        rsayi1 = rastgele.Next(1, 7);
                        int yoksa = Array.IndexOf(sayilar, rsayi1);
                        if (yoksa == -1)
                        {
                            sayilar[dizisayac] = rsayi1;
                            arapuan -= 100;
                            label14.Text = arapuan.ToString();
                            i++;
                            harfalsayac++;
                        }
                    }

                    timer3.Enabled = true;

                    if (harfalsayac == 6)
                    {
                        label20.Visible = false;
                        label21.Visible = false;
                        label22.Visible = true;
                        pictureBox13.Visible = true;
                        pictureBox14.Visible = false;
                        pictureBox17.Visible = false;
                        harfalsayac = 0;
                        timer1.Enabled = false;
                    }

                    break;

                case 7:
                case 8:
                    while (i == 0)
                    {
                        rsayi1 = rastgele.Next(1, 8);
                        int yoksa = Array.IndexOf(sayilar, rsayi1);
                        if (yoksa == -1)
                        {
                            sayilar[dizisayac] = rsayi1;
                            arapuan -= 100;
                            label14.Text = arapuan.ToString();
                            i++;
                            harfalsayac++;
                        }
                    }

                    timer3.Enabled = true;

                    if (harfalsayac == 7)
                    {
                        label20.Visible = false;
                        label21.Visible = false;
                        label22.Visible = true;
                        pictureBox13.Visible = true;
                        pictureBox14.Visible = false;
                        pictureBox17.Visible = false;
                        harfalsayac = 0;
                        timer1.Enabled = false;
                    }

                    break;

                case 9:
                case 10:
                    while (i == 0)
                    {
                        rsayi1 = rastgele.Next(1, 9);
                        int yoksa = Array.IndexOf(sayilar, rsayi1);
                        if (yoksa == -1)
                        {
                            sayilar[dizisayac] = rsayi1;
                            arapuan -= 100;
                            label14.Text = arapuan.ToString();
                            i++;
                            harfalsayac++;
                        }
                    }

                    timer3.Enabled = true;

                    if (harfalsayac == 8)
                    {
                        label20.Visible = false;
                        label21.Visible = false;
                        label22.Visible = true;
                        pictureBox13.Visible = true;
                        pictureBox14.Visible = false;
                        pictureBox17.Visible = false;
                        harfalsayac = 0;
                        timer1.Enabled = false;
                    }

                    break;

                case 11:
                case 12:
                    while (i == 0)
                    {
                        rsayi1 = rastgele.Next(1, 10);
                        int yoksa = Array.IndexOf(sayilar, rsayi1);
                        if (yoksa == -1)
                        {
                            sayilar[dizisayac] = rsayi1;
                            arapuan -= 100;
                            label14.Text = arapuan.ToString();
                            i++;
                            harfalsayac++;
                        }
                    }

                    timer3.Enabled = true;

                    if (harfalsayac == 9)
                    {
                        label20.Visible = false;
                        label21.Visible = false;
                        label22.Visible = true;
                        pictureBox13.Visible = true;
                        pictureBox14.Visible = false;
                        pictureBox17.Visible = false;
                        harfalsayac = 0;
                        timer1.Enabled = false;
                    }

                    break;

                case 13:
                case 14:

                    while (i == 0)
                    {
                        rsayi1 = rastgele.Next(1, 11);
                        int yoksa = Array.IndexOf(sayilar, rsayi1);
                        if (yoksa == -1)
                        {
                            sayilar[dizisayac] = rsayi1;
                            arapuan -= 100;
                            label14.Text = arapuan.ToString();
                            i++;
                            harfalsayac++;
                        }
                    }

                    timer3.Enabled = true;

                    if (harfalsayac == 10)
                    {
                        label20.Visible = false;
                        label21.Visible = false;
                        label22.Visible = true;
                        pictureBox13.Visible = true;
                        pictureBox14.Visible = false;
                        pictureBox17.Visible = false;
                        harfalsayac = 0;
                        timer1.Enabled = false;
                    }

                    break;

            }

        }
        public void sonrakiSoru()
        {
            harfalsayac = 0;
            cevaplama_suresi = 20;
            timer1.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Visible = false;
            label26.Visible = false;
            timer3.Enabled = false;
            label22.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = true;
            pictureBox17.Visible = true;
            try
            {
                sorusaysayac++;
                if (sorusaysayac == 1)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    arapuan = 400;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "1. Soru";
                }
                else if (sorusaysayac == 2)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    arapuan = 400;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "2. Soru";
                }
                else if(sorusaysayac == 3)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    arapuan = 500;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "3. Soru";
                }
                else if(sorusaysayac == 4)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    arapuan = 500;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "4. Soru";
                }
                else if(sorusaysayac == 5)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    arapuan = 600;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "5. Soru";
                }
                else if(sorusaysayac == 6)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    arapuan = 600;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "6. Soru";
                }
                else if(sorusaysayac == 7)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    arapuan = 700;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "7. Soru";
                }
                else if(sorusaysayac == 8)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    arapuan = 700;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "8. Soru";
                }
                else if(sorusaysayac == 9)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    arapuan = 800;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "9. Soru";
                }
                else if(sorusaysayac == 10)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;
                    arapuan = 800;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "10. Soru";
                }
                else if(sorusaysayac == 11)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                    arapuan = 900;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "11. Soru";
                }
                else if(sorusaysayac == 12)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                    arapuan = 900;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "12. Soru";
                }
                else if(sorusaysayac == 13)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = true;
                    arapuan = 1000;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "13. Soru";
                }
                else if(sorusaysayac == 14)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = true;
                    arapuan = 1000;
                    label13.Text = tpuan.ToString();
                    label14.Text = arapuan.ToString();
                    label11.Text = "14. Soru";
                    label22.Text = "DEVAM ET";
                }
                
                else
                {
                    timer1.Stop();
                    baglantiKontrol();
                    DateTime bugun = DateTime.Now;
                    string a = label16.Text + ":" + label17.Text;
                    MySqlCommand ekle = new MySqlCommand("insert into Siralama (ad_soyad,puan,sure,oynanilan_zaman) values ('" + label23.Text + "','" + tpuan + "','" + a + "','" + bugun + "')", con);
                    ekle.ExecuteNonQuery();
                    con.Close();
                    Siralama s = new Siralama();
                    this.Hide();
                    s.Show();
                }
               

                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                Array.Clear(sayilar, 0, (sayilar.Length));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
            sorusayac++;
            dizisayac = 0;
            label20.Visible = true;
            label21.Visible = true;
            int sayi2;
            baglantiKontrol();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            switch (sorusayac)
            {
                case 1:
                    sayi = rastgele.Next(1, 33);
                    cmd.CommandText = "SELECT * FROM harf_sayisi_4 where id=" + sayi;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 2:
                   sayi2 = rastgele.Next(1, 33);
                    if (sayi == sayi2)
                    {
                        sayi2--;
                        if (sayi2 == 0)
                        {
                            sayi2 = sayi2 + 2;
                        }
                    }
                    cmd.CommandText = "SELECT * FROM harf_sayisi_4 where id=" + sayi2;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 3:
                    sayi = rastgele.Next(1, 33);
                    cmd.CommandText = "SELECT * FROM harf_sayisi_5 where id=" + sayi;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 4:
                   sayi2 = rastgele.Next(1, 33);
                    if (sayi == sayi2)
                    {
                        sayi2--;
                        if (sayi2 == 0)
                        {
                            sayi2 = sayi2 + 2;
                        }
                    }
                    cmd.CommandText = "SELECT * FROM harf_sayisi_5 where id=" + sayi2;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 5:
                    sayi = rastgele.Next(1, 33);
                    cmd.CommandText = "SELECT * FROM harf_sayisi_6 where id=" + sayi;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 6:
                   sayi2 = rastgele.Next(1, 33);
                    if (sayi == sayi2)
                    {
                        sayi2--;
                        if (sayi2 == 0)
                        {
                            sayi2 = sayi2 + 2;
                        }
                    }
                    cmd.CommandText = "SELECT * FROM harf_sayisi_6 where id=" + sayi2;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 7:
                    sayi = rastgele.Next(1, 33);
                    cmd.CommandText = "SELECT * FROM harf_sayisi_7 where id=" + sayi;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 8:
                   sayi2 = rastgele.Next(1, 33);
                    if (sayi == sayi2)
                    {
                        sayi2--;
                        if (sayi2 == 0)
                        {
                            sayi2 = sayi2 + 2;
                        }
                    }
                    cmd.CommandText = "SELECT * FROM harf_sayisi_7 where id=" + sayi2;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 9:
                    sayi = rastgele.Next(1, 33);
                    cmd.CommandText = "SELECT * FROM harf_sayisi_8 where id=" + sayi;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 10:
                   sayi2 = rastgele.Next(1, 33);
                    if (sayi == sayi2)
                    {
                        sayi2--;
                        if (sayi2 == 0)
                        {
                            sayi2 = sayi2 + 2;
                        }
                    }
                    cmd.CommandText = "SELECT * FROM harf_sayisi_8 where id=" + sayi2;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 11:
                    sayi = rastgele.Next(1, 33);
                    cmd.CommandText = "SELECT * FROM harf_sayisi_9 where id=" + sayi;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 12:
                   sayi2 = rastgele.Next(1, 33);
                    if (sayi == sayi2)
                    {
                        sayi2--;
                        if (sayi2 == 0)
                        {
                            sayi2 = sayi2 + 2;
                        }
                    }
                    cmd.CommandText = "SELECT * FROM harf_sayisi_9 where id=" + sayi2;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 13:
                    sayi = rastgele.Next(1, 33);
                    cmd.CommandText = "SELECT * FROM harf_sayisi_10 where id=" + sayi;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;

                case 14:
                   sayi2 = rastgele.Next(1, 33);
                    if (sayi == sayi2)
                    {
                        sayi2--;
                        if (sayi2 == 0)
                        {
                            sayi2 = sayi2 + 2;
                        }
                    }
                    cmd.CommandText = "SELECT * FROM harf_sayisi_10 where id=" + sayi2;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label19.Text = dr["Soru"].ToString();
                        label15.Text = dr["Cevap"].ToString();
                        cevap = label15.Text;
                    }
                    dr.Close();

                    break;
            }
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (sansayac == 0)
            {
                daksayac = daksayac - 1;
                label17.Text = "0"+Convert.ToString(daksayac);
                sansayac = 60;
            }
            sansayac = sansayac - 1;
            if (sansayac==9)
            {
                label17.Text = "0" + Convert.ToString(sansayac);
            }
            else if (sansayac == 8)
            {
                label17.Text = "0" + Convert.ToString(sansayac);
            }
            else if (sansayac == 7)
            {
                label17.Text = "0" + Convert.ToString(sansayac);
            }
            else if (sansayac == 6)
            {
                label17.Text = "0" + Convert.ToString(sansayac);
            }
            else if (sansayac == 5)
            {
                label17.Text = "0" + Convert.ToString(sansayac);
            }
            else if (sansayac == 4)
            {
                label17.Text = "0" + Convert.ToString(sansayac);
            }
            else if (sansayac == 3)
            {
                label17.Text = "0" + Convert.ToString(sansayac);
            }
            else if (sansayac == 2)
            {
                label17.Text = "0" + Convert.ToString(sansayac);
            }
            else if (sansayac == 1)
            {
                label17.Text = "0" + Convert.ToString(sansayac);
            }
            else if (sansayac == 0)
            {
                label17.Text = "0" + Convert.ToString(sansayac);
            }
            else 
            {
                label17.Text = Convert.ToString(sansayac);
                label16.Text = "0"+Convert.ToString(daksayac - 1);
            }
            

            if (label16.Text == "0-1")
            {
                timer1.Stop();
                label17.Text = "00";
                label16.Text = "00";
                baglantiKontrol();
                DateTime bugun = DateTime.Now;
                string a = label16.Text + ":" + label17.Text;
                MySqlCommand ekle = new MySqlCommand("insert into Siralama (ad_soyad,puan,sure,oynanilan_zaman) values ('" + label23.Text + "','" + tpuan + "','" + a + "','" + bugun + "')", con);
                ekle.ExecuteNonQuery();
                con.Close();

                Siralama s = new Siralama();
                s.ShowDialog();
                this.Hide();

            }
        }
        private void Kelime_Oyunu_Load(object sender, EventArgs e)
        {
            sonrakiSoru();
            label23.Text=yazi;  
            timer1.Start();
            timer2.Enabled = false;
            timer3.Interval = 5;
            timer3.Enabled = false;
            label22.Visible = false;
            pictureBox13.Visible = false; 
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
