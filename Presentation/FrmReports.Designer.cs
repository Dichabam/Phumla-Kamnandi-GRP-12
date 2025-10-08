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
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.GenerateRevenueReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.GenerateOccupanceReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.SuspendLayout();
            // 
            // DatePickerStart
            // 
            this.DatePickerStart.Animated = true;
            this.DatePickerStart.AutoRoundedCorners = true;
            this.DatePickerStart.Checked = true;
            this.DatePickerStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePickerStart.Location = new System.Drawing.Point(30, 150);
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
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GenerateRevenueReportButton
            // 
            this.GenerateRevenueReportButton.Animated = true;
            this.GenerateRevenueReportButton.BackColor = System.Drawing.Color.Transparent;
            this.GenerateRevenueReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GenerateRevenueReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GenerateRevenueReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenerateRevenueReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GenerateRevenueReportButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenerateRevenueReportButton.ForeColor = System.Drawing.Color.White;
            this.GenerateRevenueReportButton.Location = new System.Drawing.Point(101, 73);
            this.GenerateRevenueReportButton.Name = "GenerateRevenueReportButton";
            this.GenerateRevenueReportButton.Size = new System.Drawing.Size(268, 45);
            this.GenerateRevenueReportButton.TabIndex = 3;
            this.GenerateRevenueReportButton.Text = "Generate Revenue Report";
            // 
            // GenerateOccupanceReportButton
            // 
            this.GenerateOccupanceReportButton.Animated = true;
            this.GenerateOccupanceReportButton.BackColor = System.Drawing.Color.Transparent;
            this.GenerateOccupanceReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GenerateOccupanceReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GenerateOccupanceReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenerateOccupanceReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GenerateOccupanceReportButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenerateOccupanceReportButton.ForeColor = System.Drawing.Color.White;
            this.GenerateOccupanceReportButton.Location = new System.Drawing.Point(555, 73);
            this.GenerateOccupanceReportButton.Name = "GenerateOccupanceReportButton";
            this.GenerateOccupanceReportButton.Size = new System.Drawing.Size(268, 45);
            this.GenerateOccupanceReportButton.TabIndex = 3;
            this.GenerateOccupanceReportButton.Text = "Generate Occupancy Report";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(30, 204);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(893, 10);
            this.guna2Separator2.TabIndex = 7;
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.GenerateOccupanceReportButton);
            this.Controls.Add(this.GenerateRevenueReportButton);
            this.Controls.Add(this.DatePickerEnd);
            this.Controls.Add(this.DatePickerStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReports";
            this.Text = "FrmReports";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker DatePickerStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePickerEnd;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button GenerateRevenueReportButton;
        private Guna.UI2.WinForms.Guna2Button GenerateOccupanceReportButton;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
    }
}