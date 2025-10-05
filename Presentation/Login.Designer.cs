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
            this.logo = new System.Windows.Forms.PictureBox();
            this.Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.welcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.welcome_2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.forgotpassword = new System.Windows.Forms.LinkLabel();
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
            this.intro_panel_login.Size = new System.Drawing.Size(401, 452);
            this.intro_panel_login.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(97, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(194, 173);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Email
            // 
            this.Email.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.Email.BorderRadius = 15;
            this.Email.BorderThickness = 2;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.DefaultText = "Email";
            this.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.Location = new System.Drawing.Point(426, 150);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email.Name = "Email";
            this.Email.PlaceholderText = "";
            this.Email.SelectedText = "";
            this.Email.Size = new System.Drawing.Size(346, 48);
            this.Email.TabIndex = 1;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Password
            // 
            this.Password.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.Password.BorderRadius = 15;
            this.Password.BorderThickness = 2;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "Password";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Location = new System.Drawing.Point(426, 234);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password.Name = "Password";
            this.Password.PlaceholderText = "";
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(346, 48);
            this.Password.TabIndex = 2;
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Segoe UI Semibold", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.Control;
            this.welcome.Location = new System.Drawing.Point(68, 191);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(260, 91);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Let\'s Get ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(496, 345);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "SUBMIT";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(514, 40);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(162, 69);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "LOGIN";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // welcome_2
            // 
            this.welcome_2.BackColor = System.Drawing.Color.Transparent;
            this.welcome_2.Font = new System.Drawing.Font("Segoe UI Black", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_2.ForeColor = System.Drawing.SystemColors.Control;
            this.welcome_2.Location = new System.Drawing.Point(26, 269);
            this.welcome_2.Name = "welcome_2";
            this.welcome_2.Size = new System.Drawing.Size(355, 91);
            this.welcome_2.TabIndex = 2;
            this.welcome_2.Text = "STARTED !";
            // 
            // forgotpassword
            // 
            this.forgotpassword.AutoSize = true;
            this.forgotpassword.LinkColor = System.Drawing.Color.SteelBlue;
            this.forgotpassword.Location = new System.Drawing.Point(434, 286);
            this.forgotpassword.Name = "forgotpassword";
            this.forgotpassword.Size = new System.Drawing.Size(109, 16);
            this.forgotpassword.TabIndex = 5;
            this.forgotpassword.TabStop = true;
            this.forgotpassword.Text = "Forgot Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forgotpassword);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
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
        private Guna.UI2.WinForms.Guna2TextBox Email;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2HtmlLabel welcome;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel welcome_2;
        private System.Windows.Forms.LinkLabel forgotpassword;
    }
}