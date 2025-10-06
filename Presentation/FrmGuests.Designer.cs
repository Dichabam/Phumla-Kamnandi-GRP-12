namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class FrmGuests
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
            this.FrmGuestsLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmGuestsLabel
            // 
            this.FrmGuestsLabel.AutoSize = true;
            this.FrmGuestsLabel.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmGuestsLabel.ForeColor = System.Drawing.Color.White;
            this.FrmGuestsLabel.Location = new System.Drawing.Point(355, 196);
            this.FrmGuestsLabel.Name = "FrmGuestsLabel";
            this.FrmGuestsLabel.Size = new System.Drawing.Size(318, 50);
            this.FrmGuestsLabel.TabIndex = 4;
            this.FrmGuestsLabel.Text = "Your Guests Here";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.person_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz241;
            this.pictureBox3.Location = new System.Drawing.Point(250, 249);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(454, 263);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // FrmGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.FrmGuestsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGuests";
            this.Text = "FrmGuests";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label FrmGuestsLabel;
    }
}