namespace CoinToss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.headPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tossButton
            // 
            this.tossButton.Location = new System.Drawing.Point(12, 198);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(75, 23);
            this.tossButton.TabIndex = 2;
            this.tossButton.Text = "Toss";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(107, 198);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = global::CoinToss.Properties.Resources.Tails1;
            this.tailsPictureBox.Location = new System.Drawing.Point(12, 13);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            // 
            // headPictureBox
            // 
            this.headPictureBox.Image = global::CoinToss.Properties.Resources.Heads1;
            this.headPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("headPictureBox.InitialImage")));
            this.headPictureBox.Location = new System.Drawing.Point(12, 12);
            this.headPictureBox.Name = "headPictureBox";
            this.headPictureBox.Size = new System.Drawing.Size(170, 170);
            this.headPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headPictureBox.TabIndex = 0;
            this.headPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.tailsPictureBox);
            this.Controls.Add(this.headPictureBox);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
    }
}

