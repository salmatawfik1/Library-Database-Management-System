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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace forms
{
    public partial class UserDelete : Form
    {
        public UserDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server= DESKTOP-547P407; Database= master; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //open connection
                conn.Open();

                MessageBox.Show("Connection Successful...");

                string sqlQuery = "DELETE FROM master.dbo.THEUSER WHERE USERID = @USERID";

                SqlCommand command = new SqlCommand(sqlQuery, conn);

                command.Parameters.AddWithValue("@USERID", textBox1.Text);

                MessageBox.Show("Executing Query...");
                command.ExecuteNonQuery(); //execute the Query

                conn.Close();
                MessageBox.Show("Deleted Successfully!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

