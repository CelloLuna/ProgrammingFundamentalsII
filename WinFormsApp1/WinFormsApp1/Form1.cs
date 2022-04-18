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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.btn_myBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.userLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_myBtn
            // 
            this.btn_myBtn.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_myBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_myBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_myBtn.Location = new System.Drawing.Point(273, 153);
            this.btn_myBtn.Name = "btn_myBtn";
            this.btn_myBtn.Size = new System.Drawing.Size(94, 29);
            this.btn_myBtn.TabIndex = 0;
            this.btn_myBtn.Text = "My Button";
            this.btn_myBtn.UseVisualStyleBackColor = true;
           // this.btn_myBtn.Click += new System.EventHandler(this.btn_myBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(258, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '8';
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 3;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.ForeColor = System.Drawing.Color.Black;
            this.userLbl.Location = new System.Drawing.Point(156, 57);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(75, 20);
            this.userLbl.TabIndex = 4;
            this.userLbl.Text = "Username";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.ForeColor = System.Drawing.Color.Black;
            this.passLbl.Location = new System.Drawing.Point(156, 102);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(70, 20);
            this.passLbl.TabIndex = 5;
            this.passLbl.Text = "Password";
            // 
            // Form1
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(619, 317);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_myBtn);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}
