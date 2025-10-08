namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class AdminCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCode));
            this.logo = new System.Windows.Forms.PictureBox();
            this.SidePanelFP = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.IncorrectLabel = new System.Windows.Forms.Label();
            this.CloseButtonAdmC = new Guna.UI2.WinForms.Guna2Button();
            this.SubmitButtonFP = new Guna.UI2.WinForms.Guna2Button();
            this.CodeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.EnterAdminCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SidePanelFP.SuspendLayout();
            this.SuspendLayout();
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
            // SidePanelFP
            // 
            this.SidePanelFP.BackColor = System.Drawing.Color.Transparent;
            this.SidePanelFP.Controls.Add(this.IncorrectLabel);
            this.SidePanelFP.Controls.Add(this.CloseButtonAdmC);
            this.SidePanelFP.Controls.Add(this.SubmitButtonFP);
            this.SidePanelFP.Controls.Add(this.CodeTextBox);
            this.SidePanelFP.Controls.Add(this.EnterAdminCodeLabel);
            this.SidePanelFP.Controls.Add(this.logo);
            this.SidePanelFP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidePanelFP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SidePanelFP.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.SidePanelFP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SidePanelFP.Location = new System.Drawing.Point(0, 0);
            this.SidePanelFP.Name = "SidePanelFP";
            this.SidePanelFP.Size = new System.Drawing.Size(800, 450);
            this.SidePanelFP.TabIndex = 8;
            // 
            // IncorrectLabel
            // 
            this.IncorrectLabel.AutoSize = true;
            this.IncorrectLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.IncorrectLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectLabel.Location = new System.Drawing.Point(454, 132);
            this.IncorrectLabel.Name = "IncorrectLabel";
            this.IncorrectLabel.Size = new System.Drawing.Size(118, 16);
            this.IncorrectLabel.TabIndex = 12;
            this.IncorrectLabel.Text = "Code is Incorrect";
            // 
            // CloseButtonAdmC
            // 
            this.CloseButtonAdmC.Animated = true;
            this.CloseButtonAdmC.AutoRoundedCorners = true;
            this.CloseButtonAdmC.BorderColor = System.Drawing.Color.Transparent;
            this.CloseButtonAdmC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseButtonAdmC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseButtonAdmC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseButtonAdmC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseButtonAdmC.FillColor = System.Drawing.Color.Transparent;
            this.CloseButtonAdmC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButtonAdmC.ForeColor = System.Drawing.Color.White;
            this.CloseButtonAdmC.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.CloseButtonAdmC.Location = new System.Drawing.Point(743, 3);
            this.CloseButtonAdmC.Name = "CloseButtonAdmC";
            this.CloseButtonAdmC.Size = new System.Drawing.Size(57, 30);
            this.CloseButtonAdmC.TabIndex = 11;
            this.CloseButtonAdmC.UseTransparentBackground = true;
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
            // CodeTextBox
            // 
            this.CodeTextBox.Animated = true;
            this.CodeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CodeTextBox.BorderRadius = 15;
            this.CodeTextBox.BorderThickness = 2;
            this.CodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeTextBox.DefaultText = "";
            this.CodeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CodeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CodeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CodeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CodeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CodeTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.CodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CodeTextBox.Location = new System.Drawing.Point(345, 166);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.PlaceholderText = "";
            this.CodeTextBox.SelectedText = "";
            this.CodeTextBox.Size = new System.Drawing.Size(357, 48);
            this.CodeTextBox.TabIndex = 9;
            // 
            // EnterAdminCodeLabel
            // 
            this.EnterAdminCodeLabel.AutoSize = true;
            this.EnterAdminCodeLabel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.EnterAdminCodeLabel.ForeColor = System.Drawing.Color.White;
            this.EnterAdminCodeLabel.Location = new System.Drawing.Point(375, 75);
            this.EnterAdminCodeLabel.Name = "EnterAdminCodeLabel";
            this.EnterAdminCodeLabel.Size = new System.Drawing.Size(318, 40);
            this.EnterAdminCodeLabel.TabIndex = 8;
            this.EnterAdminCodeLabel.Text = "Enter Admin Code";
            // 
            // AdminCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SidePanelFP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCode";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.SidePanelFP.ResumeLayout(false);
            this.SidePanelFP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private Guna.UI2.WinForms.Guna2GradientPanel SidePanelFP;
        private System.Windows.Forms.Label IncorrectLabel;
        private Guna.UI2.WinForms.Guna2Button CloseButtonAdmC;
        private Guna.UI2.WinForms.Guna2Button SubmitButtonFP;
        private Guna.UI2.WinForms.Guna2TextBox CodeTextBox;
        private System.Windows.Forms.Label EnterAdminCodeLabel;
    }
}