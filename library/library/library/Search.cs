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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;

            try
            {
                string connectionString = "Data Source=DESKTOP-PDSBB7V\\MSSQLSERVER1;Initial Catalog=master;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TITLE, ISBN, PUBLICATIONYEAR FROM BOOK WHERE TITLE LIKE @Title";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", "%" + title + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string bookTitle = reader["TITLE"].ToString();
                                string isbn = reader["ISBN"].ToString();
                                string publicationYear = reader["PUBLICATIONYEAR"].ToString();

                                // Display the book information
                                resultTextBox.AppendText($"Title: {bookTitle}{Environment.NewLine}");
                                resultTextBox.AppendText($"ISBN: {isbn}{Environment.NewLine}");
                                resultTextBox.AppendText($"Publication Year: {publicationYear}{Environment.NewLine}");
                                resultTextBox.AppendText(Environment.NewLine);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            this.Hide();
            student.ShowDialog ();
            this.Close();
        }
    }
}
