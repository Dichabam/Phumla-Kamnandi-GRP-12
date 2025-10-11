namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class NewExistGuest
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
            this.exPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.exitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ExistingguestBut = new Guna.UI2.WinForms.Guna2Button();
            this.NewGuestBut = new Guna.UI2.WinForms.Guna2Button();
            this.exPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exPanel
            // 
            this.exPanel.Controls.Add(this.exitButton);
            this.exPanel.Controls.Add(this.ExistingguestBut);
            this.exPanel.Controls.Add(this.NewGuestBut);
            this.exPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
            this.exPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(150)))));
            this.exPanel.Location = new System.Drawing.Point(0, 0);
            this.exPanel.Name = "exPanel";
            this.exPanel.Size = new System.Drawing.Size(570, 187);
            this.exPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Animated = true;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BorderColor = System.Drawing.Color.White;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.DarkGray;
            this.exitButton.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.exitButton.Location = new System.Drawing.Point(495, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitButton.Size = new System.Drawing.Size(75, 49);
            this.exitButton.TabIndex = 16;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ExistingguestBut
            // 
            this.ExistingguestBut.Animated = true;
            this.ExistingguestBut.AutoRoundedCorners = true;
            this.ExistingguestBut.BackColor = System.Drawing.Color.Transparent;
            this.ExistingguestBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExistingguestBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExistingguestBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExistingguestBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExistingguestBut.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.ExistingguestBut.ForeColor = System.Drawing.Color.White;
            this.ExistingguestBut.Location = new System.Drawing.Point(311, 79);
            this.ExistingguestBut.Name = "ExistingguestBut";
            this.ExistingguestBut.Size = new System.Drawing.Size(163, 48);
            this.ExistingguestBut.TabIndex = 0;
            this.ExistingguestBut.Text = "Existing Guest";
            this.ExistingguestBut.UseTransparentBackground = true;
            // 
            // NewGuestBut
            // 
            this.NewGuestBut.Animated = true;
            this.NewGuestBut.AutoRoundedCorners = true;
            this.NewGuestBut.BackColor = System.Drawing.Color.Transparent;
            this.NewGuestBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NewGuestBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NewGuestBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NewGuestBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NewGuestBut.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.NewGuestBut.ForeColor = System.Drawing.Color.White;
            this.NewGuestBut.Location = new System.Drawing.Point(81, 79);
            this.NewGuestBut.Name = "NewGuestBut";
            this.NewGuestBut.Size = new System.Drawing.Size(163, 48);
            this.NewGuestBut.TabIndex = 0;
            this.NewGuestBut.Text = "New Guest";
            this.NewGuestBut.UseTransparentBackground = true;
            // 
            // NewExistGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 187);
            this.Controls.Add(this.exPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewExistGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewExistGuest";
            this.exPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel exPanel;
        private Guna.UI2.WinForms.Guna2Button NewGuestBut;
        private Guna.UI2.WinForms.Guna2CircleButton exitButton;
        private Guna.UI2.WinForms.Guna2Button ExistingguestBut;
    }
}