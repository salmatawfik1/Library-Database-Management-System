using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace forms
{
    public partial class BorrowUpdate : Form
    {
        public BorrowUpdate()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string connString = "Server=DESKTOP-547P407; Database=master; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Open connection
                conn.Open();
                MessageBox.Show("Connection Successful...");

                string sqlQueryUpdate = "UPDATE BORROW SET RETURNDATE = @RETURNDATE  WHERE ISBN = @ISBN AND USERID = @USERID";
                SqlCommand command = new SqlCommand(sqlQueryUpdate, conn);

                command.Parameters.AddWithValue("@USERID", TextBox3.Text);
                command.Parameters.AddWithValue("@ISBN", TextBox4.Text);
                command.Parameters.AddWithValue("@RETURNDATE", TextBox10.Text);

                MessageBox.Show("Executing Query...");
                command.ExecuteNonQuery(); // Execute the query

                conn.Close();
                MessageBox.Show("Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
