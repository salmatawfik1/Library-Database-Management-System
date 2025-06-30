namespace forms
{
    partial class BOOK
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Button0 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // Button0
            //
            this.Button0.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.Button0.Text = "Go to search form";
            this.Button0.Location = new System.Drawing.Point(72, 504);
            this.Button0.Size = new System.Drawing.Size(216, 71);
            this.Button0.Click += new System.EventHandler(this.Button0_Click);   
            //
            // TextBox1
            //
            this.TextBox1.Modified = true;
            this.TextBox1.Location = new System.Drawing.Point(332, 100);
            this.TextBox1.Size = new System.Drawing.Size(340, 39);
            this.TextBox1.TabIndex = 1;
            //
            // TextBox2
            //
            this.TextBox2.Modified = true;
            this.TextBox2.Location = new System.Drawing.Point(328, 168);
            this.TextBox2.Size = new System.Drawing.Size(344, 39);
            this.TextBox2.TabIndex = 2;
            //
            // TextBox3
            //
            this.TextBox3.Modified = true;
            this.TextBox3.Location = new System.Drawing.Point(328, 240);
            this.TextBox3.Size = new System.Drawing.Size(336, 39);
            this.TextBox3.TabIndex = 3;
            //
            // TextBox4
            //
            this.TextBox4.Modified = true;
            this.TextBox4.Location = new System.Drawing.Point(328, 312);
            this.TextBox4.Size = new System.Drawing.Size(340, 39);
            this.TextBox4.TabIndex = 4;
            //
            // Button5
            //
            this.Button5.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.Button5.Text = "Go to delete form";
            this.Button5.Location = new System.Drawing.Point(468, 500);
            this.Button5.Size = new System.Drawing.Size(215, 72);
            this.Button5.TabIndex = 5;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);   
            //
            // Button6
            //
            this.Button6.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.Button6.Text = "Insert";
            this.Button6.Location = new System.Drawing.Point(284, 408);
            this.Button6.Size = new System.Drawing.Size(188, 72);
            this.Button6.TabIndex = 6;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            //
            // Label9
            //
            this.Label9.AutoSize = true;
            this.Label9.Text = "ISBN";
            this.Label9.Location = new System.Drawing.Point(116, 104);
            this.Label9.Size = new System.Drawing.Size(65, 32);
            this.Label9.TabIndex = 9;
            //
            // Label10
            //
            this.Label10.AutoSize = true;
            this.Label10.Text = "Author Name";
            this.Label10.Location = new System.Drawing.Point(116, 176);
            this.Label10.Size = new System.Drawing.Size(158, 32);
            this.Label10.TabIndex = 10;
            //
            // Label11
            //
            this.Label11.AutoSize = true;
            this.Label11.Text = "Title";
            this.Label11.Location = new System.Drawing.Point(116, 244);
            this.Label11.Size = new System.Drawing.Size(60, 32);
            this.Label11.TabIndex = 11;
            //
            // Label12
            //
            this.Label12.AutoSize = true;
            this.Label12.Text = "Publisher";
            this.Label12.Location = new System.Drawing.Point(116, 312);
            this.Label12.Size = new System.Drawing.Size(112, 32);
            this.Label12.TabIndex = 12;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 708);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label12);
            this.Name = "Form1";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label12;
    }
}

