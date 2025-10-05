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
            this.intro_panel_login = new System.Windows.Forms.Panel();
            this.welcome_2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.welcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.EmailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SubmitButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.forgotpasswordLink = new System.Windows.Forms.LinkLabel();
            this.intro_panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // intro_panel_login
            // 
            this.intro_panel_login.BackColor = System.Drawing.Color.Transparent;
            this.intro_panel_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("intro_panel_login.BackgroundImage")));
            this.intro_panel_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.intro_panel_login.Controls.Add(this.welcome_2);
            this.intro_panel_login.Controls.Add(this.welcome);
            this.intro_panel_login.Controls.Add(this.logo);
            this.intro_panel_login.Location = new System.Drawing.Point(0, 0);
            this.intro_panel_login.Name = "intro_panel_login";
            this.intro_panel_login.Size = new System.Drawing.Size(400, 452);
            this.intro_panel_login.TabIndex = 0;
            // 
            // welcome_2
            // 
            this.welcome_2.BackColor = System.Drawing.Color.Transparent;
            this.welcome_2.Font = new System.Drawing.Font("Segoe UI Black", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_2.ForeColor = System.Drawing.SystemColors.Window;
            this.welcome_2.Location = new System.Drawing.Point(37, 318);
            this.welcome_2.Name = "welcome_2";
            this.welcome_2.Size = new System.Drawing.Size(311, 91);
            this.welcome_2.TabIndex = 2;
            this.welcome_2.Text = "STARTED";
            this.welcome_2.Click += new System.EventHandler(this.welcome_2_Click);
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(58, 234);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(260, 91);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Let\'s Get ";
            this.welcome.Click += new System.EventHandler(this.welcome_Click);
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(400, 228);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.EmailTextbox.BorderRadius = 15;
            this.EmailTextbox.BorderThickness = 2;
            this.EmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextbox.DefaultText = "Email";
            this.EmailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextbox.Location = new System.Drawing.Point(426, 150);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.PlaceholderText = "";
            this.EmailTextbox.SelectedText = "";
            this.EmailTextbox.Size = new System.Drawing.Size(346, 48);
            this.EmailTextbox.TabIndex = 1;
            this.EmailTextbox.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.PasswordTextbox.BorderRadius = 15;
            this.PasswordTextbox.BorderThickness = 2;
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextbox.DefaultText = "Password";
            this.PasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(426, 234);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PlaceholderText = "";
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.Size = new System.Drawing.Size(346, 48);
            this.PasswordTextbox.TabIndex = 2;
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoRoundedCorners = true;
            this.SubmitButton.BackColor = System.Drawing.Color.Transparent;
            this.SubmitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(496, 346);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(180, 45);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(514, 39);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(162, 69);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "LOGIN";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // forgotpasswordLink
            // 
            this.forgotpasswordLink.AutoSize = true;
            this.forgotpasswordLink.LinkColor = System.Drawing.Color.SteelBlue;
            this.forgotpasswordLink.Location = new System.Drawing.Point(434, 286);
            this.forgotpasswordLink.Name = "forgotpasswordLink";
            this.forgotpasswordLink.Size = new System.Drawing.Size(109, 16);
            this.forgotpasswordLink.TabIndex = 5;
            this.forgotpasswordLink.TabStop = true;
            this.forgotpasswordLink.Text = "Forgot Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forgotpasswordLink);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.intro_panel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.intro_panel_login.ResumeLayout(false);
            this.intro_panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel intro_panel_login;
        private System.Windows.Forms.PictureBox logo;
        private Guna.UI2.WinForms.Guna2TextBox EmailTextbox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel welcome;
        private Guna.UI2.WinForms.Guna2Button SubmitButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel welcome_2;
        private System.Windows.Forms.LinkLabel forgotpasswordLink;
    }
}