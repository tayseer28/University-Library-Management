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
    public partial class admin_login : Form
    {
        private SqlConnection conn;
        public admin_login()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=DESKTOP-PDSBB7V\MSSQLSERVER1;Initial Catalog=master;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = tbEmail.Text;
            String password = tbPassword.Text;
            try
            {
                string query = "SELECT * FROM ADMIN WHERE EMAIL = @Email AND PASSWORD = @Password";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Email", username);
                    command.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("user loged in successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Do something else, such as opening the main form or performing additional actions
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbEmail.Clear();
                        tbPassword.Clear();
                        tbEmail.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                Admin userLogin = new Admin();
                this.Hide();
                userLogin.ShowDialog();
                
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbEmail.Clear();
            tbPassword.Clear();
            tbEmail.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin_login_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminAccess access = new AdminAccess();
            this.Hide();
            access.ShowDialog();
            this.Close();

        }
    }
}