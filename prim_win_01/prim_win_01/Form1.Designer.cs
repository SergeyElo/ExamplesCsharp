
namespace prim_win_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstPicturies = new System.Windows.Forms.ListBox();
            this.btnLoadSpisok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Location = new System.Drawing.Point(344, 3);
            this.btnOpenDialog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(112, 22);
            this.btnOpenDialog.TabIndex = 0;
            this.btnOpenDialog.Text = "Выбрать файл";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(499, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(186, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lstPicturies
            // 
            this.lstPicturies.FormattingEnabled = true;
            this.lstPicturies.ItemHeight = 15;
            this.lstPicturies.Location = new System.Drawing.Point(12, 32);
            this.lstPicturies.Name = "lstPicturies";
            this.lstPicturies.Size = new System.Drawing.Size(168, 364);
            this.lstPicturies.TabIndex = 5;
            this.lstPicturies.SelectedIndexChanged += new System.EventHandler(this.lstPicturies_SelectedIndexChanged);
            // 
            // btnLoadSpisok
            // 
            this.btnLoadSpisok.Location = new System.Drawing.Point(12, 4);
            this.btnLoadSpisok.Name = "btnLoadSpisok";
            this.btnLoadSpisok.Size = new System.Drawing.Size(168, 20);
            this.btnLoadSpisok.TabIndex = 6;
            this.btnLoadSpisok.Text = "Получить список";
            this.btnLoadSpisok.UseVisualStyleBackColor = true;
            this.btnLoadSpisok.Click += new System.EventHandler(this.btnLoadSpisok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnLoadSpisok);
            this.Controls.Add(this.lstPicturies);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenDialog);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstPicturies;
        private System.Windows.Forms.Button btnLoadSpisok;
    }
}

