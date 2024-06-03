using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Form1 userLogin = new Form1();
            this.Hide();
            userLogin.ShowDialog();
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            admin_login adminLogin = new admin_login();
            this.Hide();
            adminLogin.ShowDialog();
            
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home userLogin = new Home();
            this.Hide();
            userLogin.ShowDialog();
            this.Close();

        }
    }
}
