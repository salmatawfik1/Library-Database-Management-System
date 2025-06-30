using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace forms
{
    public partial class Report : Form
    {
        string connectionString = "Server= DESKTOP-547P407; Database= master; Integrated Security=True;";

        public Report()
        {
            InitializeComponent();
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL query to count the number of users who borrowed on the same date
                    string query = "SELECT BORROWDATE, COUNT(DISTINCT USERID) AS UserCount " +
                     "FROM BORROW " + 
                     "GROUP BY BORROWDATE " +
                     "ORDER BY BORROWDATE";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DataTable dt = new DataTable();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }

                        dataGridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}