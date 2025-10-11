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
            this.EmployeeDataGridViiew = new System.Windows.Forms.DataGridView();
            this.AddEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.ChangeRoleButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeactivateEmployeeButton = new Guna.UI2.WinForms.Guna2Button();
            this.NametextEm = new Guna.UI2.WinForms.Guna2TextBox();
            this.surnameTxtEm = new Guna.UI2.WinForms.Guna2TextBox();
            this.phonetxtEm = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailTextEm = new Guna.UI2.WinForms.Guna2TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.changerolebuttonconfirm = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridViiew)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeDataGridViiew
            // 
            this.EmployeeDataGridViiew.AllowUserToAddRows = false;
            this.EmployeeDataGridViiew.AllowUserToDeleteRows = false;
            this.EmployeeDataGridViiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridViiew.Location = new System.Drawing.Point(25, 23);
            this.EmployeeDataGridViiew.Name = "EmployeeDataGridViiew";
            this.EmployeeDataGridViiew.ReadOnly = true;
            this.EmployeeDataGridViiew.RowHeadersWidth = 51;
            this.EmployeeDataGridViiew.RowTemplate.Height = 24;
            this.EmployeeDataGridViiew.Size = new System.Drawing.Size(905, 283);
            this.EmployeeDataGridViiew.TabIndex = 0;
            this.EmployeeDataGridViiew.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridViiew_CellContentClick);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Animated = true;
            this.AddEmployeeButton.AutoRoundedCorners = true;
            this.AddEmployeeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddEmployeeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddEmployeeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddEmployeeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddEmployeeButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.Location = new System.Drawing.Point(65, 323);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(180, 45);
            this.AddEmployeeButton.TabIndex = 1;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // ChangeRoleButton
            // 
            this.ChangeRoleButton.Animated = true;
            this.ChangeRoleButton.AutoRoundedCorners = true;
            this.ChangeRoleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChangeRoleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChangeRoleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChangeRoleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChangeRoleButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeRoleButton.ForeColor = System.Drawing.Color.White;
            this.ChangeRoleButton.Location = new System.Drawing.Point(398, 323);
            this.ChangeRoleButton.Name = "ChangeRoleButton";
            this.ChangeRoleButton.Size = new System.Drawing.Size(180, 45);
            this.ChangeRoleButton.TabIndex = 1;
            this.ChangeRoleButton.Text = "Change Role";
            this.ChangeRoleButton.Click += new System.EventHandler(this.ChangeRoleButton_Click);
            // 
            // DeactivateEmployeeButton
            // 
            this.DeactivateEmployeeButton.Animated = true;
            this.DeactivateEmployeeButton.AutoRoundedCorners = true;
            this.DeactivateEmployeeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeactivateEmployeeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeactivateEmployeeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeactivateEmployeeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeactivateEmployeeButton.FillColor = System.Drawing.Color.Red;
            this.DeactivateEmployeeButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.DeactivateEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.DeactivateEmployeeButton.Location = new System.Drawing.Point(750, 323);
            this.DeactivateEmployeeButton.Name = "DeactivateEmployeeButton";
            this.DeactivateEmployeeButton.Size = new System.Drawing.Size(180, 45);
            this.DeactivateEmployeeButton.TabIndex = 1;
            this.DeactivateEmployeeButton.Text = "Deactivate ";
            this.DeactivateEmployeeButton.Click += new System.EventHandler(this.DeactivateEmployeeButton_Click);
            // 
            // NametextEm
            // 
            this.NametextEm.Animated = true;
            this.NametextEm.AutoRoundedCorners = true;
            this.NametextEm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NametextEm.DefaultText = "";
            this.NametextEm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NametextEm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NametextEm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NametextEm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NametextEm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NametextEm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NametextEm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NametextEm.Location = new System.Drawing.Point(222, 419);
            this.NametextEm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NametextEm.Name = "NametextEm";
            this.NametextEm.PlaceholderText = "";
            this.NametextEm.SelectedText = "";
            this.NametextEm.Size = new System.Drawing.Size(385, 48);
            this.NametextEm.TabIndex = 2;
            this.NametextEm.TextChanged += new System.EventHandler(this.NametextEm_TextChanged);
            // 
            // surnameTxtEm
            // 
            this.surnameTxtEm.Animated = true;
            this.surnameTxtEm.AutoRoundedCorners = true;
            this.surnameTxtEm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameTxtEm.DefaultText = "";
            this.surnameTxtEm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.surnameTxtEm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.surnameTxtEm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTxtEm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTxtEm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnameTxtEm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.surnameTxtEm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnameTxtEm.Location = new System.Drawing.Point(222, 475);
            this.surnameTxtEm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surnameTxtEm.Name = "surnameTxtEm";
            this.surnameTxtEm.PlaceholderText = "";
            this.surnameTxtEm.SelectedText = "";
            this.surnameTxtEm.Size = new System.Drawing.Size(385, 48);
            this.surnameTxtEm.TabIndex = 2;
            this.surnameTxtEm.TextChanged += new System.EventHandler(this.surnameTxtEm_TextChanged);
            // 
            // phonetxtEm
            // 
            this.phonetxtEm.Animated = true;
            this.phonetxtEm.AutoRoundedCorners = true;
            this.phonetxtEm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonetxtEm.DefaultText = "";
            this.phonetxtEm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phonetxtEm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phonetxtEm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetxtEm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetxtEm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetxtEm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phonetxtEm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetxtEm.Location = new System.Drawing.Point(222, 531);
            this.phonetxtEm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phonetxtEm.Name = "phonetxtEm";
            this.phonetxtEm.PlaceholderText = "";
            this.phonetxtEm.SelectedText = "";
            this.phonetxtEm.Size = new System.Drawing.Size(385, 48);
            this.phonetxtEm.TabIndex = 2;
            this.phonetxtEm.TextChanged += new System.EventHandler(this.phonetxtEm_TextChanged);
            // 
            // EmailTextEm
            // 
            this.EmailTextEm.Animated = true;
            this.EmailTextEm.AutoRoundedCorners = true;
            this.EmailTextEm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextEm.DefaultText = "";
            this.EmailTextEm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextEm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextEm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextEm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextEm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextEm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailTextEm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextEm.Location = new System.Drawing.Point(222, 587);
            this.EmailTextEm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTextEm.Name = "EmailTextEm";
            this.EmailTextEm.PlaceholderText = "";
            this.EmailTextEm.SelectedText = "";
            this.EmailTextEm.Size = new System.Drawing.Size(385, 48);
            this.EmailTextEm.TabIndex = 2;
            this.EmailTextEm.TextChanged += new System.EventHandler(this.EmailTextEm_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(61, 419);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(57, 23);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.ForeColor = System.Drawing.Color.White;
            this.Surname.Location = new System.Drawing.Point(61, 475);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(81, 23);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2ComboBox1);
            this.panel1.Controls.Add(this.changerolebuttonconfirm);
            this.panel1.Location = new System.Drawing.Point(24, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 264);
            this.panel1.TabIndex = 4;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Employee",
            "Admin/Manager"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(13, 21);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(236, 36);
            this.guna2ComboBox1.TabIndex = 0;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // changerolebuttonconfirm
            // 
            this.changerolebuttonconfirm.Animated = true;
            this.changerolebuttonconfirm.AutoRoundedCorners = true;
            this.changerolebuttonconfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changerolebuttonconfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changerolebuttonconfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changerolebuttonconfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changerolebuttonconfirm.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changerolebuttonconfirm.ForeColor = System.Drawing.Color.White;
            this.changerolebuttonconfirm.Location = new System.Drawing.Point(267, 21);
            this.changerolebuttonconfirm.Name = "changerolebuttonconfirm";
            this.changerolebuttonconfirm.Size = new System.Drawing.Size(180, 36);
            this.changerolebuttonconfirm.TabIndex = 1;
            this.changerolebuttonconfirm.Text = "Confirm";
            this.changerolebuttonconfirm.Click += new System.EventHandler(this.changerolebuttonconfirm_Click);
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.EmailTextEm);
            this.Controls.Add(this.phonetxtEm);
            this.Controls.Add(this.surnameTxtEm);
            this.Controls.Add(this.NametextEm);
            this.Controls.Add(this.DeactivateEmployeeButton);
            this.Controls.Add(this.ChangeRoleButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.EmployeeDataGridViiew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name.Text = "FrmEmployees";
            this.Text = "FrmEmployees";
            this.Load += new System.EventHandler(this.FrmEmployees_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridViiew)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataGridViiew;
        private Guna.UI2.WinForms.Guna2Button AddEmployeeButton;
        private Guna.UI2.WinForms.Guna2Button ChangeRoleButton;
        private Guna.UI2.WinForms.Guna2Button DeactivateEmployeeButton;
        private Guna.UI2.WinForms.Guna2TextBox NametextEm;
        private Guna.UI2.WinForms.Guna2TextBox surnameTxtEm;
        private Guna.UI2.WinForms.Guna2TextBox phonetxtEm;
        private Guna.UI2.WinForms.Guna2TextBox EmailTextEm;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button changerolebuttonconfirm;
    }
}