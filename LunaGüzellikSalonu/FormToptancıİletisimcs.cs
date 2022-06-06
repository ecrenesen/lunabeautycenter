using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LunaGüzellikSalonu
{
    public partial class FormToptancıİletisimcs : Form
    {
        public FormToptancıİletisimcs()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
        FormToptancıİletisimcs toptancı=new FormToptancıİletisimcs();
            this.Hide();
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.toptanservis.com.tr/kategori/pamuk-urunleri");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.kozmela.com/c-vitamini");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.kozmela.com/c-vitamini");


        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.kozmela.com/c-vitamini");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.kozmela.com/c-vitamini");
        }

        private void FormToptancıİletisimcs_Load(object sender, EventArgs e)
        {

        }
    }
}
