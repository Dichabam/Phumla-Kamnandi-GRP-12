namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class FrmBookings
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
            this.FrmBookLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmBookLabel
            // 
            this.FrmBookLabel.AutoSize = true;
            this.FrmBookLabel.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmBookLabel.ForeColor = System.Drawing.Color.White;
            this.FrmBookLabel.Location = new System.Drawing.Point(298, 151);
            this.FrmBookLabel.Name = "FrmBookLabel";
            this.FrmBookLabel.Size = new System.Drawing.Size(361, 50);
            this.FrmBookLabel.TabIndex = 0;
            this.FrmBookLabel.Text = "Your Bookings here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.event_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz241;
            this.pictureBox1.Location = new System.Drawing.Point(260, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FrmBookLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBookings";
            this.Text = "FrmBookings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FrmBookLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}