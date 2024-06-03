using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class BookByPublisher : Form
    {
        public BookByPublisher()
        {
            InitializeComponent();
        }

        private void BookByPublisher_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PDSBB7V\\MSSQLSERVER1;Initial Catalog=master; Integrated Security=True");
            SqlDataAdapter adapt;
            DataTable dt;
            conn.Open();
            adapt = new SqlDataAdapter("select BOOK.ISBN,BOOK.TITLE,PUBLISHER.NAME from BOOK inner join PUBLISHER on BOOK.PUBLISHERID = PUBLISHER.PUBLISHERID", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            this.Hide();
            student.ShowDialog();   
            this.Close();
        }
    }
}
