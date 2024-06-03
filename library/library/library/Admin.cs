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
    public partial class Admin : Form
    {
        int lastBookId;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PDSBB7V\\MSSQLSERVER1;Initial Catalog=master; Integrated Security=True");

            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "SELECT MAX(bookid) FROM BOOK";
            lastBookId = (int)cmd.ExecuteScalar();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("enter full data");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PDSBB7V\\MSSQLSERVER1;Initial Catalog=master; Integrated Security=True");
                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                conn.Open();

                // Check if book already exists
                cmd.CommandText = "SELECT COUNT(*) FROM BOOK WHERE ISBN = @isbn OR Title = @title";
                cmd.Parameters.AddWithValue("@isbn", textBox5.Text);
                cmd.Parameters.AddWithValue("@title", textBox4.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Book already exists");
                }
                else
                {
                    lastBookId++;
                    cmd.CommandText = "INSERT INTO BOOK VALUES('" + lastBookId + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text.ToString() + "','" + textBox6.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book inserted successfully");
                }

                conn.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("enter full data");
            }

            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PDSBB7V\\MSSQLSERVER1;Initial Catalog=master; Integrated Security=True");
                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                conn.Open();

                // Check if book exists
                cmd.CommandText = "SELECT COUNT(*) FROM BOOK WHERE ISBN = @isbn";
                cmd.Parameters.AddWithValue("@isbn", textBox5.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    cmd.CommandText = "UPDATE BOOK SET PUBLISHERID =" + textBox2.Text + ", CATEGORYID =" + textBox1.Text + ", ADMINID= " + textBox3.Text + ", TITLE='" + textBox4.Text + "', PUBLICATIONYEAR=" + textBox6.Text + " WHERE ISBN= @isbn1";
                    cmd.Parameters.AddWithValue("@isbn1", textBox5.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book Updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Book does not exist");
                    }
                }
                else
                {
                    MessageBox.Show("Book does not exist");
                }

                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == " ")
            {
                MessageBox.Show("enter full data");
            }

            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PDSBB7V\\MSSQLSERVER1;Initial Catalog=master; Integrated Security=True");
                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                conn.Open();

                // Check if book exists
                cmd.CommandText = "SELECT COUNT(*) FROM BOOK WHERE ISBN = @isbn";
                cmd.Parameters.AddWithValue("@isbn", textBox5.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {

                    cmd.CommandText = "DELETE FROM BOOK where ISBN = @isbn1";
                    cmd.Parameters.AddWithValue("@isbn1", textBox5.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Was Succsesfully Completed");
                }
                else
                {
                    MessageBox.Show("Book does not exist");
                }

                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter.Fill(this.masterDataSet.BOOK);

        }

  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            statistics stat = new statistics();
            this.Hide();
            stat.ShowDialog();
            this.Close();
        }
    }
}
