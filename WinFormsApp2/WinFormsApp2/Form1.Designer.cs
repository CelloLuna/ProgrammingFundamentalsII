namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_myBtn = new System.Windows.Forms.Button();
            this.userLbl = new System.Windows.Forms.Label();
            this.passBtn = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_myBtn
            // 
            this.btn_myBtn.ForeColor = System.Drawing.Color.Red;
            this.btn_myBtn.Location = new System.Drawing.Point(337, 284);
            this.btn_myBtn.Name = "btn_myBtn";
            this.btn_myBtn.Size = new System.Drawing.Size(94, 29);
            this.btn_myBtn.TabIndex = 0;
            this.btn_myBtn.Text = "Exit";
            this.btn_myBtn.UseVisualStyleBackColor = true;
            this.btn_myBtn.Click += new System.EventHandler(this.btn_myBtn_Click);
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(218, 114);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(75, 20);
            this.userLbl.TabIndex = 1;
            this.userLbl.Text = "Username";
            // 
            // passBtn
            // 
            this.passBtn.AutoSize = true;
            this.passBtn.Location = new System.Drawing.Point(218, 193);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(70, 20);
            this.passBtn.TabIndex = 2;
            this.passBtn.Text = "Password";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(318, 114);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(125, 27);
            this.userInput.TabIndex = 3;
            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(318, 193);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(125, 27);
            this.passInput.TabIndex = 4;
            this.passInput.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.passBtn);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.btn_myBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_myBtn;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label passBtn;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
