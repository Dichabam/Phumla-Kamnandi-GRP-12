namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.PnlNav = new System.Windows.Forms.Panel();
            this.SidePanel2 = new System.Windows.Forms.Panel();
            this.Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.WelcomLabel = new System.Windows.Forms.Label();
            this.CompanyLogo = new System.Windows.Forms.PictureBox();
            this.SidePanelDSHB = new System.Windows.Forms.Panel();
            this.LogoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.RoomsButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.GuestButton = new System.Windows.Forms.Button();
            this.BookingButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.exitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            this.SidePanelDSHB.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 570);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 1;
            // 
            // SidePanel2
            // 
            this.SidePanel2.BackColor = System.Drawing.Color.Transparent;
            this.SidePanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidePanel2.Controls.Add(this.Separator1);
            this.SidePanel2.Controls.Add(this.Separator2);
            this.SidePanel2.Controls.Add(this.WelcomLabel);
            this.SidePanel2.Controls.Add(this.CompanyLogo);
            this.SidePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidePanel2.Location = new System.Drawing.Point(0, 0);
            this.SidePanel2.Name = "SidePanel2";
            this.SidePanel2.Size = new System.Drawing.Size(297, 201);
            this.SidePanel2.TabIndex = 0;
            // 
            // Separator1
            // 
            this.Separator1.Location = new System.Drawing.Point(51, 150);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(200, 10);
            this.Separator1.TabIndex = 5;
            // 
            // Separator2
            // 
            this.Separator2.Location = new System.Drawing.Point(51, 185);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(200, 10);
            this.Separator2.TabIndex = 4;
            // 
            // WelcomLabel
            // 
            this.WelcomLabel.AutoSize = true;
            this.WelcomLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.WelcomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.WelcomLabel.Location = new System.Drawing.Point(50, 163);
            this.WelcomLabel.Name = "WelcomLabel";
            this.WelcomLabel.Size = new System.Drawing.Size(55, 19);
            this.WelcomLabel.TabIndex = 1;
            this.WelcomLabel.Text = "USER 1";
            this.WelcomLabel.Click += new System.EventHandler(this.WelcomLabel_Click);
            // 
            // CompanyLogo
            // 
            this.CompanyLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.CompanyLogo.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.PHUMLA_KAMNANDI_Photoroom;
            this.CompanyLogo.Location = new System.Drawing.Point(0, 0);
            this.CompanyLogo.Name = "CompanyLogo";
            this.CompanyLogo.Size = new System.Drawing.Size(297, 198);
            this.CompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CompanyLogo.TabIndex = 0;
            this.CompanyLogo.TabStop = false;
            this.CompanyLogo.Click += new System.EventHandler(this.CompanyLogo_Click);
            // 
            // SidePanelDSHB
            // 
            this.SidePanelDSHB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.SidePanelDSHB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidePanelDSHB.Controls.Add(this.LogoutButton);
            this.SidePanelDSHB.Controls.Add(this.SettingsButton);
            this.SidePanelDSHB.Controls.Add(this.EmployeesButton);
            this.SidePanelDSHB.Controls.Add(this.RoomsButton);
            this.SidePanelDSHB.Controls.Add(this.ReportsButton);
            this.SidePanelDSHB.Controls.Add(this.GuestButton);
            this.SidePanelDSHB.Controls.Add(this.BookingButton);
            this.SidePanelDSHB.Controls.Add(this.HomeButton);
            this.SidePanelDSHB.Controls.Add(this.SidePanel2);
            this.SidePanelDSHB.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanelDSHB.Location = new System.Drawing.Point(0, 0);
            this.SidePanelDSHB.Name = "SidePanelDSHB";
            this.SidePanelDSHB.Size = new System.Drawing.Size(297, 777);
            this.SidePanelDSHB.TabIndex = 0;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Animated = true;
            this.LogoutButton.AutoRoundedCorners = true;
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogoutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.logout_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.LogoutButton.Location = new System.Drawing.Point(54, 646);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(180, 45);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseTransparentBackground = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SettingsButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.account_circle_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.SettingsButton.Location = new System.Drawing.Point(0, 710);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(297, 67);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Profile";
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            this.SettingsButton.Leave += new System.EventHandler(this.SettingsButton_Leave);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.BackColor = System.Drawing.Color.Transparent;
            this.EmployeesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeesButton.FlatAppearance.BorderSize = 0;
            this.EmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.EmployeesButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.groups_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.EmployeesButton.Location = new System.Drawing.Point(0, 536);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(297, 67);
            this.EmployeesButton.TabIndex = 2;
            this.EmployeesButton.Text = "Employees";
            this.EmployeesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.EmployeesButton.UseVisualStyleBackColor = false;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            this.EmployeesButton.Leave += new System.EventHandler(this.EmployeesButton_Leave);
            // 
            // RoomsButton
            // 
            this.RoomsButton.BackColor = System.Drawing.Color.Transparent;
            this.RoomsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoomsButton.FlatAppearance.BorderSize = 0;
            this.RoomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomsButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RoomsButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.home_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.RoomsButton.Location = new System.Drawing.Point(0, 469);
            this.RoomsButton.Name = "RoomsButton";
            this.RoomsButton.Size = new System.Drawing.Size(297, 67);
            this.RoomsButton.TabIndex = 2;
            this.RoomsButton.Text = "Rooms";
            this.RoomsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.RoomsButton.UseVisualStyleBackColor = false;
            this.RoomsButton.Click += new System.EventHandler(this.RoomsButton_Click);
            this.RoomsButton.Leave += new System.EventHandler(this.RoomsButton_Leave);
            // 
            // ReportsButton
            // 
            this.ReportsButton.BackColor = System.Drawing.Color.Transparent;
            this.ReportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportsButton.FlatAppearance.BorderSize = 0;
            this.ReportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ReportsButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.bar_chart_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.ReportsButton.Location = new System.Drawing.Point(0, 402);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(297, 67);
            this.ReportsButton.TabIndex = 2;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ReportsButton.UseVisualStyleBackColor = false;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            this.ReportsButton.Leave += new System.EventHandler(this.ReportsButton_Leave);
            // 
            // GuestButton
            // 
            this.GuestButton.BackColor = System.Drawing.Color.Transparent;
            this.GuestButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GuestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GuestButton.FlatAppearance.BorderSize = 0;
            this.GuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuestButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.GuestButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.person_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.GuestButton.Location = new System.Drawing.Point(0, 335);
            this.GuestButton.Name = "GuestButton";
            this.GuestButton.Size = new System.Drawing.Size(297, 67);
            this.GuestButton.TabIndex = 2;
            this.GuestButton.Text = "Guests";
            this.GuestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.GuestButton.UseVisualStyleBackColor = false;
            this.GuestButton.Click += new System.EventHandler(this.GuestButton_Click);
            this.GuestButton.Leave += new System.EventHandler(this.GuestButton_Leave);
            // 
            // BookingButton
            // 
            this.BookingButton.BackColor = System.Drawing.Color.Transparent;
            this.BookingButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BookingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookingButton.FlatAppearance.BorderSize = 0;
            this.BookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookingButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BookingButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.event_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.BookingButton.Location = new System.Drawing.Point(0, 268);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(297, 67);
            this.BookingButton.TabIndex = 2;
            this.BookingButton.Text = "Bookings \r\n";
            this.BookingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BookingButton.UseVisualStyleBackColor = false;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            this.BookingButton.Leave += new System.EventHandler(this.BookingButton_Leave);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.HomeButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.home_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.HomeButton.Location = new System.Drawing.Point(0, 201);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(297, 67);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            this.HomeButton.Leave += new System.EventHandler(this.HomeButton_Leave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTitle.Location = new System.Drawing.Point(353, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 45);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "HOME";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Animated = true;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FillColor = System.Drawing.Color.SlateGray;
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBox.ForeColor = System.Drawing.Color.White;
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Location = new System.Drawing.Point(720, 17);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.SearchBox.PlaceholderText = "Search";
            this.SearchBox.SelectedText = "";
            this.SearchBox.Size = new System.Drawing.Size(421, 44);
            this.SearchBox.TabIndex = 14;
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(297, 68);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(954, 709);
            this.PnlFormLoader.TabIndex = 16;
            this.PnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormLoader_Paint);
            // 
            // exitButton
            // 
            this.exitButton.Animated = true;
            this.exitButton.BorderColor = System.Drawing.Color.White;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.DarkGray;
            this.exitButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.exitButton.Location = new System.Drawing.Point(1164, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitButton.Size = new System.Drawing.Size(75, 49);
            this.exitButton.TabIndex = 15;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1251, 777);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.PnlNav);
            this.Controls.Add(this.SidePanelDSHB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.SidePanel2.ResumeLayout(false);
            this.SidePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            this.SidePanelDSHB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Panel SidePanel2;
        private System.Windows.Forms.PictureBox CompanyLogo;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.Button GuestButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button RoomsButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel SidePanelDSHB;
        private System.Windows.Forms.Label WelcomLabel;
        private Guna.UI2.WinForms.Guna2Separator Separator1;
        private Guna.UI2.WinForms.Guna2Separator Separator2;
        private Guna.UI2.WinForms.Guna2Button LogoutButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2CircleButton exitButton;
        private System.Windows.Forms.Panel PnlFormLoader;
    }
}