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
    public partial class AdminAccess : Form
    {
        public AdminAccess()
        {
            InitializeComponent();
        }

        private void AdminAccess_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpAdmin signUpAdmin = new SignUpAdmin();
            this.Hide();
            signUpAdmin.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            admin_login home = new admin_login();
            this.Hide();
            home.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
            this.Close();

        }
    }
}
