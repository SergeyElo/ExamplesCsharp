
namespace TabUm
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
            this.components = new System.ComponentModel.Container();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblPrim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProc = new System.Windows.Forms.Label();
            this.lblPrav = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtOtvet = new System.Windows.Forms.TextBox();
            this.lblOtvet = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(147, 222);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(94, 29);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "Начать";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lblPrim
            // 
            this.lblPrim.AutoSize = true;
            this.lblPrim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrim.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrim.Location = new System.Drawing.Point(181, 14);
            this.lblPrim.Name = "lblPrim";
            this.lblPrim.Size = new System.Drawing.Size(71, 54);
            this.lblPrim.TabIndex = 1;
            this.lblPrim.Text = "---";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProc);
            this.panel1.Controls.Add(this.lblPrav);
            this.panel1.Controls.Add(this.lblProv);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.txtOtvet);
            this.panel1.Controls.Add(this.lblOtvet);
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Controls.Add(this.lblPrim);
            this.panel1.Location = new System.Drawing.Point(40, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 193);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // lblProc
            // 
            this.lblProc.Location = new System.Drawing.Point(405, 62);
            this.lblProc.Name = "lblProc";
            this.lblProc.Size = new System.Drawing.Size(154, 25);
            this.lblProc.TabIndex = 8;
            this.lblProc.Text = "---";
            // 
            // lblPrav
            // 
            this.lblPrav.Location = new System.Drawing.Point(406, 14);
            this.lblPrav.Name = "lblPrav";
            this.lblPrav.Size = new System.Drawing.Size(167, 28);
            this.lblPrav.TabIndex = 7;
            this.lblPrav.Text = "---";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(137, 161);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(27, 20);
            this.lblProv.TabIndex = 6;
            this.lblProv.Text = "---";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(253, 114);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 29);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Проверить";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtOtvet
            // 
            this.txtOtvet.Location = new System.Drawing.Point(158, 115);
            this.txtOtvet.Name = "txtOtvet";
            this.txtOtvet.Size = new System.Drawing.Size(70, 27);
            this.txtOtvet.TabIndex = 4;
            this.txtOtvet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOtvet_KeyDown);
            // 
            // lblOtvet
            // 
            this.lblOtvet.AutoSize = true;
            this.lblOtvet.Location = new System.Drawing.Point(32, 118);
            this.lblOtvet.Name = "lblOtvet";
            this.lblOtvet.Size = new System.Drawing.Size(109, 20);
            this.lblOtvet.TabIndex = 3;
            this.lblOtvet.Text = "Введите ответ:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(54, 41);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(87, 20);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Пример №";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(380, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBegin);
            this.Name = "Form1";
            this.Text = "Проверка таблицы умножения";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label lblPrim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtOtvet;
        private System.Windows.Forms.Label lblOtvet;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblProv;
        public System.Windows.Forms.Label lblPrav;
        private System.Windows.Forms.Label lblProc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnExit;
    }
}

