namespace OOPEmployeeApp
{
    partial class Salary
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
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.homeTextBox = new System.Windows.Forms.TextBox();
            this.medicalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(186, 32);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(267, 20);
            this.employeeNameTextBox.TabIndex = 0;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(186, 68);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(267, 20);
            this.salaryTextBox.TabIndex = 0;
            // 
            // homeTextBox
            // 
            this.homeTextBox.Location = new System.Drawing.Point(186, 104);
            this.homeTextBox.Name = "homeTextBox";
            this.homeTextBox.Size = new System.Drawing.Size(267, 20);
            this.homeTextBox.TabIndex = 0;
            // 
            // medicalTextBox
            // 
            this.medicalTextBox.Location = new System.Drawing.Point(186, 145);
            this.medicalTextBox.Name = "medicalTextBox";
            this.medicalTextBox.Size = new System.Drawing.Size(267, 20);
            this.medicalTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Medical Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "% of basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "% of Basic";
            // 
            // salaryButton
            // 
            this.salaryButton.Location = new System.Drawing.Point(177, 209);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Size = new System.Drawing.Size(276, 38);
            this.salaryButton.TabIndex = 2;
            this.salaryButton.Text = "Show Total Salary";
            this.salaryButton.UseVisualStyleBackColor = true;
            this.salaryButton.Click += new System.EventHandler(this.salaryButton_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 389);
            this.Controls.Add(this.salaryButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medicalTextBox);
            this.Controls.Add(this.homeTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Name = "Salary";
            this.Text = "Salary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox homeTextBox;
        private System.Windows.Forms.TextBox medicalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button salaryButton;
    }
}

