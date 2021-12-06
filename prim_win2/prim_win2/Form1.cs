using System;
using System.Drawing;
using System.Windows.Forms;

namespace prim_win2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        private Button[] but = new Button[17];
        private int size = 1;
        public void InitB()
        {
            panel1.Visible = false;
            size = (int)UpDownRazmer.Value;
            int x = panel1.Left + 2;
            int y = panel1.Top + 2;
            int num = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    but[num] = new Button();
                    but[num].Parent = panel1;
                    but[num].Left = x;
                    but[num].Top = y;
                    but[num].Text = num.ToString();
                    but[num].Width = size;
                    but[num].Height = size;
                    but[num].Visible = true;
                    but[num].Tag = num;
                    if (num == 16) 
                    { 
                        but[num].Text = " "; 
                        but[num].Tag = 0; 
                        but[num].BackColor = Color.Black; 
                    }
                    but[num].Click += ButtonOnClick;
                    x = x + size + 2;
                    num++;
                }
                y = y + size + 2;
                x = panel1.Left + 2;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InitB();
            Mix();
            panel1.Visible = true;
            btnStart.Enabled = false;
        }
        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var bt = (Button) sender;
            if (bt.Text != " ")
            {
                int t = Array.IndexOf(but, bt);
                int x = but[t].Left;
                int y = but[t].Top;
                int x16 = but[16].Left;
                int y16 = but[16].Top;
                if (((x16 == x + size + 2) && (y16 == y)) ||
                    ((x16 == x - size - 2) && (y16 == y)) ||
                    ((x16 == x) && (y16 == y + size + 2)) ||
                    ((x16 == x) && (y16 == y - size - 2)))
                {
                    SwapBut(t, 16);
                    CheckFinish();
                }
            }
        }
        private void SwapBut(int num1, int num2)
        {
            int x1 = but[num1].Left;
            int y1 = but[num1].Top;
            but[num1].Left = but[num2].Left;
            but[num1].Top = but[num2].Top;
            but[num2].Left = x1;
            but[num2].Top = y1;
        }
        private void Mix()
        {
            SwapBut(15, 16);
            SwapBut(14, 16);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = panel1.Left + 2;
            int y = panel1.Top + 2;
            int num = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    but[num].Left = x;
                    but[num].Top = y;
                    x = x + size + 2;
                    num++;
                }
                y = y + size + 2;
                x = panel1.Left + 2;
            }
            Mix();
        }
        private void CheckFinish()
        {
            int x = panel1.Left + 2;
            int y = panel1.Top + 2;
            int num = 1;
            bool flag = true;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((but[num].Left != x) || (but[num].Top != y))
                    {
                        flag = false;
                        break;
                    }
                    x = x + size + 2;
                    num++;
                }
                y = y + size + 2;
                x = panel1.Left + 2;
            }
            if (flag)
            {
                DialogResult result = MessageBox.Show("Сообщение", "Вы сделали это! Сыграть ещё?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    button1.PerformClick();
                }
                else
                    btnExit.PerformClick();
            }

        }
    }
}
