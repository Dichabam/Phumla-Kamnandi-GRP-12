namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class FrmRooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roomsDateview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.phumlaKamnandiDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phumlaKamnandiDBDataSet = new Phumla_Kamnandi_GRP_12.PhumlaKamnandiDBDataSet();
            this.ShowAllRoomsButton = new Guna.UI2.WinForms.Guna2Button();
            this.ShowUnavailableRoomsButton = new Guna.UI2.WinForms.Guna2Button();
            this.showAvailableRoomsButton = new Guna.UI2.WinForms.Guna2Button();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new Phumla_Kamnandi_GRP_12.PhumlaKamnandiDBDataSetTableAdapters.RoomTableAdapter();
            this.roomNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxOccupancyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDateview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsDateview
            // 
            this.roomsDateview.AllowUserToAddRows = false;
            this.roomsDateview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.roomsDateview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.roomsDateview.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsDateview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.roomsDateview.ColumnHeadersHeight = 4;
            this.roomsDateview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.roomsDateview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumDataGridViewTextBoxColumn,
            this.maxOccupancyDataGridViewTextBoxColumn,
            this.availabilityDataGridViewCheckBoxColumn});
            this.roomsDateview.DataSource = this.roomBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomsDateview.DefaultCellStyle = dataGridViewCellStyle3;
            this.roomsDateview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomsDateview.Location = new System.Drawing.Point(27, 34);
            this.roomsDateview.Name = "roomsDateview";
            this.roomsDateview.ReadOnly = true;
            this.roomsDateview.RowHeadersVisible = false;
            this.roomsDateview.RowHeadersWidth = 51;
            this.roomsDateview.RowTemplate.Height = 24;
            this.roomsDateview.Size = new System.Drawing.Size(903, 461);
            this.roomsDateview.TabIndex = 0;
            this.roomsDateview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.roomsDateview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.roomsDateview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.roomsDateview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.roomsDateview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.roomsDateview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.roomsDateview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomsDateview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.roomsDateview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.roomsDateview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsDateview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.roomsDateview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.roomsDateview.ThemeStyle.HeaderStyle.Height = 4;
            this.roomsDateview.ThemeStyle.ReadOnly = true;
            this.roomsDateview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.roomsDateview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.roomsDateview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsDateview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.roomsDateview.ThemeStyle.RowsStyle.Height = 24;
            this.roomsDateview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomsDateview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // phumlaKamnandiDBDataSetBindingSource
            // 
            this.phumlaKamnandiDBDataSetBindingSource.DataSource = this.phumlaKamnandiDBDataSet;
            this.phumlaKamnandiDBDataSetBindingSource.Position = 0;
            // 
            // phumlaKamnandiDBDataSet
            // 
            this.phumlaKamnandiDBDataSet.DataSetName = "PhumlaKamnandiDBDataSet";
            this.phumlaKamnandiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ShowAllRoomsButton
            // 
            this.ShowAllRoomsButton.Animated = true;
            this.ShowAllRoomsButton.AutoRoundedCorners = true;
            this.ShowAllRoomsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ShowAllRoomsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ShowAllRoomsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowAllRoomsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ShowAllRoomsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ShowAllRoomsButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllRoomsButton.ForeColor = System.Drawing.Color.White;
            this.ShowAllRoomsButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.hotel_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz241;
            this.ShowAllRoomsButton.Location = new System.Drawing.Point(636, 522);
            this.ShowAllRoomsButton.Name = "ShowAllRoomsButton";
            this.ShowAllRoomsButton.Size = new System.Drawing.Size(221, 52);
            this.ShowAllRoomsButton.TabIndex = 1;
            this.ShowAllRoomsButton.Text = "All Rooms";
            this.ShowAllRoomsButton.Click += new System.EventHandler(this.showAvailableRoomsButton_Click);
            // 
            // ShowUnavailableRoomsButton
            // 
            this.ShowUnavailableRoomsButton.Animated = true;
            this.ShowUnavailableRoomsButton.AutoRoundedCorners = true;
            this.ShowUnavailableRoomsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ShowUnavailableRoomsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ShowUnavailableRoomsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ShowUnavailableRoomsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ShowUnavailableRoomsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ShowUnavailableRoomsButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.ShowUnavailableRoomsButton.ForeColor = System.Drawing.Color.White;
            this.ShowUnavailableRoomsButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz241;
            this.ShowUnavailableRoomsButton.Location = new System.Drawing.Point(363, 522);
            this.ShowUnavailableRoomsButton.Name = "ShowUnavailableRoomsButton";
            this.ShowUnavailableRoomsButton.Size = new System.Drawing.Size(221, 52);
            this.ShowUnavailableRoomsButton.TabIndex = 1;
            this.ShowUnavailableRoomsButton.Text = "Unavailable Rooms";
            this.ShowUnavailableRoomsButton.Click += new System.EventHandler(this.showAvailableRoomsButton_Click);
            // 
            // showAvailableRoomsButton
            // 
            this.showAvailableRoomsButton.Animated = true;
            this.showAvailableRoomsButton.AutoRoundedCorners = true;
            this.showAvailableRoomsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showAvailableRoomsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showAvailableRoomsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAvailableRoomsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showAvailableRoomsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.showAvailableRoomsButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.showAvailableRoomsButton.ForeColor = System.Drawing.Color.White;
            this.showAvailableRoomsButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.check_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.showAvailableRoomsButton.Location = new System.Drawing.Point(95, 522);
            this.showAvailableRoomsButton.Name = "showAvailableRoomsButton";
            this.showAvailableRoomsButton.Size = new System.Drawing.Size(221, 52);
            this.showAvailableRoomsButton.TabIndex = 1;
            this.showAvailableRoomsButton.Text = "Available Rooms";
            this.showAvailableRoomsButton.Click += new System.EventHandler(this.showAvailableRoomsButton_Click);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.phumlaKamnandiDBDataSetBindingSource;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // roomNumDataGridViewTextBoxColumn
            // 
            this.roomNumDataGridViewTextBoxColumn.DataPropertyName = "RoomNum";
            this.roomNumDataGridViewTextBoxColumn.HeaderText = "RoomNum";
            this.roomNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumDataGridViewTextBoxColumn.Name = "roomNumDataGridViewTextBoxColumn";
            this.roomNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxOccupancyDataGridViewTextBoxColumn
            // 
            this.maxOccupancyDataGridViewTextBoxColumn.DataPropertyName = "MaxOccupancy";
            this.maxOccupancyDataGridViewTextBoxColumn.HeaderText = "MaxOccupancy";
            this.maxOccupancyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxOccupancyDataGridViewTextBoxColumn.Name = "maxOccupancyDataGridViewTextBoxColumn";
            this.maxOccupancyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availabilityDataGridViewCheckBoxColumn
            // 
            this.availabilityDataGridViewCheckBoxColumn.DataPropertyName = "Availability";
            this.availabilityDataGridViewCheckBoxColumn.HeaderText = "Availability";
            this.availabilityDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.availabilityDataGridViewCheckBoxColumn.Name = "availabilityDataGridViewCheckBoxColumn";
            this.availabilityDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // FrmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.ShowAllRoomsButton);
            this.Controls.Add(this.ShowUnavailableRoomsButton);
            this.Controls.Add(this.showAvailableRoomsButton);
            this.Controls.Add(this.roomsDateview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRooms";
            this.Text = "FrmRooms";
            this.Load += new System.EventHandler(this.FrmRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsDateview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView roomsDateview;
        private Guna.UI2.WinForms.Guna2Button showAvailableRoomsButton;
        private Guna.UI2.WinForms.Guna2Button ShowUnavailableRoomsButton;
        private Guna.UI2.WinForms.Guna2Button ShowAllRoomsButton;
        private System.Windows.Forms.BindingSource phumlaKamnandiDBDataSetBindingSource;
        private PhumlaKamnandiDBDataSet phumlaKamnandiDBDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private PhumlaKamnandiDBDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxOccupancyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availabilityDataGridViewCheckBoxColumn;
    }
}