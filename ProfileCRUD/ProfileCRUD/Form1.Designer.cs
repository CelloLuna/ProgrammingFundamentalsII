namespace ProfileCRUD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_reg = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_displayAll = new System.Windows.Forms.Button();
            this.dataGrid_DispRec = new System.Windows.Forms.DataGridView();
            this.regIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authenticateDataSet = new ProfileCRUD.AuthenticateDataSet();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profDetailsTableAdapter = new ProfileCRUD.AuthenticateDataSetTableAdapters.ProfDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(683, 269);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_reg
            // 
            this.txt_reg.Location = new System.Drawing.Point(352, 70);
            this.txt_reg.Name = "txt_reg";
            this.txt_reg.Size = new System.Drawing.Size(300, 22);
            this.txt_reg.TabIndex = 11;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(352, 98);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(300, 22);
            this.txt_firstName.TabIndex = 12;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(352, 129);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(300, 22);
            this.txt_lastName.TabIndex = 13;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(305, 269);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(372, 22);
            this.txt_search.TabIndex = 14;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(276, 234);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 15;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(471, 234);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(577, 234);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(377, 234);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_displayAll
            // 
            this.btn_displayAll.Location = new System.Drawing.Point(408, 526);
            this.btn_displayAll.Name = "btn_displayAll";
            this.btn_displayAll.Size = new System.Drawing.Size(181, 23);
            this.btn_displayAll.TabIndex = 19;
            this.btn_displayAll.Text = "Display all records";
            this.btn_displayAll.UseVisualStyleBackColor = true;
            this.btn_displayAll.Click += new System.EventHandler(this.btn_displayAll_Click);
            // 
            // dataGrid_DispRec
            // 
            this.dataGrid_DispRec.AutoGenerateColumns = false;
            this.dataGrid_DispRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DispRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGrid_DispRec.DataSource = this.profDetailsBindingSource;
            this.dataGrid_DispRec.Location = new System.Drawing.Point(244, 297);
            this.dataGrid_DispRec.Name = "dataGrid_DispRec";
            this.dataGrid_DispRec.RowHeadersWidth = 51;
            this.dataGrid_DispRec.RowTemplate.Height = 24;
            this.dataGrid_DispRec.Size = new System.Drawing.Size(513, 223);
            this.dataGrid_DispRec.TabIndex = 20;
            this.dataGrid_DispRec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DispRec_CellContentClick);
            // 
            // regIDDataGridViewTextBoxColumn
            // 
            this.regIDDataGridViewTextBoxColumn.DataPropertyName = "RegID";
            this.regIDDataGridViewTextBoxColumn.HeaderText = "RegID";
            this.regIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regIDDataGridViewTextBoxColumn.Name = "regIDDataGridViewTextBoxColumn";
            this.regIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // profDetailsBindingSource
            // 
            this.profDetailsBindingSource.DataMember = "ProfDetails";
            this.profDetailsBindingSource.DataSource = this.authenticateDataSet;
            // 
            // authenticateDataSet
            // 
            this.authenticateDataSet.DataSetName = "AuthenticateDataSet";
            this.authenticateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(352, 166);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(300, 22);
            this.txt_address.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Reg ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // profDetailsTableAdapter
            // 
            this.profDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 587);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.dataGrid_DispRec);
            this.Controls.Add(this.btn_displayAll);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.txt_reg);
            this.Controls.Add(this.btn_search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DispRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_reg;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_displayAll;
        private System.Windows.Forms.DataGridView dataGrid_DispRec;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AuthenticateDataSet authenticateDataSet;
        private System.Windows.Forms.BindingSource profDetailsBindingSource;
        private AuthenticateDataSetTableAdapters.ProfDetailsTableAdapter profDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn regIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}

