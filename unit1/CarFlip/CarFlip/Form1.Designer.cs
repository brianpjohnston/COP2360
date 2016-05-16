namespace CarFlip
{
    partial class Form1
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
            this.showBackButton = new System.Windows.Forms.Button();
            this.showFaceButton = new System.Windows.Forms.Button();
            this.cardFacePictureBox = new System.Windows.Forms.PictureBox();
            this.cardBackPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showBackButton
            // 
            this.showBackButton.Location = new System.Drawing.Point(41, 179);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(75, 44);
            this.showBackButton.TabIndex = 0;
            this.showBackButton.Text = "Show the Card Back";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // showFaceButton
            // 
            this.showFaceButton.Location = new System.Drawing.Point(167, 179);
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Size = new System.Drawing.Size(75, 44);
            this.showFaceButton.TabIndex = 1;
            this.showFaceButton.Text = "Show the Card Face";
            this.showFaceButton.UseVisualStyleBackColor = true;
            this.showFaceButton.Click += new System.EventHandler(this.showFaceButton_Click);
            // 
            // cardFacePictureBox
            // 
            this.cardFacePictureBox.Image = global::CarFlip.Properties.Resources.Ace_Spades;
            this.cardFacePictureBox.Location = new System.Drawing.Point(154, 35);
            this.cardFacePictureBox.Name = "cardFacePictureBox";
            this.cardFacePictureBox.Size = new System.Drawing.Size(100, 140);
            this.cardFacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFacePictureBox.TabIndex = 3;
            this.cardFacePictureBox.TabStop = false;
            this.cardFacePictureBox.Visible = false;
            // 
            // cardBackPictureBox
            // 
            this.cardBackPictureBox.Image = global::CarFlip.Properties.Resources.Backface_Blue;
            this.cardBackPictureBox.Location = new System.Drawing.Point(31, 35);
            this.cardBackPictureBox.Name = "cardBackPictureBox";
            this.cardBackPictureBox.Size = new System.Drawing.Size(100, 140);
            this.cardBackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardBackPictureBox.TabIndex = 2;
            this.cardBackPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cardFacePictureBox);
            this.Controls.Add(this.cardBackPictureBox);
            this.Controls.Add(this.showFaceButton);
            this.Controls.Add(this.showBackButton);
            this.Name = "Form1";
            this.Text = "Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFaceButton;
        private System.Windows.Forms.PictureBox cardBackPictureBox;
        private System.Windows.Forms.PictureBox cardFacePictureBox;
    }
}

