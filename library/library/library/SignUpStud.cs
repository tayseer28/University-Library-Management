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
    public partial class SignUpStud : Form
    {
        public SignUpStud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addStudent())
            {
                DataBase.execute("INSERT INTO STUDENT (STUDENTID, FNAME, LNAME, EMAIL, PASSWORD, STUDYYEAR, DEPARTMENT, REGISTERdATE )" +
                           $"VALUES ({textBox5.Text}, '{textBox2.Text}', '{textBox3.Text}', '{textBox1.Text}', '{textBox4.Text}', {textBox6.Text}, '{textBox7.Text}', '{DateTime.Today}')");
                MessageBox.Show("Successful sign up");

                Student stud =new Student();
                this.Hide();
                stud.ShowDialog();
                this.Close();

            }
        }
        public bool addStudent()
        {


            if (!Validation.studIdValidation(textBox5.Text))
            {
                MessageBox.Show("ID should be 8 digits");
                return false;

            }

            if (!Validation.studEmailValidation(textBox1.Text))
            {
                MessageBox.Show("incorrect email pattern");
                return false;

            }
            if (!Validation.passWordValidation(textBox4.Text))
            {
                MessageBox.Show("password consists of characters or digits, and should be at least 8");
                return false;

            }
            if (!Validation.studyYearValidation(textBox6.Text))
            {
                MessageBox.Show("invalid study year");
                return false;
            }
            if (!Validation.departmentValidation(textBox7.Text))
            {
                MessageBox.Show("invalid department");
                return false;

            }



            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentAccess studentAccess = new StudentAccess();
            this.Hide();
            studentAccess.ShowDialog();
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;//id

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;//email

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;// password

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;//first name

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = true;//study year

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = true;//department

        }
    }
}
