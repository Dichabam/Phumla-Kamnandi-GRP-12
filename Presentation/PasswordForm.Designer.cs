using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class PasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.SidePanelPass = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.viewConfirmPasswordButton = new Guna.UI2.WinForms.Guna2Button();
            this.viewNewPasswordButton = new Guna.UI2.WinForms.Guna2Button();
            this.SucessLabelPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.justLabel = new System.Windows.Forms.Label();
            this.CloseButtonPass = new Guna.UI2.WinForms.Guna2Button();
            this.NextButtonPass = new Guna.UI2.WinForms.Guna2Button();
            this.ConfirmPasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NewPasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.VerifyPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.SidePanelPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanelPass
            // 
            this.SidePanelPass.BackColor = System.Drawing.Color.Transparent;
            this.SidePanelPass.Controls.Add(this.viewConfirmPasswordButton);
            this.SidePanelPass.Controls.Add(this.viewNewPasswordButton);
            this.SidePanelPass.Controls.Add(this.SucessLabelPass);
            this.SidePanelPass.Controls.Add(this.label1);
            this.SidePanelPass.Controls.Add(this.justLabel);
            this.SidePanelPass.Controls.Add(this.CloseButtonPass);
            this.SidePanelPass.Controls.Add(this.NextButtonPass);
            this.SidePanelPass.Controls.Add(this.ConfirmPasswordTextbox);
            this.SidePanelPass.Controls.Add(this.NewPasswordTextbox);
            this.SidePanelPass.Controls.Add(this.VerifyPasswordLabel);
            this.SidePanelPass.Controls.Add(this.NewPasswordLabel);
            this.SidePanelPass.Controls.Add(this.logo);
            this.SidePanelPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidePanelPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SidePanelPass.FillColor2 = System.Drawing.Color.MediumPurple;
            this.SidePanelPass.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.SidePanelPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SidePanelPass.Location = new System.Drawing.Point(0, 0);
            this.SidePanelPass.Name = "SidePanelPass";
            this.SidePanelPass.Size = new System.Drawing.Size(642, 803);
            this.SidePanelPass.TabIndex = 9;
            this.SidePanelPass.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanelPass_Paint);
            // 
            // viewConfirmPasswordButton
            // 
            this.viewConfirmPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.viewConfirmPasswordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewConfirmPasswordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewConfirmPasswordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewConfirmPasswordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewConfirmPasswordButton.FillColor = System.Drawing.Color.White;
            this.viewConfirmPasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewConfirmPasswordButton.ForeColor = System.Drawing.Color.White;
            this.viewConfirmPasswordButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.visibility_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            this.viewConfirmPasswordButton.Location = new System.Drawing.Point(546, 523);
            this.viewConfirmPasswordButton.Name = "viewConfirmPasswordButton";
            this.viewConfirmPasswordButton.Size = new System.Drawing.Size(56, 30);
            this.viewConfirmPasswordButton.TabIndex = 17;
            this.viewConfirmPasswordButton.Click += new System.EventHandler(this.viewConfirmPasswordButton_Click);
            // 
            // viewNewPasswordButton
            // 
            this.viewNewPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.viewNewPasswordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewNewPasswordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewNewPasswordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewNewPasswordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewNewPasswordButton.FillColor = System.Drawing.Color.White;
            this.viewNewPasswordButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewNewPasswordButton.ForeColor = System.Drawing.Color.White;
            this.viewNewPasswordButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.visibility_50dp_000000_FILL0_wght400_GRAD0_opsz48;
            this.viewNewPasswordButton.Location = new System.Drawing.Point(546, 314);
            this.viewNewPasswordButton.Name = "viewNewPasswordButton";
            this.viewNewPasswordButton.Size = new System.Drawing.Size(56, 30);
            this.viewNewPasswordButton.TabIndex = 16;
            this.viewNewPasswordButton.Click += new System.EventHandler(this.viewNewPasswordButton_Click);
            // 
            // SucessLabelPass
            // 
            this.SucessLabelPass.AutoSize = true;
            this.SucessLabelPass.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SucessLabelPass.ForeColor = System.Drawing.Color.Lime;
            this.SucessLabelPass.Location = new System.Drawing.Point(179, 191);
            this.SucessLabelPass.Name = "SucessLabelPass";
            this.SucessLabelPass.Size = new System.Drawing.Size(298, 28);
            this.SucessLabelPass.TabIndex = 15;
            this.SucessLabelPass.Text = "Password Created successfully";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 779);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phumla Kamnandi Hotel Grout Pty(Ltd)";
            // 
            // justLabel
            // 
            this.justLabel.AutoSize = true;
            this.justLabel.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.justLabel.ForeColor = System.Drawing.Color.White;
            this.justLabel.Location = new System.Drawing.Point(219, 826);
            this.justLabel.Name = "justLabel";
            this.justLabel.Size = new System.Drawing.Size(203, 15);
            this.justLabel.TabIndex = 13;
            this.justLabel.Text = "Phumla Kamnandi Hotel Grout Pty(Ltd)";
            // 
            // CloseButtonPass
            // 
            this.CloseButtonPass.Animated = true;
            this.CloseButtonPass.AutoRoundedCorners = true;
            this.CloseButtonPass.BorderColor = System.Drawing.Color.Transparent;
            this.CloseButtonPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseButtonPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseButtonPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseButtonPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseButtonPass.FillColor = System.Drawing.Color.Transparent;
            this.CloseButtonPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButtonPass.ForeColor = System.Drawing.Color.White;
            this.CloseButtonPass.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.CloseButtonPass.Location = new System.Drawing.Point(585, 0);
            this.CloseButtonPass.Name = "CloseButtonPass";
            this.CloseButtonPass.Size = new System.Drawing.Size(57, 30);
            this.CloseButtonPass.TabIndex = 12;
            this.CloseButtonPass.UseTransparentBackground = true;
            // 
            // NextButtonPass
            // 
            this.NextButtonPass.Animated = true;
            this.NextButtonPass.AutoRoundedCorners = true;
            this.NextButtonPass.BackColor = System.Drawing.Color.Transparent;
            this.NextButtonPass.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.NextButtonPass.BorderThickness = 2;
            this.NextButtonPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NextButtonPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NextButtonPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NextButtonPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NextButtonPass.FillColor = System.Drawing.Color.Transparent;
            this.NextButtonPass.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.NextButtonPass.ForeColor = System.Drawing.Color.White;
            this.NextButtonPass.Location = new System.Drawing.Point(222, 643);
            this.NextButtonPass.Name = "NextButtonPass";
            this.NextButtonPass.Size = new System.Drawing.Size(180, 45);
            this.NextButtonPass.TabIndex = 10;
            this.NextButtonPass.Text = "NEXT";
            // 
            // ConfirmPasswordTextbox
            // 
            this.ConfirmPasswordTextbox.Animated = true;
            this.ConfirmPasswordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ConfirmPasswordTextbox.BorderRadius = 15;
            this.ConfirmPasswordTextbox.BorderThickness = 2;
            this.ConfirmPasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmPasswordTextbox.DefaultText = "";
            this.ConfirmPasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmPasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmPasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmPasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPasswordTextbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ConfirmPasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmPasswordTextbox.Location = new System.Drawing.Point(49, 514);
            this.ConfirmPasswordTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmPasswordTextbox.Name = "ConfirmPasswordTextbox";
            this.ConfirmPasswordTextbox.PlaceholderText = "";
            this.ConfirmPasswordTextbox.SelectedText = "";
            this.ConfirmPasswordTextbox.Size = new System.Drawing.Size(566, 48);
            this.ConfirmPasswordTextbox.TabIndex = 9;
            this.ConfirmPasswordTextbox.TextChanged += new System.EventHandler(this.EmailTextboxPass_TextChanged);
            // 
            // NewPasswordTextbox
            // 
            this.NewPasswordTextbox.Animated = true;
            this.NewPasswordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.NewPasswordTextbox.BorderRadius = 15;
            this.NewPasswordTextbox.BorderThickness = 2;
            this.NewPasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPasswordTextbox.DefaultText = "";
            this.NewPasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewPasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewPasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPasswordTextbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.NewPasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPasswordTextbox.Location = new System.Drawing.Point(49, 305);
            this.NewPasswordTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewPasswordTextbox.Name = "NewPasswordTextbox";
            this.NewPasswordTextbox.PlaceholderText = "";
            this.NewPasswordTextbox.SelectedText = "";
            this.NewPasswordTextbox.Size = new System.Drawing.Size(566, 48);
            this.NewPasswordTextbox.TabIndex = 9;
            // 
            // VerifyPasswordLabel
            // 
            this.VerifyPasswordLabel.AutoSize = true;
            this.VerifyPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.VerifyPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.VerifyPasswordLabel.Location = new System.Drawing.Point(41, 433);
            this.VerifyPasswordLabel.Name = "VerifyPasswordLabel";
            this.VerifyPasswordLabel.Size = new System.Drawing.Size(455, 59);
            this.VerifyPasswordLabel.TabIndex = 8;
            this.VerifyPasswordLabel.Text = "Confirm Password";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.NewPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.NewPasswordLabel.Location = new System.Drawing.Point(41, 230);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(374, 59);
            this.NewPasswordLabel.TabIndex = 8;
            this.NewPasswordLabel.Text = "New Password";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.PHUMLA_KAMNANDI_Photoroom;
            this.logo.Location = new System.Drawing.Point(222, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(217, 172);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 803);
            this.Controls.Add(this.SidePanelPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordForm";
            this.SidePanelPass.ResumeLayout(false);
            this.SidePanelPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel SidePanelPass;
        private System.Windows.Forms.Label justLabel;
        private Guna.UI2.WinForms.Guna2Button CloseButtonPass;
        private Guna.UI2.WinForms.Guna2Button NextButtonPass;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmPasswordTextbox;
        private Guna.UI2.WinForms.Guna2TextBox NewPasswordTextbox;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label VerifyPasswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SucessLabelPass;
        private Guna.UI2.WinForms.Guna2Button viewConfirmPasswordButton;
        private Guna.UI2.WinForms.Guna2Button viewNewPasswordButton;
    }
}