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
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }
        public bool isValidStudID()
        {
            int x;
            if (int.TryParse(textBox1.Text, out x))
            {
                DataTable dt = DataBase.Get($"SELECT * FROM STUDENT WHERE STUDENTID = {textBox1.Text}");
                if (dt.Rows.Count > 0)
                {
                    return true;
                }

            }

            return false;
        }
        public bool isValidBookID()
        {
            int x;
            if (int.TryParse(textBox2.Text, out x))
            {
                DataTable dt = DataBase.Get($"SELECT COUNT(*) FROM BOOK WHERE BOOKID = {textBox2.Text}");
                if (dt.Rows.Count > 0)
                {
                    return true;
                }

            }

            return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValidBookID() && isValidStudID())
            {
                DataTable dt = DataBase.Get($"SELECT NUMOFCOPIES, COPYNUM FROM COPY WHERE BOOKID = {textBox2.Text}");

                if (dt.Rows.Count > 0)
                {
                    int numOfCopies = Convert.ToInt32(dt.Rows[0][0].ToString());
                    int copyNum = Convert.ToInt32(dt.Rows[0][1].ToString());
                    if (numOfCopies > 0)
                    {

                        numOfCopies--;

                        DataBase.execute($"UPDATE COPY SET NUMOFCOPIES = {numOfCopies} WHERE BOOKID = {textBox2.Text}");
                        DataBase.execute("INSERT INTO STUDENT_COPY (BOOKID, COPYNUM, STUDENTID, BORROWDATE, RETURNDATE)" +
                            $" VALUES ({textBox2.Text}, {copyNum}, {textBox1.Text}, '{DateTime.Now}', '{DateTime.Now.AddDays(14)}')");
                        MessageBox.Show("successful process");
                    }
                    else
                    {
                        MessageBox.Show("no available copies");

                    }


                }
                else
                {
                    MessageBox.Show("invalid book ID");
                }

            }
            else
            {
                MessageBox.Show("invalid input");
            }
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.Get("SELECT B.BOOKID,B.TITLE, C.CATEGORYNAME, B.PUBLICATIONYEAR, A.NAME, CP.NUMOFCOPIES " +
              "FROM BOOK B  INNER JOIN CATEGORY C ON B.CATEGORYID = C.CATEGORYID " +
               "INNER JOIN BOOK_AUTHOR BA ON B.BOOKID = BA.BOOKID " +
              "INNER JOIN AUTHOR A ON BA.AUTHORID = A.AUTHORID " +
               "INNER JOIN COPY CP ON B.BOOKID = CP.BOOKID ");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            this.Hide();
            student.ShowDialog();
            this.Close();
        }
    }
}
