namespace Joseph.Estes.Ch12.You.Do.It
{
    partial class CastleGatehouseForm
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
            this.castleGatehouseDescriptionLabel = new System.Windows.Forms.Label();
            this.castleGatehousePriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // castleGatehouseDescriptionLabel
            // 
            this.castleGatehouseDescriptionLabel.AutoSize = true;
            this.castleGatehouseDescriptionLabel.Location = new System.Drawing.Point(200, 100);
            this.castleGatehouseDescriptionLabel.Name = "castleGatehouseDescriptionLabel";
            this.castleGatehouseDescriptionLabel.Size = new System.Drawing.Size(256, 30);
            this.castleGatehouseDescriptionLabel.TabIndex = 0;
            this.castleGatehouseDescriptionLabel.Text = "The Castle Gatehouse Suite has two bedrooms, \r\ntwo baths and a private balcony.";
            // 
            // castleGatehousePriceLabel
            // 
            this.castleGatehousePriceLabel.AutoSize = true;
            this.castleGatehousePriceLabel.Location = new System.Drawing.Point(250, 200);
            this.castleGatehousePriceLabel.Name = "castleGatehousePriceLabel";
            this.castleGatehousePriceLabel.Size = new System.Drawing.Size(85, 15);
            this.castleGatehousePriceLabel.TabIndex = 1;
            this.castleGatehousePriceLabel.Text = "$297 per night.";
            // 
            // CastleGatehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.castleGatehousePriceLabel);
            this.Controls.Add(this.castleGatehouseDescriptionLabel);
            this.Name = "CastleGatehouseForm";
            this.Text = "CastleGatehouseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label castleGatehouseDescriptionLabel;
        private System.Windows.Forms.Label castleGatehousePriceLabel;
    }
}