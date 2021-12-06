using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace prim_win_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            label1.Text = openFileDialog1.FileName;
            ShowImage();
        }

        private void btnLoadSpisok_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\elo\\Desktop\\МУСЯ\\Фото_животных");
            FileInfo[] files = dir.GetFiles("*.*");
            foreach (FileInfo fi in files)
            {
                lstPicturies.Items.Add(fi.ToString());
            }
            lstPicturies.SelectedIndex = 0;
        }

        private void lstPicturies_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = lstPicturies.Text;
            ShowImage();
        }

        private void ShowImage()
        {
            pictureBox1.Image = Image.FromFile(label1.Text);
        }
    }
}
