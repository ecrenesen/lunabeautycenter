using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaGüzellikSalonu
{
    public partial class FrmCalisan : Form
    {
        public FrmCalisan()
        {
            InitializeComponent();
        }

        private void FrmCalisan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            panel5.Controls.Clear();
            CalisanMeltem meltem = new CalisanMeltem();
            meltem.TopLevel = false;
            panel5.Controls.Add(meltem);
            meltem.Show();
            meltem.Dock = DockStyle.Fill;
           meltem.BringToFront();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);   
        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            CalisanBerkan berkan = new CalisanBerkan();
            berkan.TopLevel = false;
            panel5.Controls.Add(berkan);
            berkan.Show();
            berkan.Dock = DockStyle.Fill;
            berkan.BringToFront();

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            button2_Click(sender, e);

        }
    }
}
