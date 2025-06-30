namespace forms
{
    partial class Form1
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
            this.Label0 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // Label0
            //
            this.Label0.AutoSize =  true;
            this.Label0.Text =  "Choose a table to perform opeartions on:";
            this.Label0.Location = new System.Drawing.Point(216,152);
            this.Label0.Size = new System.Drawing.Size(455,32);
            //
            // Button1
            //
            this.Button1.Text =  "Book";
            this.Button1.Location = new System.Drawing.Point(148,264);
            this.Button1.Size = new System.Drawing.Size(155,112);
            this.Button1.TabIndex = 1;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            //
            // Button2
            //
            this.Button2.Text =  "Admin";
            this.Button2.Location = new System.Drawing.Point(148,424);
            this.Button2.Size = new System.Drawing.Size(156,108);
            this.Button2.TabIndex = 2;
            //
            // Button3
            //
            this.Button3.Text =  "Library";
            this.Button3.Location = new System.Drawing.Point(156,580);
            this.Button3.Size = new System.Drawing.Size(160,104);
            this.Button3.TabIndex = 3;
            //
            // Button4
            //
            this.Button4.Text =  "Library Branch";
            this.Button4.Location = new System.Drawing.Point(152,728);
            this.Button4.Size = new System.Drawing.Size(163,104);
            this.Button4.TabIndex = 4;
            //
            // Button5
            //
            this.Button5.Text =  "User";
            this.Button5.Location = new System.Drawing.Point(572,268);
            this.Button5.Size = new System.Drawing.Size(159,116);
            this.Button5.TabIndex = 5;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            //
            // Button6
            //
            this.Button6.Text =  "Book Copy";
            this.Button6.Location = new System.Drawing.Point(576,428);
            this.Button6.Size = new System.Drawing.Size(163,96);
            this.Button6.TabIndex = 6;
            //
            // Button7
            //
            this.Button7.Text =  "College Section";
            this.Button7.Location = new System.Drawing.Point(572,572);
            this.Button7.Size = new System.Drawing.Size(172,100);
            this.Button7.TabIndex = 7;
            //
            // Button8
            //
            this.Button8.Text =  "Borrow";
            this.Button8.Location = new System.Drawing.Point(580,720);
            this.Button8.Size = new System.Drawing.Size(168,100);
            this.Button8.TabIndex = 8;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            //
            // Label11
            //
         //   this.Button12.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.Label11.AutoSize =  true;
            this.Label11.Text =  "Welcome to Univeristy Library Management System";
            this.Label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label11.Location = new System.Drawing.Point(48,24);
            this.Label11.Size = new System.Drawing.Size(600,600);
            this.Label11.TabIndex = 11;
         //
         // form
         //
            this.Size = new System.Drawing.Size(984,1092);
            this.Text =  "Welcome";
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Label11);
            this.ResumeLayout(false);
        } 

        #endregion 

        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Label Label11;
    }
}
