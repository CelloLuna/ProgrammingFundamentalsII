using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace EmployeeProfile
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProfileDB;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        string imgLoc = "";
        string existingImgLoc = "";
        SqlCommand cmd;

        public void FormLoadWidgets()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            pictureBox1.Image = null;

            txt_id.Enabled = true;
            txt_name.Enabled = false;

            btnShow.Show();
            btnAddNew.Show();
            btnDelete.Show();

            btnShow.Enabled = true;
            btnAddNew.Enabled = true;

            btnImgUpload.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Hide();
            btnCancel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLoadWidgets();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Enter valid ID");
                FormLoadWidgets();
                return;
            }
            else
            {
                btnSave.Enabled = false;

                string showQuery = "SELECT * FROM ProfileDB WHERE id=" + txt_id.Text;
                conn.Open();
                cmd = new SqlCommand(showQuery, conn);

                try
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();

                        if (reader.HasRows)
                        {
                            //populate the name field
                            txt_name.Text = reader[1].ToString();

                            //load the image
                            byte[] img = (byte[])reader[2];

                            if (img == null)
                            {
                                pictureBox1.Image = null;
                            }

                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                pictureBox1.Image = Image.FromStream(ms);
                            }

                            existingImgLoc = reader[3].ToString();

                            btnDelete.Show();
                        }
                        else
                        {
                            MessageBox.Show("This ID does not exist");
                            conn.Close();
                            FormLoadWidgets();
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }

            conn.Close();

            txt_name.Enabled = false;
            btnImgUpload.Enabled = false;
            btnDelete.Enabled = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnShow.Enabled = false;
            btnShow.Hide(); btnAddNew.Hide(); btnDelete.Hide();

            btnSave.Show();
            btnSave.Enabled = true;

            btnCancel.Show();
            btnCancel.Enabled = true;

            btnAddNew.Enabled = false;
            btnDelete.Enabled = false;

            btnImgUpload.Enabled = true;

            txt_name.Enabled = true;
            txt_id.Text = "";
            txt_name.Text = "";

            pictureBox1.Image = null;
        }

        private void btnImgUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelect = new OpenFileDialog();

            fileSelect.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            fileSelect.Title = "Select Picture";

            if (fileSelect.ShowDialog() == DialogResult.OK)
            {
                imgLoc = fileSelect.FileName.ToString();
                pictureBox1.ImageLocation = imgLoc;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] myImage = null;
            conn.Open();
            
            try
            {
                if (txt_id.Text == "" || txt_name.Text == "")
                {
                    MessageBox.Show("Please enter valid ID and Name");
                    conn.Close();
                    return;
                }

                string showQuery = "SELECT Id FROM ProfileDB WHERE id=" + txt_id.Text;

                cmd = new SqlCommand(showQuery, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("ID already exists");
                        conn.Close();
                        return;
                    }  
                }

                if (imgLoc.Equals(""))
                {
                    MessageBox.Show("Please select an image to add");
                    conn.Close();
                    return;
                }
                else
                {
                    FileStream fStream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fStream);
                    myImage = br.ReadBytes((int)fStream.Length);

                    string imgInsertQuery = "Insert into ProfileDB(Id,Name,Image,ImageLoc)Values('" + txt_id.Text + "','" + txt_name.Text + "',@myImage, '" + imgLoc + "')";

                    cmd = new SqlCommand(imgInsertQuery, conn);
                    cmd.Parameters.Add(new SqlParameter("@myImage", myImage));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data saved successfully");
                    conn.Close();
                    FormLoadWidgets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_name.Text = "";
            FormLoadWidgets();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string DeleteQuery = "delete from [ProfileDB] where Id='" + txt_id.Text + "'";
            cmd = new SqlCommand(DeleteQuery, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ID delted successfully");

            FormLoadWidgets();
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close if any connetion is open
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
