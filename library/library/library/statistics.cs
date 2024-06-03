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
    public partial class statistics : Form
    {
        // Connection string for your database
        private string connectionString = "Data Source=DESKTOP-PDSBB7V\\MSSQLSERVER1;Initial Catalog=master;Integrated Security=True";

        public statistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT C.CATEGORYNAME, COUNT(*) AS BOOKCOUNT " +
                                       "FROM CATEGORY C " +
                                       "JOIN BOOK B ON C.CATEGORYID = B.CATEGORYID " +
                                       "GROUP BY C.CATEGORYNAME";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query and retrieve the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear any existing text in textBox1
                            textBox1.Clear();

                            // Iterate over the results and append category name and book count to textBox1
                            while (reader.Read())
                            {
                                string categoryName = reader["CATEGORYNAME"].ToString();
                                int bookCount = Convert.ToInt32(reader["BOOKCOUNT"]);

                                textBox1.AppendText(categoryName + ": " + bookCount.ToString() + Environment.NewLine);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
    


        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT TOP 1 STUDENTID, FNAME, LNAME FROM STUDENT ORDER BY REGISTERDATE ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int studentId = reader.GetInt32(0);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);

                    textBox2.Text = $"Oldest student: ID={studentId}, Name={firstName} {lastName}";
                }
                else
                {
                    textBox2.Text = "No students found.";
                }

                reader.Close();
            }
        }


 

    private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a SqlConnection object to connect to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create a SqlCommand object to execute a query on the database
                    string query = "SELECT COUNT(*) FROM BOOK";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Execute the query and get the count of books
                    int count = (int)command.ExecuteScalar();

                    // Display the count of books in the textbox
                    textBox3.Text = $"The library has a total of {count} books.";


                    // Close the connection to the database
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.ShowDialog();
            this.Close(); 
        }
    }
}
