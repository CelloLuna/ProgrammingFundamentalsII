namespace SimpleLoginApplication
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.authenticateDataSet = new SimpleLoginApplication.AuthenticateDataSet();
            this.loginDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDetailsTableAdapter = new SimpleLoginApplication.AuthenticateDataSetTableAdapters.LoginDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(379, 105);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(186, 22);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(379, 180);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(186, 22);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(359, 295);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(81, 38);
            this.BLogin.TabIndex = 4;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // BExit
            // 
            this.BExit.AutoEllipsis = true;
            this.BExit.ForeColor = System.Drawing.Color.Red;
            this.BExit.Location = new System.Drawing.Point(461, 295);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(85, 38);
            this.BExit.TabIndex = 5;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // authenticateDataSet
            // 
            this.authenticateDataSet.DataSetName = "AuthenticateDataSet";
            this.authenticateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginDetailsBindingSource
            // 
            this.loginDetailsBindingSource.DataMember = "LoginDetails";
            this.loginDetailsBindingSource.DataSource = this.authenticateDataSet;
            // 
            // loginDetailsTableAdapter
            // 
            this.loginDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.Button BExit;
        private AuthenticateDataSet authenticateDataSet;
        private System.Windows.Forms.BindingSource loginDetailsBindingSource;
        private AuthenticateDataSetTableAdapters.LoginDetailsTableAdapter loginDetailsTableAdapter;
    }
}

