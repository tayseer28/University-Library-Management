using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace library
{
    public partial class SignUpAdmin : Form
    {
        public SignUpAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addAdmin())
            {
                DataBase.execute("INSERT INTO ADMIN (ADMINID, FNAME, LNAME, EMAIL, PASSWORD)" +
                            $"VALUES ({textBox5.Text}, '{textBox2.Text}', '{textBox3.Text}', '{textBox1.Text}', '{textBox4.Text}')");
                MessageBox.Show("successful sign up");

                Admin admin = new Admin();
                this.Hide();
                admin.ShowDialog();
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminAccess access = new AdminAccess();
            this.Hide();
            access.ShowDialog();
            this.Close();
        }

        public bool addAdmin()
        {


            /*if (!Validation.studIdValidation(textBox5.Text))
            {
                MessageBox.Show("ID should be 8 digits");
                return false;

            }*/

            if (!Validation.adminEmailValidation(textBox1.Text))
            {
                MessageBox.Show("incorrect email pattern");
                return false;

            }
            if (!Validation.passWordValidation(textBox4.Text))
            {
                MessageBox.Show("password consists of characters or digits, and should be at least 8");
                return false;

            }

            return true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;//email

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;

        }

        private void SignUpAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
