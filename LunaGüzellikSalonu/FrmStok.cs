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
using System.Net.Mail;
namespace LunaGüzellikSalonu
{
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345");
            string sql = "SELECT * FROM stok";
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

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                string MyConnection2 = "SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345";
               
                string Query = "update lunagüzelliksalonu.stok set iğne='" + this.textBox1.Text + "';";
         
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Veri Güncellendi");
                textBox1.Clear();
                button1_Click(sender, e);
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345";

                string Query = "update lunagüzelliksalonu.stok set temizleyici='" + this.textBox1.Text + "';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Veri Güncellendi");
                textBox1.Clear();
                button1_Click(sender, e);
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345";

                string Query = "update lunagüzelliksalonu.stok set pamuk='" + this.textBox1.Text + "';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Veri Güncellendi");
                textBox1.Clear();
                button1_Click(sender, e);
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345";

                string Query = "update lunagüzelliksalonu.stok set serum='" + this.textBox1.Text + "';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Veri Güncellendi");
                textBox1.Clear();
                button1_Click(sender, e);
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "SERVER=localhost;DATABASE=lunagüzelliksalonu;UID=root;PWD=12345";

                string Query = "update lunagüzelliksalonu.stok set vitamin='" + this.textBox1.Text + "';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Veri Güncellendi");
                textBox1.Clear();
                button1_Click(sender, e);
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        MailMessage eposta=new MailMessage();
        void MailGonder()
        {
            eposta.From = new MailAddress("ecrennuresen44@outlook.com");
            eposta.To.Add(textBox2.Text.ToString());
            eposta.Subject = textBox3.Text.ToString();
            eposta.Body = textBox4.Text.ToString();

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("ecrennuresen44@outlook.com", "123kecremn.");
            smtp.Host = "smtp.office365.com";
            smtp.EnableSsl = true;
            smtp.Port = 587;

            smtp.Send(eposta);
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("mail gönderildi");


        }


    private void button7_Click(object sender, EventArgs e)
        {
            MailGonder();
            

        }

       

        private void button8_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            FormToptancıİletisimcs toptancı = new FormToptancıİletisimcs();
            toptancı.TopLevel = false;
            panel2.Controls.Add(toptancı);
            toptancı.Show();
            toptancı.Dock = DockStyle.Fill;
            toptancı.BringToFront();




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
