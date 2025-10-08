namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class FrmEmployees
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
            this.FrmEmployeesLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmEmployeesLabel
            // 
            this.FrmEmployeesLabel.AutoSize = true;
            this.FrmEmployeesLabel.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmEmployeesLabel.ForeColor = System.Drawing.Color.White;
            this.FrmEmployeesLabel.Location = new System.Drawing.Point(288, 196);
            this.FrmEmployeesLabel.Name = "FrmEmployeesLabel";
            this.FrmEmployeesLabel.Size = new System.Drawing.Size(385, 50);
            this.FrmEmployeesLabel.TabIndex = 2;
            this.FrmEmployeesLabel.Text = "Your Employees here";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.groups_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz241;
            this.pictureBox2.Location = new System.Drawing.Point(250, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(454, 263);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FrmEmployeesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmployees";
            this.Text = "FrmEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label FrmEmployeesLabel;
    }
}