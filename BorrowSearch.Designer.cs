namespace forms
{
    partial class BorrowSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Text = "User ID";
            this.Label1.Location = new System.Drawing.Point(72, 72);
            this.Label1.Size = new System.Drawing.Size(91, 32);
            this.Label1.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Text = "ISBN";
            this.Label2.Location = new System.Drawing.Point(80, 144);
            this.Label2.Size = new System.Drawing.Size(65, 32);
            this.Label2.TabIndex = 2;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(220, 72);
            this.TextBox3.Size = new System.Drawing.Size(176, 39);
            this.TextBox3.TabIndex = 3;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(220, 140);
            this.TextBox4.Size = new System.Drawing.Size(176, 39);
            this.TextBox4.TabIndex = 4;
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.Button7.Text = "Search";
            this.Button7.Location = new System.Drawing.Point(488, 100);
            this.Button7.Size = new System.Drawing.Size(143, 52);
            this.Button7.TabIndex = 7;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(559, 188);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Borrow Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
