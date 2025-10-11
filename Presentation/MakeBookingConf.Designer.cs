namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class MakeBookingConf
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
            this.el1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDNotFoundLabel = new System.Windows.Forms.Label();
            this.exitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.el1.SuspendLayout();
            this.SuspendLayout();
            // 
            // el1
            // 
            this.el1.Controls.Add(this.exitButton);
            this.el1.Controls.Add(this.IDNumberTextBox);
            this.el1.Controls.Add(this.IDNotFoundLabel);
            this.el1.Controls.Add(this.IDLabel);
            this.el1.Controls.Add(this.guna2Button1);
            this.el1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.el1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.el1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.el1.Location = new System.Drawing.Point(0, 0);
            this.el1.Name = "el1";
            this.el1.Size = new System.Drawing.Size(588, 234);
            this.el1.TabIndex = 0;
            this.el1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Nirmala Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(419, 105);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(138, 48);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Next";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.White;
            this.IDLabel.Location = new System.Drawing.Point(12, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(290, 46);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "Enter ID Number";
            this.IDLabel.Click += new System.EventHandler(this.IDLabel_Click);
            // 
            // IDNumberTextBox
            // 
            this.IDNumberTextBox.Animated = true;
            this.IDNumberTextBox.AutoRoundedCorners = true;
            this.IDNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.IDNumberTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.IDNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDNumberTextBox.DefaultText = "";
            this.IDNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.IDNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDNumberTextBox.Location = new System.Drawing.Point(20, 105);
            this.IDNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDNumberTextBox.Name = "IDNumberTextBox";
            this.IDNumberTextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.IDNumberTextBox.PlaceholderText = "";
            this.IDNumberTextBox.SelectedText = "";
            this.IDNumberTextBox.Size = new System.Drawing.Size(335, 48);
            this.IDNumberTextBox.TabIndex = 2;
            this.IDNumberTextBox.TextChanged += new System.EventHandler(this.IDNumberTextBox_TextChanged);
            // 
            // IDNotFoundLabel
            // 
            this.IDNotFoundLabel.AutoSize = true;
            this.IDNotFoundLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDNotFoundLabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDNotFoundLabel.ForeColor = System.Drawing.Color.Red;
            this.IDNotFoundLabel.Location = new System.Drawing.Point(17, 166);
            this.IDNotFoundLabel.Name = "IDNotFoundLabel";
            this.IDNotFoundLabel.Size = new System.Drawing.Size(146, 17);
            this.IDNotFoundLabel.TabIndex = 1;
            this.IDNotFoundLabel.Text = "ID Number Not Found";
            this.IDNotFoundLabel.Click += new System.EventHandler(this.IDNotFoundLabel_Click);
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
            this.exitButton.Location = new System.Drawing.Point(513, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitButton.Size = new System.Drawing.Size(75, 49);
            this.exitButton.TabIndex = 16;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MakeBookingConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 234);
            this.Controls.Add(this.el1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakeBookingConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeBookingConf";
            this.el1.ResumeLayout(false);
            this.el1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel el1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox IDNumberTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label IDNotFoundLabel;
        private Guna.UI2.WinForms.Guna2CircleButton exitButton;
    }
}