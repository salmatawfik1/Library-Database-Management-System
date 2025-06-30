namespace forms
{
    partial class UserUpdate
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
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxBuildingNum = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelBuildingNum = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(150, 50);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(200, 39);
            this.textBoxUserID.TabIndex = 0;
            // 
            // textBoxBuildingNum
            // 
            this.textBoxBuildingNum.Location = new System.Drawing.Point(150, 100);
            this.textBoxBuildingNum.Name = "textBoxBuildingNum";
            this.textBoxBuildingNum.Size = new System.Drawing.Size(200, 39);
            this.textBoxBuildingNum.TabIndex = 1;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(150, 150);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(200, 39);
            this.textBoxStreet.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(150, 200);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(200, 50);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(50, 50);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(82, 32);
            this.labelUserID.TabIndex = 4;
            this.labelUserID.Text = "User ID";
            // 
            // labelBuildingNum
            // 
            this.labelBuildingNum.AutoSize = true;
            this.labelBuildingNum.Location = new System.Drawing.Point(50, 100);
            this.labelBuildingNum.Name = "labelBuildingNum";
            this.labelBuildingNum.Size = new System.Drawing.Size(94, 32);
            this.labelBuildingNum.TabIndex = 5;
            this.labelBuildingNum.Text = "Building";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(50, 150);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(75, 32);
            this.labelStreet.TabIndex = 6;
            this.labelStreet.Text = "Street";
            // 
            // FormUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelBuildingNum);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxBuildingNum);
            this.Controls.Add(this.textBoxUserID);
            this.Name = "FormUpdateUser";
            this.Text = "User Update";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxBuildingNum;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelBuildingNum;
        private System.Windows.Forms.Label labelStreet;
    }
}
