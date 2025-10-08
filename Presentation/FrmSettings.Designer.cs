namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class FrmSettings
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
            this.FrmSettingsLabel = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmSettingsLabel
            // 
            this.FrmSettingsLabel.AutoSize = true;
            this.FrmSettingsLabel.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmSettingsLabel.ForeColor = System.Drawing.Color.White;
            this.FrmSettingsLabel.Location = new System.Drawing.Point(288, 196);
            this.FrmSettingsLabel.Name = "FrmSettingsLabel";
            this.FrmSettingsLabel.Size = new System.Drawing.Size(339, 50);
            this.FrmSettingsLabel.TabIndex = 2;
            this.FrmSettingsLabel.Text = "Your Settings here";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.settings_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz241;
            this.pictureBox7.Location = new System.Drawing.Point(250, 249);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(454, 263);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.FrmSettingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSettings";
            this.Text = "FrmSettings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label FrmSettingsLabel;
    }
}