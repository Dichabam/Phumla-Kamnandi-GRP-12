namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class FrmReports
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
            this.DatePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DatePickerEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // DatePickerStart
            // 
            this.DatePickerStart.Animated = true;
            this.DatePickerStart.AutoRoundedCorners = true;
            this.DatePickerStart.Checked = true;
            this.DatePickerStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePickerStart.Location = new System.Drawing.Point(46, 150);
            this.DatePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePickerStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePickerStart.Name = "DatePickerStart";
            this.DatePickerStart.Size = new System.Drawing.Size(370, 36);
            this.DatePickerStart.TabIndex = 1;
            this.DatePickerStart.Value = new System.DateTime(2025, 10, 8, 17, 30, 36, 816);
            // 
            // DatePickerEnd
            // 
            this.DatePickerEnd.Animated = true;
            this.DatePickerEnd.AutoRoundedCorners = true;
            this.DatePickerEnd.Checked = true;
            this.DatePickerEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePickerEnd.Location = new System.Drawing.Point(502, 150);
            this.DatePickerEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePickerEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePickerEnd.Name = "DatePickerEnd";
            this.DatePickerEnd.Size = new System.Drawing.Size(370, 36);
            this.DatePickerEnd.TabIndex = 1;
            this.DatePickerEnd.Value = new System.DateTime(2025, 10, 8, 17, 30, 36, 816);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(171, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(158, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.DatePickerEnd);
            this.Controls.Add(this.DatePickerStart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmReports";
            this.Text = "FrmReports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker DatePickerStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePickerEnd;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}