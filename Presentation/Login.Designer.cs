namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.EmailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SubmitButton = new Guna.UI2.WinForms.Guna2Button();
            this.forgotpasswordLink = new System.Windows.Forms.LinkLabel();
            this.SidePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.ErrorLoginLabel = new System.Windows.Forms.Label();
            this.CreateAccountButton = new Guna.UI2.WinForms.Guna2Button();
            this.viewPasswordButton = new Guna.UI2.WinForms.Guna2Button();
            this.CloseButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Animated = true;
            this.EmailTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.EmailTextbox.BorderRadius = 15;
            this.EmailTextbox.BorderThickness = 2;
            this.EmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextbox.DefaultText = "";
            this.EmailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.EmailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextbox.Location = new System.Drawing.Point(415, 145);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.PlaceholderText = "Email";
            this.EmailTextbox.SelectedText = "";
            this.EmailTextbox.Size = new System.Drawing.Size(357, 48);
            this.EmailTextbox.TabIndex = 1;
            this.EmailTextbox.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Animated = true;
            this.PasswordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PasswordTextbox.BorderRadius = 15;
            this.PasswordTextbox.BorderThickness = 2;
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextbox.DefaultText = "";
            this.PasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.PasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(415, 222);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PlaceholderText = "Password";
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.Size = new System.Drawing.Size(357, 48);
            this.PasswordTextbox.TabIndex = 2;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Animated = true;
            this.SubmitButton.AutoRoundedCorners = true;
            this.SubmitButton.BackColor = System.Drawing.Color.Transparent;
            this.SubmitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubmitButton.BorderThickness = 2;
            this.SubmitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(504, 325);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(180, 45);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // forgotpasswordLink
            // 
            this.forgotpasswordLink.AutoSize = true;
            this.forgotpasswordLink.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpasswordLink.LinkColor = System.Drawing.Color.SteelBlue;
            this.forgotpasswordLink.Location = new System.Drawing.Point(412, 274);
            this.forgotpasswordLink.Name = "forgotpasswordLink";
            this.forgotpasswordLink.Size = new System.Drawing.Size(115, 17);
            this.forgotpasswordLink.TabIndex = 5;
            this.forgotpasswordLink.TabStop = true;
            this.forgotpasswordLink.Text = "Forgot Password";
            this.forgotpasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotpasswordLink_LinkClicked);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Transparent;
            this.SidePanel.Controls.Add(this.logo);
            this.SidePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SidePanel.FillColor2 = System.Drawing.Color.Transparent;
            this.SidePanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SidePanel.Location = new System.Drawing.Point(-2, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(393, 450);
            this.SidePanel.TabIndex = 6;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.PHUMLA_KAMNANDI_Photoroom;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(411, 450);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(494, 49);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(182, 59);
            this.LoginLabel.TabIndex = 7;
            this.LoginLabel.Text = "LOGIN";
            this.LoginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ErrorLoginLabel
            // 
            this.ErrorLoginLabel.AutoSize = true;
            this.ErrorLoginLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.ErrorLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLoginLabel.Location = new System.Drawing.Point(452, 115);
            this.ErrorLoginLabel.Name = "ErrorLoginLabel";
            this.ErrorLoginLabel.Size = new System.Drawing.Size(255, 16);
            this.ErrorLoginLabel.TabIndex = 8;
            this.ErrorLoginLabel.Text = "Email/Password is incorrect. Try again";
            this.ErrorLoginLabel.Click += new System.EventHandler(this.ErrorLoginLabel_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Animated = true;
            this.CreateAccountButton.AutoRoundedCorners = true;
            this.CreateAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CreateAccountButton.BorderThickness = 2;
            this.CreateAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateAccountButton.FillColor = System.Drawing.Color.Transparent;
            this.CreateAccountButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CreateAccountButton.ForeColor = System.Drawing.Color.White;
            this.CreateAccountButton.Location = new System.Drawing.Point(504, 376);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(180, 45);
            this.CreateAccountButton.TabIndex = 3;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // viewPasswordButton
            // 
            this.viewPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.viewPasswordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewPasswordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewPasswordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewPasswordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewPasswordButton.FillColor = System.Drawing.Color.White;
            this.viewPasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewPasswordButton.ForeColor = System.Drawing.Color.White;
            this.viewPasswordButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.visibility_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            this.viewPasswordButton.Location = new System.Drawing.Point(707, 232);
            this.viewPasswordButton.Name = "viewPasswordButton";
            this.viewPasswordButton.Size = new System.Drawing.Size(56, 30);
            this.viewPasswordButton.TabIndex = 13;
            this.viewPasswordButton.Click += new System.EventHandler(this.viewPasswordButton_Click);
            // 
            // CloseButtonLogin
            // 
            this.CloseButtonLogin.Animated = true;
            this.CloseButtonLogin.AutoRoundedCorners = true;
            this.CloseButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.CloseButtonLogin.BorderColor = System.Drawing.Color.Transparent;
            this.CloseButtonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseButtonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseButtonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseButtonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseButtonLogin.FillColor = System.Drawing.Color.Transparent;
            this.CloseButtonLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButtonLogin.ForeColor = System.Drawing.Color.White;
            this.CloseButtonLogin.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.CloseButtonLogin.Location = new System.Drawing.Point(742, 0);
            this.CloseButtonLogin.Name = "CloseButtonLogin";
            this.CloseButtonLogin.Size = new System.Drawing.Size(57, 30);
            this.CloseButtonLogin.TabIndex = 12;
            this.CloseButtonLogin.UseTransparentBackground = true;
            this.CloseButtonLogin.Click += new System.EventHandler(this.CloseButtonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewPasswordButton);
            this.Controls.Add(this.CloseButtonLogin);
            this.Controls.Add(this.ErrorLoginLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.forgotpasswordLink);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox EmailTextbox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
        private Guna.UI2.WinForms.Guna2Button SubmitButton;
        private System.Windows.Forms.LinkLabel forgotpasswordLink;
        private System.Windows.Forms.PictureBox logo;
        private Guna.UI2.WinForms.Guna2GradientPanel SidePanel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label ErrorLoginLabel;
        private Guna.UI2.WinForms.Guna2Button CloseButtonLogin;
        private Guna.UI2.WinForms.Guna2Button CreateAccountButton;
        private Guna.UI2.WinForms.Guna2Button viewPasswordButton;
    }
}