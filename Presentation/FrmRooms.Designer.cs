namespace Phumla_Kamnandi_GRP_12.Presentation
{
    partial class FrmRooms
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
            this.FrmRoomsLabel = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmRoomsLabel
            // 
            this.FrmRoomsLabel.AutoSize = true;
            this.FrmRoomsLabel.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmRoomsLabel.ForeColor = System.Drawing.Color.White;
            this.FrmRoomsLabel.Location = new System.Drawing.Point(288, 196);
            this.FrmRoomsLabel.Name = "FrmRoomsLabel";
            this.FrmRoomsLabel.Size = new System.Drawing.Size(317, 50);
            this.FrmRoomsLabel.TabIndex = 2;
            this.FrmRoomsLabel.Text = "Your Rooms here";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Phumla_Kamnandi_GRP_12.Properties.Resources.hotel_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.pictureBox6.Location = new System.Drawing.Point(250, 249);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(454, 263);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // FrmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.FrmRoomsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRooms";
            this.Text = "FrmRooms";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label FrmRoomsLabel;
    }
}