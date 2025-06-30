using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace forms
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string connString = "Server=DESKTOP-547P407; Database=master; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Open connection
                conn.Open();
                MessageBox.Show("Connection Successful...");

                string sqlQueryInsert = "INSERT INTO master.dbo.BORROW (USERID, ISBN, BORROWDATE, RETURNDATE) VALUES (@USERID, @ISBN, @BORROWDATE, @RETURNDATE)";
                SqlCommand command = new SqlCommand(sqlQueryInsert, conn);

                command.Parameters.AddWithValue("@USERID", TextBox3.Text);
                command.Parameters.AddWithValue("@ISBN", TextBox4.Text);
                command.Parameters.AddWithValue("@BORROWDATE", TextBox10.Text);
                command.Parameters.AddWithValue("@RETURNDATE", TextBox12.Text);
                

                MessageBox.Show("Executing Query...");
                command.ExecuteNonQuery(); // Execute the query

                conn.Close();
                MessageBox.Show("Inserted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            BorrowUpdate form5 = new BorrowUpdate();
            form5.Show();
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            
            BorrowSearch form7 = new BorrowSearch();
            form7.Show();
            this.Hide();
        }

        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {
            Report form7 = new Report();
            form7.Show();
            this.Hide();
        }
  
    }
}
