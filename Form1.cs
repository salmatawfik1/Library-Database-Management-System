using System;
using System.Windows.Forms;

namespace forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BOOK form2 = new BOOK();
            form2.Show();
            this.Hide();
        }

        /*
        private void Button2_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LibraryForm libraryForm = new LibraryForm();
            libraryForm.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            LibraryBranchForm libraryBranchForm = new LibraryBranchForm();
            libraryBranchForm.Show();
            this.Hide();
        }
*/
        private void Button5_Click(object sender, EventArgs e)
        {
            User userForm = new User();
            userForm.Show();
            this.Hide();
        }
/*
        private void Button6_Click(object sender, EventArgs e)
        {
            BookCopyForm bookCopyForm = new BookCopyForm();
            bookCopyForm.Show();
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            CollegeSectionForm collegeSectionForm = new CollegeSectionForm();
            collegeSectionForm.Show();
            this.Hide();
        }
*/
        private void Button8_Click(object sender, EventArgs e)
        {
            Borrow borrowForm = new Borrow();
            borrowForm.Show();
            this.Hide();
        }
        
    }
}
