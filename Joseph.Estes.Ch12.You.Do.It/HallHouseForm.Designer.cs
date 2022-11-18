namespace Joseph.Estes.Ch12.You.Do.It
{
    partial class HallHouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HallHouseForm));
            this.hallHouseDescription = new System.Windows.Forms.Label();
            this.hallHousePriceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hallHouseDescription
            // 
            this.hallHouseDescription.AutoSize = true;
            this.hallHouseDescription.Location = new System.Drawing.Point(200, 100);
            this.hallHouseDescription.Name = "hallHouseDescription";
            this.hallHouseDescription.Size = new System.Drawing.Size(180, 30);
            this.hallHouseDescription.TabIndex = 0;
            this.hallHouseDescription.Text = "Explore the 11th century in this\r\nunique room with a private bath.";
            // 
            // hallHousePriceLabel
            // 
            this.hallHousePriceLabel.AutoSize = true;
            this.hallHousePriceLabel.Location = new System.Drawing.Point(300, 150);
            this.hallHousePriceLabel.Name = "hallHousePriceLabel";
            this.hallHousePriceLabel.Size = new System.Drawing.Size(85, 15);
            this.hallHousePriceLabel.TabIndex = 1;
            this.hallHousePriceLabel.Text = "$197 per night.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // HallHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hallHousePriceLabel);
            this.Controls.Add(this.hallHouseDescription);
            this.Name = "HallHouseForm";
            this.Text = "Hall House Room";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hallHouseDescription;
        private System.Windows.Forms.Label hallHousePriceLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}