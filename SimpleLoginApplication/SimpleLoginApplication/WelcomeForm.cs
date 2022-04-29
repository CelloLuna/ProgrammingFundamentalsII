using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLoginApplication
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        
        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'authenticateDataSet.LoginDetails' table. You can move, or remove it, as needed.
            this.loginDetailsTableAdapter.Fill(this.authenticateDataSet.LoginDetails);

        }
    }
}
