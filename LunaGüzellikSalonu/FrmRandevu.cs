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
    public partial class FrmRandevu : Form
    {
        public FrmRandevu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345");
            try
            {
                baglan.Open();

                MySqlCommand ekle = new MySqlCommand("insert into randevu (adsoyad,tedavi,gün,saat,tc) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value + "','" +textBox4.Text + "','" + textBox5.Text + "')", baglan);
             
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

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345");
            string sql = "SELECT * FROM randevu";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = sql;
            command.Connection = baglan;
            adapter.SelectCommand = command;
            baglan.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void yenile()
        {
            MySqlConnection baglan = new MySqlConnection("SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345");
            string sql = "SELECT * FROM randevu";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = sql;
            command.Connection = baglan;
            adapter.SelectCommand = command;
            baglan.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MySqlConnection baglan = new MySqlConnection("SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345");
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {

                baglan.Open();
                MySqlCommand sil = new MySqlCommand("DELETE FROM randevu where tc='"+dataGridView1.SelectedRows[i].Cells["tc"].Value.ToString()+"'",baglan);
                sil.ExecuteNonQuery();
                baglan.Close();
            }
            MessageBox.Show("Seçilen kayıtlar silindi..");
            yenile();

        }
    }
}
