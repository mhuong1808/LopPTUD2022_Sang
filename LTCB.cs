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
    public partial class LTCB : Form
    {
        int i, n, T;
        public LTCB()
        {
            InitializeComponent();
        }

        private void LTCB_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(textN.Text);
            T = 0;
            i = 0;
            while (i <= n)
            {
                if (i % 2==0)
                {
                    T = T + i;
                }
                i++;
            }
            lblKQ.Text = "Ket qua tinh theo While la:" + Convert.ToString(T);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(textN.Text);
            T = 0;
            i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    T = T + i;
                }
                i++;
            }
            while (i <= n);
            lblKQ.Text = "Ket qua tinh theo Do While la:" + Convert.ToString(T);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(textN.Text);
            T = 0;
            for (i=1;i<=n;i++)
            {
                if (i % 2==0)
                {
                    T = T + i;
                }
            }
            lblKQ.Text = "Ket qua tinh theo For la:" + Convert.ToString(T);
        }
    }
}
