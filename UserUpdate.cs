using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace forms
{
    public partial class UserUpdate : Form
    {
        public UserUpdate()
        {
            InitializeComponent();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string connString = "Server=DESKTOP-547P407; Database=master; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Open connection
                conn.Open();
                MessageBox.Show("Connection Successful...");

                string sqlQueryUpdate = "UPDATE THEUSER SET BuildingNum = @BuildingNum, Street = @Street WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(sqlQueryUpdate, conn);

                command.Parameters.AddWithValue("@UserID", textBoxUserID.Text);
                command.Parameters.AddWithValue("@BuildingNum", textBoxBuildingNum.Text);
                command.Parameters.AddWithValue("@Street", textBoxStreet.Text);

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
