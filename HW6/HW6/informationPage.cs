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

namespace HW6
{
    public partial class informationPage : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LoginDetails;Integrated Security=True;");
        public informationPage()
        {
            InitializeComponent();
        }
        public void formLoad()
        {
            searchInput.Text = "";
            searchInput.Enabled = true;

            logoutBtn.Hide();
            logoutBtn.Enabled = false;

            insertBtn.Show();
            updateBtn.Show();
            deleteBtn.Show();

            insertBtn.Enabled = false;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;

            displayBtn.Show();
            searchBtn.Show();

            displayBtn.Enabled = true;
            searchBtn.Enabled = true;

        }
        public void displaData()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [userInfo]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            conn.Close();
        }
        private void informationPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDetailsDataSet.userInfo' table. You can move, or remove it, as needed.
            this.userInfoTableAdapter.Fill(this.loginDetailsDataSet.userInfo);
            formLoad();
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm lo = new loginForm();
            lo.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            displaData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [userInfo] where ID='" + idTxt.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaData();

            idTxt.Text = "";
            nameTxt.Text = "";
            courseTxt.Text = "";
            departmentTxt.Text = "";
            regNumTxt.Text = "";

            insertBtn.Enabled = true;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;

            idTxt.Enabled = true;

            MessageBox.Show("Data Deleted Successfully");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [userInfo] set Name='" + nameTxt.Text + "', Course='" + courseTxt.Text + "', Department='" + departmentTxt.Text + "', registerNumber='" + regNumTxt.Text + "' where Id='" + idTxt + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaData();

            idTxt.Text = "";
            nameTxt.Text = "";
            courseTxt.Text = "";
            departmentTxt.Text = "";
            regNumTxt.Text = "";

            insertBtn.Enabled = true;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;

            idTxt.Enabled = true;

            MessageBox.Show("Data Updated Successfully");
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from [userInfo] where Id='" + idTxt.Text + "'", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                conn.Close();
                MessageBox.Show("Id already exists");
            }
            else
            {
                SqlCommand sqcmd = conn.CreateCommand();
                sqcmd.CommandType = CommandType.Text;
                sqcmd.CommandText = "insert into [userInfo] (Id, Name, Course, Department, registerNumber) values ('" + idTxt.Text + "','" + nameTxt.Text + "','" + courseTxt.Text + "','" + departmentTxt.Text + "','" + regNumTxt.Text + " ')";
                
                sqcmd.ExecuteNonQuery();
                conn.Close();

                idTxt.Text = "";
                nameTxt.Text = "";
                courseTxt.Text = "";
                departmentTxt.Text = "";
                regNumTxt.Text = "";

                MessageBox.Show("Data Inserted Successfully");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string search = searchInput.Text;
            SqlCommand cmd = new SqlCommand("Select * from [userInfo] where Name Like '%" + search + "%' OR Course Likeike '%" + search + "%' OR Department Like '%" + search + "%' OR registerNumber Like '%", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("No Record Found");
                conn.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            conn.Close();
            displaData();

            idTxt.Text = "";
            nameTxt.Text = "";
            courseTxt.Text = "";
            departmentTxt.Text = "";
            regNumTxt.Text = "";

            insertBtn.Enabled = true;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;

            idTxt.Enabled = true;
        }
    }
}
