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
    public partial class BookSearch : Form
    {
        public BookSearch()
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

                string sqlQuerySelect = "SELECT * FROM master.dbo.BOOK WHERE ISBN = @ISBN";

                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                command.Parameters.AddWithValue("@ISBN", textBox1.Text);

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
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
