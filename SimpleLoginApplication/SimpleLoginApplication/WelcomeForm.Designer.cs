namespace SimpleLoginApplication
{
    partial class WelcomeForm
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
            this.loginDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authenticateDataSet = new SimpleLoginApplication.AuthenticateDataSet();
            this.loginDetailsTableAdapter = new SimpleLoginApplication.AuthenticateDataSetTableAdapters.LoginDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.loginDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.Location = new System.Drawing.Point(279, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!!";
            // 
            // loginDetailsBindingSource
            // 
            this.loginDetailsBindingSource.DataMember = "LoginDetails";
            this.loginDetailsBindingSource.DataSource = this.authenticateDataSet;
            // 
            // authenticateDataSet
            // 
            this.authenticateDataSet.DataSetName = "AuthenticateDataSet";
            this.authenticateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginDetailsTableAdapter
            // 
            this.loginDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AuthenticateDataSet authenticateDataSet;
        private System.Windows.Forms.BindingSource loginDetailsBindingSource;
        private AuthenticateDataSetTableAdapters.LoginDetailsTableAdapter loginDetailsTableAdapter;
    }
}