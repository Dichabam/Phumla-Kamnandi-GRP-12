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
            this.SidePanelFP = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ForgotLabel = new System.Windows.Forms.Label();
            this.EmailTextboxFP = new Guna.UI2.WinForms.Guna2TextBox();
            this.SubmitButtonFP = new Guna.UI2.WinForms.Guna2Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.SidePanelFP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanelFP
            // 
            this.SidePanelFP.BackColor = System.Drawing.Color.Transparent;
            this.SidePanelFP.Controls.Add(this.SubmitButtonFP);
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
            // 
            // SubmitButtonFP
            // 
            this.SubmitButtonFP.Animated = true;
            this.SubmitButtonFP.AutoRoundedCorners = true;
            this.SubmitButtonFP.BackColor = System.Drawing.Color.Transparent;
            this.SubmitButtonFP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubmitButtonFP.BorderThickness = 2;
            this.SubmitButtonFP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButtonFP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButtonFP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitButtonFP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitButtonFP.FillColor = System.Drawing.Color.Transparent;
            this.SubmitButtonFP.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.SubmitButtonFP.ForeColor = System.Drawing.Color.White;
            this.SubmitButtonFP.Location = new System.Drawing.Point(425, 272);
            this.SubmitButtonFP.Name = "SubmitButtonFP";
            this.SubmitButtonFP.Size = new System.Drawing.Size(180, 45);
            this.SubmitButtonFP.TabIndex = 10;
            this.SubmitButtonFP.Text = "SUBMIT";
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
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SidePanelFP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private Guna.UI2.WinForms.Guna2Button SubmitButtonFP;
    }
}