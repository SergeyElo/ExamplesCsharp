using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabUm
{
    
    public partial class Form1 : Form
    {
        int kol;
        int n;
        int FirstNum;
        int SecondNum;
        int Rez;
       
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            kol = 0;
            n = 0;
            btnBegin.Visible = false;
            panel1.Visible = true;
            Next();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {   string s;
            int otv;
            bool isNum = int.TryParse(txtOtvet.Text, out otv);
            if (isNum)
            {
                otv = Convert.ToInt32(txtOtvet.Text);

                if (otv == Rez)
                {
                    s = "Правильно.";
                    kol += 1;
                }
                else
                {
                    s = "Ошибка!";
                }
                lblProv.Text = s;
                Next();
            }
            else
            {
                lblProv.Text = "Ошибка ввода!";
                lblProv.Visible = true;
                txtOtvet.Select();
                txtOtvet.Text = "";
                timer1.Enabled = true;
            }
        }
        private void Next()
        {   int pr;
            double proc;
            FirstNum = rnd.Next(2, 9);
            SecondNum = rnd.Next(2, 9);
            lblPrim.Text = Convert.ToString(FirstNum) + "*" + Convert.ToString(SecondNum); 
            Rez = FirstNum * SecondNum;
            n++;
            lblNum.Text = "Пример № " + n.ToString();
            txtOtvet.Select();
            txtOtvet.Text = "";
            lblProv.Visible = true;
            timer1.Enabled = true;
            proc = (double) (kol + 1) / (double) n * 100.00;
            pr = (int) proc;
            lblPrav.Text = "Кол-во баллов: " + kol.ToString();
            lblProc.Text = "Процент: " + pr.ToString();
        }

        private void txtOtvet_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyValue == 13)
            {
                btnNext_Click(sender,null);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblProv.Visible = false;
            timer1.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
