using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LopPTUD2022_Sang
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status1.Text = "Hello World";
            Form1 f = new Form1();
            f.ShowDialog();
            Status1.Text = "San sang nhan lenh";
        }

        private void tínhTổngHợpSốChẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LTCB f = new LTCB();
            f.Show();
        }

        private void máyTínhBấmTayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếtThúcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void đăngNhậpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Status2.Text = System.DateTime.Now.ToString();
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMHH f = new frmDMHH();
            f.Show();
        }
    }
}
