using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace forms
{
    public partial class User : Form
    {
        public User()
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

                string sqlQueryInsert = "INSERT INTO master.dbo.THEUSER (USERID, UNIEMAIL, FNAME, LNAME, PHONE, CLASSIFICATION, BUILDINGNUM, STREET) VALUES (@USERID, @UNIEMAIL, @FNAME, @LNAME, @PHONE, @CLASSIFICATION, @BUILDINGNUM, @STREET)";
                SqlCommand command = new SqlCommand(sqlQueryInsert, conn);

                command.Parameters.AddWithValue("@USERID", TextBox13.Text);
                command.Parameters.AddWithValue("@UNIEMAIL", TextBox14.Text);
                command.Parameters.AddWithValue("@FNAME", TextBox15.Text);
                command.Parameters.AddWithValue("@LNAME", TextBox16.Text);
                command.Parameters.AddWithValue("@PHONE", TextBox17.Text);
                command.Parameters.AddWithValue("@CLASSIFICATION", TextBox18.Text);
                command.Parameters.AddWithValue("@BUILDINGNUM", TextBox19.Text);
                command.Parameters.AddWithValue("@STREET", TextBox20.Text);

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
            UserUpdate form5 = new UserUpdate();
            form5.Show();
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            
            UserSearch form7 = new UserSearch();
            form7.Show();
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            UserDelete form7 = new UserDelete();
            form7.Show();
            this.Hide();
        }
        private void ButtonShowBorrowedBooks_Click(object sender, EventArgs e)
        {
            UserBorrowedBooks form7 = new UserBorrowedBooks();
            form7.Show();
            this.Hide();
        }
    }
}
