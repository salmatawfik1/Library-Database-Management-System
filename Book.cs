using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace forms
{
    public partial class BOOK : Form
    {
        public BOOK()
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

                string sqlQueryInsert = "INSERT INTO master.dbo.BOOK VALUES (@ISBN, @AuthorName, @Title, @Publisher)";
                SqlCommand command = new SqlCommand(sqlQueryInsert, conn);

                command.Parameters.AddWithValue("@ISBN", TextBox1.Text);
                command.Parameters.AddWithValue("@AuthorName", TextBox2.Text);
                command.Parameters.AddWithValue("@Title", TextBox3.Text);
                command.Parameters.AddWithValue("@Publisher", TextBox4.Text);

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

        private void Button0_Click(object sender, EventArgs e)
        {
            BookSearch form3 = new BookSearch();
            form3.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            BookDelete form7 = new BookDelete();
            form7.Show();
            this.Hide();
        } 
    }
    
}
