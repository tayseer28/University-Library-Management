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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter.Fill(this.masterDataSet.BOOK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search userLogin = new Search();
            this.Hide();
            userLogin.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            this.Hide();
            viewBooks.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookByPublisher userLogin = new BookByPublisher();
            this.Hide();
            userLogin.ShowDialog();
        }
    }
}
