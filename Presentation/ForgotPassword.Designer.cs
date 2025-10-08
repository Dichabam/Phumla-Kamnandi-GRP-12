namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.SidePanelFP = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ErrorEmailLabel = new System.Windows.Forms.Label();
            this.NextButtonFP = new Guna.UI2.WinForms.Guna2Button();
            this.EmailTextboxFP = new Guna.UI2.WinForms.Guna2TextBox();
            this.ForgotLabel = new System.Windows.Forms.Label();
            this.CloseButtonFP = new Guna.UI2.WinForms.Guna2Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.SidePanelFP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanelFP
            // 
            this.SidePanelFP.BackColor = System.Drawing.Color.Transparent;
            this.SidePanelFP.Controls.Add(this.ErrorEmailLabel);
            this.SidePanelFP.Controls.Add(this.CloseButtonFP);
            this.SidePanelFP.Controls.Add(this.NextButtonFP);
            this.SidePanelFP.Controls.Add(this.EmailTextboxFP);
            this.SidePanelFP.Controls.Add(this.ForgotLabel);
            this.SidePanelFP.Controls.Add(this.logo);
            this.SidePanelFP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidePanelFP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SidePanelFP.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.SidePanelFP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SidePanelFP.Location = new System.Drawing.Point(0, 0);
            this.SidePanelFP.Name = "SidePanelFP";
            this.SidePanelFP.Size = new System.Drawing.Size(800, 450);
            this.SidePanelFP.TabIndex = 7;
            this.SidePanelFP.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanelFP_Paint);
            // 
            // ErrorEmailLabel
            // 
            this.ErrorEmailLabel.AutoSize = true;
            this.ErrorEmailLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.ErrorEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorEmailLabel.Location = new System.Drawing.Point(454, 132);
            this.ErrorEmailLabel.Name = "ErrorEmailLabel";
            this.ErrorEmailLabel.Size = new System.Drawing.Size(135, 16);
            this.ErrorEmailLabel.TabIndex = 12;
            this.ErrorEmailLabel.Text = "Email does not exist";
            this.ErrorEmailLabel.Click += new System.EventHandler(this.ErrorEmailLabel_Click);
            // 
            // NextButtonFP
            // 
            this.NextButtonFP.Animated = true;
            this.NextButtonFP.AutoRoundedCorners = true;
            this.NextButtonFP.BackColor = System.Drawing.Color.Transparent;
            this.NextButtonFP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NextButtonFP.BorderThickness = 2;
            this.NextButtonFP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NextButtonFP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NextButtonFP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NextButtonFP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NextButtonFP.FillColor = System.Drawing.Color.Transparent;
            this.NextButtonFP.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.NextButtonFP.ForeColor = System.Drawing.Color.White;
            this.NextButtonFP.Location = new System.Drawing.Point(425, 272);
            this.NextButtonFP.Name = "NextButtonFP";
            this.NextButtonFP.Size = new System.Drawing.Size(180, 45);
            this.NextButtonFP.TabIndex = 10;
            this.NextButtonFP.Text = "NEXT";
            this.NextButtonFP.Click += new System.EventHandler(this.SubmitButtonFP_Click_1);
            // 
            // EmailTextboxFP
            // 
            this.EmailTextboxFP.Animated = true;
            this.EmailTextboxFP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.EmailTextboxFP.BorderRadius = 15;
            this.EmailTextboxFP.BorderThickness = 2;
            this.EmailTextboxFP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextboxFP.DefaultText = "";
            this.EmailTextboxFP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextboxFP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextboxFP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextboxFP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextboxFP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextboxFP.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.EmailTextboxFP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextboxFP.Location = new System.Drawing.Point(345, 166);
            this.EmailTextboxFP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTextboxFP.Name = "EmailTextboxFP";
            this.EmailTextboxFP.PlaceholderText = "Email";
            this.EmailTextboxFP.SelectedText = "";
            this.EmailTextboxFP.Size = new System.Drawing.Size(357, 48);
            this.EmailTextboxFP.TabIndex = 9;
            this.EmailTextboxFP.TextChanged += new System.EventHandler(this.EmailTextboxFP_TextChanged);
            // 
            // ForgotLabel
            // 
            this.ForgotLabel.AutoSize = true;
            this.ForgotLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.ForgotLabel.ForeColor = System.Drawing.Color.White;
            this.ForgotLabel.Location = new System.Drawing.Point(338, 72);
            this.ForgotLabel.Name = "ForgotLabel";
            this.ForgotLabel.Size = new System.Drawing.Size(367, 40);
            this.ForgotLabel.TabIndex = 8;
            this.ForgotLabel.Text = "FORGOT PASSWORD?";
            this.ForgotLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // CloseButtonFP
            // 
            this.CloseButtonFP.Animated = true;
            this.CloseButtonFP.AutoRoundedCorners = true;
            this.CloseButtonFP.BorderColor = System.Drawing.Color.Transparent;
            this.CloseButtonFP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseButtonFP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseButtonFP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseButtonFP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseButtonFP.FillColor = System.Drawing.Color.Transparent;
            this.CloseButtonFP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButtonFP.ForeColor = System.Drawing.Color.White;
            this.CloseButtonFP.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.CloseButtonFP.Location = new System.Drawing.Point(743, 3);
            this.CloseButtonFP.Name = "CloseButtonFP";
            this.CloseButtonFP.Size = new System.Drawing.Size(57, 30);
            this.CloseButtonFP.TabIndex = 11;
            this.CloseButtonFP.UseTransparentBackground = true;
            this.CloseButtonFP.Click += new System.EventHandler(this.CloseButtonFP_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.PHUMLA_KAMNANDI_Photoroom;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(332, 450);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SidePanelFP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.SidePanelFP.ResumeLayout(false);
            this.SidePanelFP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel SidePanelFP;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label ForgotLabel;
        private Guna.UI2.WinForms.Guna2TextBox EmailTextboxFP;
        private Guna.UI2.WinForms.Guna2Button NextButtonFP;
        private Guna.UI2.WinForms.Guna2Button CloseButtonFP;
        private System.Windows.Forms.Label ErrorEmailLabel;
    }
}