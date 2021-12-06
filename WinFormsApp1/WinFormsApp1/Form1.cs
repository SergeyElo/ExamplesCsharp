using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int n = 10;
        long p = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txtNum.Text);
            if ((n < 1) | (n > 50))
            {
                lblError.Visible = true;
                timer1.Enabled = true;
            }
            else
            {
                p = 1;
                for (int i = 1; i <= n; i++) { p *= i; }
                txtRezult.Text = Convert.ToString(p);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txtNum.Text = "";
            txtRezult.Text = "";
            timer1.Enabled = false;
        }
    }
}
