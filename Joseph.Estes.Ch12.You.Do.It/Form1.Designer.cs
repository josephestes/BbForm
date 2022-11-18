namespace Joseph.Estes.Ch12.You.Do.It
{
    partial class JosephsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.castleGatehouseCheckBox = new System.Windows.Forms.CheckBox();
            this.hallHouseCheckBox = new System.Windows.Forms.CheckBox();
            this.mealButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(150, 150);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(261, 29);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Joseph\'s";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rateLabel.Location = new System.Drawing.Point(200, 250);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(164, 25);
            this.rateLabel.TabIndex = 1;
            this.rateLabel.Text = "Check our rates";
            // 
            // castleGatehouseCheckBox
            // 
            this.castleGatehouseCheckBox.AutoSize = true;
            this.castleGatehouseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.castleGatehouseCheckBox.Location = new System.Drawing.Point(200, 300);
            this.castleGatehouseCheckBox.Name = "castleGatehouseCheckBox";
            this.castleGatehouseCheckBox.Size = new System.Drawing.Size(246, 28);
            this.castleGatehouseCheckBox.TabIndex = 2;
            this.castleGatehouseCheckBox.Text = "Castle Gatehouse Suite";
            this.castleGatehouseCheckBox.UseVisualStyleBackColor = true;
            this.castleGatehouseCheckBox.CheckedChanged += new System.EventHandler(this.CastleGatehouseCheckBox_CheckedChanged);
            // 
            // hallHouseCheckBox
            // 
            this.hallHouseCheckBox.AutoSize = true;
            this.hallHouseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hallHouseCheckBox.Location = new System.Drawing.Point(200, 350);
            this.hallHouseCheckBox.Name = "hallHouseCheckBox";
            this.hallHouseCheckBox.Size = new System.Drawing.Size(193, 28);
            this.hallHouseCheckBox.TabIndex = 3;
            this.hallHouseCheckBox.Text = "Hall House Room";
            this.hallHouseCheckBox.UseVisualStyleBackColor = true;
            this.hallHouseCheckBox.CheckedChanged += new System.EventHandler(this.HallHouseCheckBox_CheckedChanged);
            // 
            // mealButton
            // 
            this.mealButton.Location = new System.Drawing.Point(200, 400);
            this.mealButton.Name = "mealButton";
            this.mealButton.Size = new System.Drawing.Size(134, 23);
            this.mealButton.TabIndex = 4;
            this.mealButton.Text = "Click for meal options";
            this.mealButton.UseVisualStyleBackColor = true;
            this.mealButton.Click += new System.EventHandler(this.MealButton_Click);
            // 
            // JosephsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.mealButton);
            this.Controls.Add(this.hallHouseCheckBox);
            this.Controls.Add(this.castleGatehouseCheckBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "JosephsForm";
            this.Text = "Joseph’s Bed and Breakfast";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.CheckBox castleGatehouseCheckBox;
        private System.Windows.Forms.CheckBox hallHouseCheckBox;
        private System.Windows.Forms.Button mealButton;
    }
}
