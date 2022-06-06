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
    public partial class FrmAnasayfa : Form
    {
        int toplam = 0;
        public FrmAnasayfa()
        {
            InitializeComponent();


            var deger = new Random();

            for (int i = 0; i <= 1; i++)
            {
                int sayi = deger.Next(1, 15);
                listBox1.Items.Add(sayi);
                toplam += sayi;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRandevu randevu=new FrmRandevu();    
            FormGetir(randevu);
            
        }


        public void FormGetir(Form frm)
            {
                panel3.Controls.Clear();
                frm.MdiParent = this;
                frm.FormBorderStyle = FormBorderStyle.None;
                panel3.Controls.Add(frm);
                frm.Show();
            


            }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmMarket market=new FrmMarket();
            FormGetir(market);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmHizmetler hizmetler=new FrmHizmetler();
            FormGetir(hizmetler);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmStok stok=new FrmStok();
            FormGetir(stok);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmCalisan calisanlar=new FrmCalisan();
            FormGetir(calisanlar);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dogrula();
           
            if (kullaniciKontrol(textBoxk_Adi.Text, textBoxsifre.Text) == 1 && dog == true)
            {
                MessageBox.Show("giriş başarılı");
                textBoxtoplam.Clear();
                yeter = true;
                

            }

            else
            {
                MessageBox.Show("giriş yapılamadı şifre veya doğrulama işleminiz hatalı..");

            }


        }
        MySqlConnection baglan = new MySqlConnection("SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345");

        public int kullaniciKontrol(String k_Adii, String sifree)
        {
            string ConStr = "SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345";
            int sonuc = 0;
            using (var con = new MySqlConnection(ConStr))
            {
                using (var cmd = new MySqlCommand($"SELECT k_adi,sifre FROM sorguekrani WHERE k_adi='{k_Adii}' AND sifre='{sifree}'", con))

                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            string d_k = dtr["k_adi"].ToString();
                            string d_s = dtr["sifre"].ToString();
                            if (d_k == k_Adii && d_s == sifree)
                            {
                                sonuc = 1;

                            }
                            else
                            {
                                sonuc = 0;
                            }

                        }

                    }
                    catch
                    {

                        sonuc = 0;
                    }
                }
            }

            return sonuc;
        }

        bool dog = false;
        bool yeter = false;
        public void dogrula()
        {

            if (textBoxtoplam.Text == Convert.ToString(toplam))
            {
                dog = true;
               // MessageBox.Show("doğrulama işleminiz başarılı giriş yapınız");
            }
            else
            {
               // MessageBox.Show("doğrulama işleminiz başarısız");

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345");
            try
            {
                baglan.Open();

                MySqlCommand ekle = new MySqlCommand("insert into notlar (notlat) values ('" + textBox1.Text + "')", baglan);

                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery();
                if (sonuc != null)
                    MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                baglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345");
            string sql = "SELECT * FROM notlar";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = sql;
            command.Connection = baglan;
            adapter.SelectCommand = command;
            baglan.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            FrmAnasayfa anasayfa=new FrmAnasayfa();

            anasayfa.Show();
            this.Hide();


        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345");
            try
            {
                baglan.Open();

                MySqlCommand ekle = new MySqlCommand("insert into notlar (notlat) values ('" + textBox1.Text + "')", baglan);

                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery();
                if (sonuc != null)
                    MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                baglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345");
            string sql = "SELECT * FROM notlar";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = sql;
            command.Connection = baglan;
            adapter.SelectCommand = command;
            baglan.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmHediyeÇeki hediyeÇeki = new FrmHediyeÇeki();
            FormGetir(hediyeÇeki);
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
        }
    }
}
