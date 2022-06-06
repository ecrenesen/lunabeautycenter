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

namespace LunaGüzellikSalonu
{
    public partial class FrmMarket : Form
    {
        public FrmMarket()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox1.Checked)
            {
                listBox1.Items.Add(miktarAl.Text + " tane " + checkBox1.Text + " " + fiyatAl.Text + " ₺ ");
                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(fiyatAl.Text) * Convert.ToInt32(miktarAl.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarAl.Text + "" + checkBox1.Text + " " + fiyatAl.Text);
                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(fiyatAl.Text) * Convert.ToInt32(miktarAl.Text);
                textBox.Text = toplam.ToString();

            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox2.Checked)
            {
                listBox1.Items.Add(miktarrimel.Text+" tane " +checkBox2.Text + " " + label3.Text+" ₺");
                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label3.Text)* Convert.ToInt32(miktarrimel.Text); 
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarrimel.Text + "" +checkBox2.Text + " " + label3.Text);
                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label3.Text)* Convert.ToInt32(miktarrimel.Text);
                textBox.Text = toplam.ToString();

            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox3.Checked)
            {
                listBox1.Items.Add(miktargloss.Text+ " tane " + checkBox3.Text + " " + label4.Text+" ₺");
                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label4.Text)* Convert.ToInt32(miktargloss.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktargloss.Text+ checkBox3.Text + " " + label4.Text);
                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label4.Text)*Convert.ToInt32(miktargloss.Text);
                textBox.Text = toplam.ToString();

            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox4.Checked)
            {
                listBox1.Items.Add(miktarkrem.Text+ " tane " + checkBox4.Text + " " + label5.Text+" ₺");
                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label5.Text)* Convert.ToInt32(miktarkrem.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarkrem.Text+ checkBox4.Text + " " + label5.Text);
                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label5.Text)*Convert.ToInt32(miktarkrem.Text);
                textBox.Text = toplam.ToString();

            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox5.Checked)
            {
                listBox1.Items.Add(miktarserum.Text+ " tane " + checkBox5.Text + " " + label6.Text+"₺");
                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label6.Text)* Convert.ToInt32(miktarserum.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarserum.Text+ checkBox5.Text + " " + label6.Text);
                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label6.Text)* Convert.ToInt32(miktarserum.Text);
                textBox.Text = toplam.ToString();

            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox6.Checked)
            {
                listBox1.Items.Add(miktarsun.Text+ " tane " + checkBox6.Text + " " + label7.Text+"₺");
                toplam = Convert.ToInt32(textBox.Text) + Convert.ToInt32(label7.Text)* Convert.ToInt32(miktarsun.Text);
                textBox.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(miktarsun.Text+checkBox6.Text + " " + label7.Text);
                toplam = Convert.ToInt32(textBox.Text) - Convert.ToInt32(label7.Text)* Convert.ToInt32(miktarsun.Text);
                textBox.Text = toplam.ToString();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double kdv, toplam, maaliyet;
            toplam = Convert.ToInt32(textBox.Text);
            kdv = toplam / 100 * 15;
            maaliyet = toplam - kdv;
            richTextBox1.Text = "MALİYET= " + maaliyet + "\n";
            richTextBox1.Text += "KDV= " + kdv + "\n";
            richTextBox1.Text += "Ödenecek tutar= " + toplam;


            MySqlConnection baglan = new MySqlConnection("SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345");
            try
            {
                baglan.Open();

                MySqlCommand fiyatekle = new MySqlCommand("insert into satıs (fiyat) values ('" + textBox.Text + "')", baglan);

                object sonuc = null;
                sonuc = fiyatekle.ExecuteNonQuery();
                if (sonuc != null)
                {
                    //MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int a = 0;
                }

                else
                    MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                baglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void artiAl_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(miktarAl.Text);
            c++;
            miktarAl.Text = Convert.ToString(c);
        }



        private void eksiAl_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (c >= 0)
            {
                c = Convert.ToInt32(miktarAl.Text);
                c--;
                miktarAl.Text = Convert.ToString(c);
                if (c < 0)
                {
                    c = c * -1;
                    miktarAl.Text = Convert.ToString(c);
                }
            }
        }

        private void artigls_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(miktargloss.Text);
            k++;
            miktargloss.Text = Convert.ToString(k);

        }
       

        private void azaltgls_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (k >= 0)
            {
                k = Convert.ToInt32(miktargloss.Text);
                k--;
                miktargloss.Text = Convert.ToString(k);
                if (k < 0)
                {
                    k = k * -1;
                    miktargloss.Text = Convert.ToString(k);
                }
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(miktarserum.Text);
            c++;
            miktarserum.Text = Convert.ToString(c);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (c >= 0)
            {
                c = Convert.ToInt32(miktarserum.Text);
                c--;
                miktarserum.Text = Convert.ToString(c);
                if (c < 0)
                {
                    c = c * -1;
                    miktarserum.Text = Convert.ToString(c);
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(miktarrimel.Text);
            c++;
            miktarrimel.Text = Convert.ToString(c);

        }

        private void label14_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (c >= 0)
            {
                c = Convert.ToInt32(miktarrimel.Text);
                c--;
                miktarrimel.Text = Convert.ToString(c);
                if (c < 0)
                {
                    c = c * -1;
                    miktarrimel.Text = Convert.ToString(c);
                }
            }

        }

        private void label19_Click(object sender, EventArgs e)
        {

            int c = Convert.ToInt32(miktarkrem.Text);
            c++;
            miktarkrem.Text = Convert.ToString(c);

        }

        private void label17_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (c >= 0)
            {
                c = Convert.ToInt32(miktarkrem.Text);
                c--;
                miktarkrem.Text = Convert.ToString(c);
                if (c < 0)
                {
                    c = c * -1;
                    miktarkrem.Text = Convert.ToString(c);
                }
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(miktarsun.Text);
            c++;
            miktarsun.Text = Convert.ToString(c);
        }

        private void label20_Click(object sender, EventArgs e)
        {

            int c = 0;
            if (c >= 0)
            {
                c = Convert.ToInt32(miktarsun.Text);
                c--;
                miktarsun.Text = Convert.ToString(c);
                if (c < 0)
                {
                    c = c * -1;
                    miktarsun.Text = Convert.ToString(c);
                }
            }

        }
    }
}
