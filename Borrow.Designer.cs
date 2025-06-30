namespace forms
{
    partial class Borrow
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
            this.Label11 = new System.Windows.Forms.Label();
            this.TextBox12 = new System.Windows.Forms.TextBox();
            this.Button13 = new System.Windows.Forms.Button();
            this.Button14 = new System.Windows.Forms.Button();
            this.Button15 = new System.Windows.Forms.Button();
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
            this.TextBox4.Location = new System.Drawing.Point(304,152);
            this.TextBox4.Size = new System.Drawing.Size(168,39);
            this.TextBox4.TabIndex = 4;
            //
            // Button7
            //
            this.Button7.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.Button7.Text =  "Insert";
            this.Button7.Location = new System.Drawing.Point(132,408);
            this.Button7.Size = new System.Drawing.Size(164,72);
            this.Button7.TabIndex = 7;
            Button7.Click += Button6_Click;
            //
            // Label9
            //
            this.Label9.AutoSize =  true;
            this.Label9.Text =  "Borrow Date";
            this.Label9.Location = new System.Drawing.Point(92,228);
            this.Label9.Size = new System.Drawing.Size(146,32);
            this.Label9.TabIndex = 9;
            //
            // TextBox10
            //
            this.TextBox10.Location = new System.Drawing.Point(304,224);
            this.TextBox10.Size = new System.Drawing.Size(172,39);
            this.TextBox10.TabIndex = 10;
            //
            // Label11
            //
            this.Label11.AutoSize =  true;
            this.Label11.Text =  "Return Date";
            this.Label11.Location = new System.Drawing.Point(96,300);
            this.Label11.Size = new System.Drawing.Size(141,32);
            this.Label11.TabIndex = 11;
            //
            // TextBox12
            //
            this.TextBox12.Location = new System.Drawing.Point(308,296);
            this.TextBox12.Size = new System.Drawing.Size(164,39);
            this.TextBox12.TabIndex = 12;
            //
            // Button13
            //
            this.Button13.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.Button13.Text =  "Generate Report";
            this.Button13.Location = new System.Drawing.Point(384,408);
            this.Button13.Size = new System.Drawing.Size(196,68);
            this.Button13.TabIndex = 13;
            Button13.Click += ButtonGenerateReport_Click;
            //
            // Button14
            //
            this.Button14.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.Button14.Text =  "Go to Search form";
            this.Button14.Location = new System.Drawing.Point(136,524);
            this.Button14.Size = new System.Drawing.Size(160,76);
            this.Button14.TabIndex = 14;
            Button14.Click += Button7_Click;
            //
            // Button15
            //
            this.Button15.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.Button15.Text =  "Go to Update form";
            this.Button15.Location = new System.Drawing.Point(388,524);
            this.Button15.Size = new System.Drawing.Size(188,72);
            this.Button15.TabIndex = 15;
            Button15.Click += Button12_Click;
         //
         // form
         //
            this.Size = new System.Drawing.Size(816,728);
            this.Text =  "Borrow";
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.TextBox10);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.TextBox12);
            this.Controls.Add(this.Button13);
            this.Controls.Add(this.Button14);
            this.Controls.Add(this.Button15);
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
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.TextBox TextBox12;
        private System.Windows.Forms.Button Button13;
        private System.Windows.Forms.Button Button14;
        private System.Windows.Forms.Button Button15;
    }
}

