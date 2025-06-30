namespace forms
{
    partial class BorrowUpdate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Button7 = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.TextBox10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // Label1
            //
            this.Label1.AutoSize =  true;
            this.Label1.Text =  "User ID";
            this.Label1.Location = new System.Drawing.Point(92,84);
            this.Label1.Size = new System.Drawing.Size(91,32);
            this.Label1.TabIndex = 1;
            //
            // Label2
            //
            this.Label2.AutoSize =  true;
            this.Label2.Text =  "ISBN";
            this.Label2.Location = new System.Drawing.Point(92,160);
            this.Label2.Size = new System.Drawing.Size(65,32);
            this.Label2.TabIndex = 2;
            //
            // TextBox3
            //
            this.TextBox3.Location = new System.Drawing.Point(304,84);
            this.TextBox3.Size = new System.Drawing.Size(176,39);
            this.TextBox3.TabIndex = 3;
            //
            // TextBox4
            //
            this.TextBox4.Location = new System.Drawing.Point(308,152);
            this.TextBox4.Size = new System.Drawing.Size(176,39);
            this.TextBox4.TabIndex = 4;
            //
            // Button7
            //
            this.Button7.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.Button7.Text =  "Update";
            this.Button7.Location = new System.Drawing.Point(268,328);
            this.Button7.Size = new System.Drawing.Size(143,52);
            this.Button7.TabIndex = 7;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            //
            // Label9
            //
            this.Label9.AutoSize =  true;
            this.Label9.Text =  "New Return Date";
            this.Label9.Location = new System.Drawing.Point(84,228);
            this.Label9.Size = new System.Drawing.Size(196,32);
            this.Label9.TabIndex = 9;
            //
            // TextBox10
            //
            this.TextBox10.Location = new System.Drawing.Point(308,220);
            this.TextBox10.Size = new System.Drawing.Size(172,39);
            this.TextBox10.TabIndex = 10;
         //
         // form
         //
            this.Size = new System.Drawing.Size(760,528);
            this.Text =  "Borrow Return Date Update";
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.TextBox10);
            this.ResumeLayout(false);
        } 

        #endregion 

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.TextBox TextBox10;
    }
}

