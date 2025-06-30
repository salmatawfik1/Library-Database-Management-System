using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace forms
{
    public partial class UserBorrowedBooks : Form      ///////    joining between 3 tables
    {
        public UserBorrowedBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server=DESKTOP-547P407;Database=master;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Open connection
                conn.Open();

                MessageBox.Show("Connection Successful...");

                string sqlQuerySelect = @"
                    SELECT FNAME, LNAME, BORROWDATE, RETURNDATE, TITLE
                    FROM BORROW
                    JOIN THEUSER ON BORROW.USERID = THEUSER.USERID
                    JOIN BOOK ON BORROW.ISBN = BOOK.ISBN
                    WHERE THEUSER.USERID = @USERID";

                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                command.Parameters.AddWithValue("@USERID", textBox1.Text);

                MessageBox.Show("Executing Query...");
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
                MessageBox.Show("Selected Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
