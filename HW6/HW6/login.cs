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
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }
        

        private void loginInput_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LoginDetails;Integrated Security=True;");

            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from login where Username='" + userInput.Text + "' and Password='" + passInput.Text + "'", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                informationPage info = new informationPage();
                info.Activate();
            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }

            conn.Close();
        }
    }
}
