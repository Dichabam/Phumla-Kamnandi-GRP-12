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
            this.components = new System.ComponentModel.Container();
            this.DatePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DatePickerEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.ReportTypeLabel = new System.Windows.Forms.Label();
            this.OccupancyReportRadioButton = new System.Windows.Forms.RadioButton();
            this.RevenueRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectDateLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.GenerateReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.ReportDataview = new System.Windows.Forms.DataGridView();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.phumlaKamnandiDBDataSet = new Phumla_Kamnandi_GRP_12.PhumlaKamnandiDBDataSet();
            this.phumlaKamnandiDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePickerStart
            // 
            this.DatePickerStart.Animated = true;
            this.DatePickerStart.AutoRoundedCorners = true;
            this.DatePickerStart.Checked = true;
            this.DatePickerStart.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePickerStart.Location = new System.Drawing.Point(63, 209);
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
            this.DatePickerEnd.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatePickerEnd.Location = new System.Drawing.Point(527, 209);
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
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(25, 101);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(893, 10);
            this.guna2Separator2.TabIndex = 7;
            // 
            // ReportTypeLabel
            // 
            this.ReportTypeLabel.AutoSize = true;
            this.ReportTypeLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTypeLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ReportTypeLabel.Location = new System.Drawing.Point(362, 9);
            this.ReportTypeLabel.Name = "ReportTypeLabel";
            this.ReportTypeLabel.Size = new System.Drawing.Size(255, 31);
            this.ReportTypeLabel.TabIndex = 8;
            this.ReportTypeLabel.Text = "CHOOSE REPORT TYPE";
            // 
            // OccupancyReportRadioButton
            // 
            this.OccupancyReportRadioButton.AutoSize = true;
            this.OccupancyReportRadioButton.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OccupancyReportRadioButton.ForeColor = System.Drawing.Color.White;
            this.OccupancyReportRadioButton.Location = new System.Drawing.Point(98, 53);
            this.OccupancyReportRadioButton.Name = "OccupancyReportRadioButton";
            this.OccupancyReportRadioButton.Size = new System.Drawing.Size(276, 42);
            this.OccupancyReportRadioButton.TabIndex = 9;
            this.OccupancyReportRadioButton.TabStop = true;
            this.OccupancyReportRadioButton.Text = "Occupancy Report";
            this.OccupancyReportRadioButton.UseVisualStyleBackColor = true;
            // 
            // RevenueRadioButton
            // 
            this.RevenueRadioButton.AutoSize = true;
            this.RevenueRadioButton.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenueRadioButton.ForeColor = System.Drawing.Color.White;
            this.RevenueRadioButton.Location = new System.Drawing.Point(569, 53);
            this.RevenueRadioButton.Name = "RevenueRadioButton";
            this.RevenueRadioButton.Size = new System.Drawing.Size(246, 42);
            this.RevenueRadioButton.TabIndex = 9;
            this.RevenueRadioButton.TabStop = true;
            this.RevenueRadioButton.Text = "Revenue Report";
            this.RevenueRadioButton.UseVisualStyleBackColor = true;
            // 
            // SelectDateLabel
            // 
            this.SelectDateLabel.AutoSize = true;
            this.SelectDateLabel.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDateLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.SelectDateLabel.Location = new System.Drawing.Point(362, 129);
            this.SelectDateLabel.Name = "SelectDateLabel";
            this.SelectDateLabel.Size = new System.Drawing.Size(235, 31);
            this.SelectDateLabel.TabIndex = 8;
            this.SelectDateLabel.Text = "SELECT DATE RANGE";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.ForeColor = System.Drawing.Color.White;
            this.FromLabel.Location = new System.Drawing.Point(81, 183);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(52, 23);
            this.FromLabel.TabIndex = 10;
            this.FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.ForeColor = System.Drawing.Color.White;
            this.ToLabel.Location = new System.Drawing.Point(544, 183);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(28, 23);
            this.ToLabel.TabIndex = 10;
            this.ToLabel.Text = "To";
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GenerateReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GenerateReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenerateReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GenerateReportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.GenerateReportButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenerateReportButton.ForeColor = System.Drawing.Color.White;
            this.GenerateReportButton.Location = new System.Drawing.Point(392, 288);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(180, 45);
            this.GenerateReportButton.TabIndex = 11;
            this.GenerateReportButton.Text = "Generate Report";
            // 
            // ReportDataview
            // 
            this.ReportDataview.AllowUserToAddRows = false;
            this.ReportDataview.AllowUserToDeleteRows = false;
            this.ReportDataview.AutoGenerateColumns = false;
            this.ReportDataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataview.DataSource = this.phumlaKamnandiDBDataSetBindingSource;
            this.ReportDataview.Location = new System.Drawing.Point(25, 367);
            this.ReportDataview.Name = "ReportDataview";
            this.ReportDataview.ReadOnly = true;
            this.ReportDataview.RowHeadersWidth = 51;
            this.ReportDataview.RowTemplate.Height = 24;
            this.ReportDataview.Size = new System.Drawing.Size(903, 269);
            this.ReportDataview.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Animated = true;
            this.saveButton.AutoRoundedCorners = true;
            this.saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.save_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.saveButton.Location = new System.Drawing.Point(717, 652);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 45);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save Report";
            // 
            // phumlaKamnandiDBDataSet
            // 
            this.phumlaKamnandiDBDataSet.DataSetName = "PhumlaKamnandiDBDataSet";
            this.phumlaKamnandiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phumlaKamnandiDBDataSetBindingSource
            // 
            this.phumlaKamnandiDBDataSetBindingSource.DataSource = this.phumlaKamnandiDBDataSet;
            this.phumlaKamnandiDBDataSetBindingSource.Position = 0;
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ReportDataview);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.RevenueRadioButton);
            this.Controls.Add(this.OccupancyReportRadioButton);
            this.Controls.Add(this.SelectDateLabel);
            this.Controls.Add(this.ReportTypeLabel);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.DatePickerEnd);
            this.Controls.Add(this.DatePickerStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReports";
            this.Text = "FrmReports";
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker DatePickerStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePickerEnd;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label ReportTypeLabel;
        private System.Windows.Forms.RadioButton OccupancyReportRadioButton;
        private System.Windows.Forms.RadioButton RevenueRadioButton;
        private System.Windows.Forms.Label SelectDateLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private Guna.UI2.WinForms.Guna2Button GenerateReportButton;
        private System.Windows.Forms.DataGridView ReportDataview;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private System.Windows.Forms.BindingSource phumlaKamnandiDBDataSetBindingSource;
        private PhumlaKamnandiDBDataSet phumlaKamnandiDBDataSet;
    }
}