namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class EmployeeLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.EmployeetextBox = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmpIDLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Size = new System.Drawing.Size(450, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phumla Kamnandi Hotels";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 92);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(1);
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.PasswordtextBox);
            this.panel1.Controls.Add(this.NametextBox);
            this.panel1.Controls.Add(this.EmployeetextBox);
            this.panel1.Controls.Add(this.Passwordlabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.EmpIDLabel);
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(97, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 365);
            this.panel1.TabIndex = 2;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(202, 250);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(226, 22);
            this.PasswordtextBox.TabIndex = 8;
            this.PasswordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(203, 197);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(226, 22);
            this.NametextBox.TabIndex = 7;
            // 
            // EmployeetextBox
            // 
            this.EmployeetextBox.Location = new System.Drawing.Point(202, 149);
            this.EmployeetextBox.Name = "EmployeetextBox";
            this.EmployeetextBox.Size = new System.Drawing.Size(226, 22);
            this.EmployeetextBox.TabIndex = 6;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.Location = new System.Drawing.Point(77, 246);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(102, 27);
            this.Passwordlabel.TabIndex = 5;
            this.Passwordlabel.Text = "PASSWORD";
            this.Passwordlabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(78, 202);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 19);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "NAME";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // EmpIDLabel
            // 
            this.EmpIDLabel.AutoSize = true;
            this.EmpIDLabel.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIDLabel.Location = new System.Drawing.Point(75, 155);
            this.EmpIDLabel.Name = "EmpIDLabel";
            this.EmpIDLabel.Size = new System.Drawing.Size(115, 19);
            this.EmpIDLabel.TabIndex = 3;
            this.EmpIDLabel.Text = "EMPLOYEE-ID";
            this.EmpIDLabel.Click += new System.EventHandler(this.EmpIDLabel_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.submitButton.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(153, 308);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(205, 32);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeLogin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmpIDLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox EmployeetextBox;
    }
}