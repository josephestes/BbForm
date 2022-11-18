namespace Joseph.Estes.Ch12.You.Do.It
{
    partial class BreakfastOptionForm
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
            this.breakfastOptionDescription = new System.Windows.Forms.Label();
            this.contRadioButton = new System.Windows.Forms.RadioButton();
            this.fullRadioButton = new System.Windows.Forms.RadioButton();
            this.deluxeRadioButton = new System.Windows.Forms.RadioButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // breakfastOptionDescription
            // 
            this.breakfastOptionDescription.AutoSize = true;
            this.breakfastOptionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.breakfastOptionDescription.Location = new System.Drawing.Point(150, 100);
            this.breakfastOptionDescription.Name = "breakfastOptionDescription";
            this.breakfastOptionDescription.Size = new System.Drawing.Size(240, 24);
            this.breakfastOptionDescription.TabIndex = 0;
            this.breakfastOptionDescription.Text = "Select your breakfast option";
            // 
            // contRadioButton
            // 
            this.contRadioButton.AutoSize = true;
            this.contRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contRadioButton.Location = new System.Drawing.Point(200, 150);
            this.contRadioButton.Name = "contRadioButton";
            this.contRadioButton.Size = new System.Drawing.Size(122, 28);
            this.contRadioButton.TabIndex = 1;
            this.contRadioButton.TabStop = true;
            this.contRadioButton.Text = "Continental";
            this.contRadioButton.UseVisualStyleBackColor = true;
            this.contRadioButton.CheckedChanged += new System.EventHandler(this.contRadioButton_CheckedChanged);
            // 
            // fullRadioButton
            // 
            this.fullRadioButton.AutoSize = true;
            this.fullRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullRadioButton.Location = new System.Drawing.Point(200, 184);
            this.fullRadioButton.Name = "fullRadioButton";
            this.fullRadioButton.Size = new System.Drawing.Size(59, 28);
            this.fullRadioButton.TabIndex = 2;
            this.fullRadioButton.TabStop = true;
            this.fullRadioButton.Text = "Full";
            this.fullRadioButton.UseVisualStyleBackColor = true;
            this.fullRadioButton.CheckedChanged += new System.EventHandler(this.fullRadioButton_CheckedChanged);
            // 
            // deluxeRadioButton
            // 
            this.deluxeRadioButton.AutoSize = true;
            this.deluxeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deluxeRadioButton.Location = new System.Drawing.Point(200, 218);
            this.deluxeRadioButton.Name = "deluxeRadioButton";
            this.deluxeRadioButton.Size = new System.Drawing.Size(88, 28);
            this.deluxeRadioButton.TabIndex = 3;
            this.deluxeRadioButton.TabStop = true;
            this.deluxeRadioButton.Text = "Deluxe";
            this.deluxeRadioButton.UseVisualStyleBackColor = true;
            this.deluxeRadioButton.CheckedChanged += new System.EventHandler(this.deluxeRadioButton_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(250, 300);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(73, 25);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price:";
            // 
            // BreakfastOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.deluxeRadioButton);
            this.Controls.Add(this.fullRadioButton);
            this.Controls.Add(this.contRadioButton);
            this.Controls.Add(this.breakfastOptionDescription);
            this.Name = "BreakfastOptionForm";
            this.Text = "BreakfastOptionForm";
            this.Load += new System.EventHandler(this.BreakfastOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label breakfastOptionDescription;
        private System.Windows.Forms.RadioButton contRadioButton;
        private System.Windows.Forms.RadioButton fullRadioButton;
        private System.Windows.Forms.RadioButton deluxeRadioButton;
        private System.Windows.Forms.Label priceLabel;
    }
}