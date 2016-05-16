namespace changecounter
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.fiftyCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.twentyFiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.tenCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.fiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(122, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(108, 16);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Click the coins";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(397, 196);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(31, 13);
            this.outputDescriptionLabel.TabIndex = 1;
            this.outputDescriptionLabel.Text = "Total";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(364, 245);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(150, 456);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fiftyCentsPictureBox
            // 
            this.fiftyCentsPictureBox.Image = global::changecounter.Properties.Resources._50cents;
            this.fiftyCentsPictureBox.Location = new System.Drawing.Point(196, 245);
            this.fiftyCentsPictureBox.Name = "fiftyCentsPictureBox";
            this.fiftyCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.fiftyCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fiftyCentsPictureBox.TabIndex = 6;
            this.fiftyCentsPictureBox.TabStop = false;
            this.fiftyCentsPictureBox.Click += new System.EventHandler(this.fiftyCentsPictureBox_Click);
            // 
            // twentyFiveCentsPictureBox
            // 
            this.twentyFiveCentsPictureBox.Image = global::changecounter.Properties.Resources._25cents;
            this.twentyFiveCentsPictureBox.Location = new System.Drawing.Point(12, 245);
            this.twentyFiveCentsPictureBox.Name = "twentyFiveCentsPictureBox";
            this.twentyFiveCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.twentyFiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.twentyFiveCentsPictureBox.TabIndex = 5;
            this.twentyFiveCentsPictureBox.TabStop = false;
            this.twentyFiveCentsPictureBox.Click += new System.EventHandler(this.twentyFiveCentsPictureBox_Click);
            // 
            // tenCentsPictureBox
            // 
            this.tenCentsPictureBox.Image = global::changecounter.Properties.Resources._10cents;
            this.tenCentsPictureBox.Location = new System.Drawing.Point(196, 28);
            this.tenCentsPictureBox.Name = "tenCentsPictureBox";
            this.tenCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.tenCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tenCentsPictureBox.TabIndex = 4;
            this.tenCentsPictureBox.TabStop = false;
            this.tenCentsPictureBox.Click += new System.EventHandler(this.tenCentsPictureBox_Click);
            // 
            // fiveCentsPictureBox
            // 
            this.fiveCentsPictureBox.Image = global::changecounter.Properties.Resources._5cents;
            this.fiveCentsPictureBox.Location = new System.Drawing.Point(12, 28);
            this.fiveCentsPictureBox.Name = "fiveCentsPictureBox";
            this.fiveCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.fiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fiveCentsPictureBox.TabIndex = 3;
            this.fiveCentsPictureBox.TabStop = false;
            this.fiveCentsPictureBox.Click += new System.EventHandler(this.fiveCentsPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 491);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fiftyCentsPictureBox);
            this.Controls.Add(this.twentyFiveCentsPictureBox);
            this.Controls.Add(this.tenCentsPictureBox);
            this.Controls.Add(this.fiveCentsPictureBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.PictureBox fiveCentsPictureBox;
        private System.Windows.Forms.PictureBox tenCentsPictureBox;
        private System.Windows.Forms.PictureBox twentyFiveCentsPictureBox;
        private System.Windows.Forms.PictureBox fiftyCentsPictureBox;
        private System.Windows.Forms.Button exitButton;
    }
}

