namespace Disntace_Converter
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
            this.promptDistanceLabel = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.outputDescripLabel = new System.Windows.Forms.Label();
            this.convertedDistanceLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.toGoupBox = new System.Windows.Forms.GroupBox();
            this.fromGroupBox.SuspendLayout();
            this.toGoupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptDistanceLabel
            // 
            this.promptDistanceLabel.AutoSize = true;
            this.promptDistanceLabel.Location = new System.Drawing.Point(25, 52);
            this.promptDistanceLabel.Name = "promptDistanceLabel";
            this.promptDistanceLabel.Size = new System.Drawing.Size(138, 13);
            this.promptDistanceLabel.TabIndex = 0;
            this.promptDistanceLabel.Text = "Enter a distance to convert:";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(199, 52);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 1;
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(21, 20);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(76, 43);
            this.fromListBox.TabIndex = 2;
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(6, 20);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(76, 43);
            this.toListBox.TabIndex = 3;
            
            // 
            // outputDescripLabel
            // 
            this.outputDescripLabel.AutoSize = true;
            this.outputDescripLabel.Location = new System.Drawing.Point(40, 197);
            this.outputDescripLabel.Name = "outputDescripLabel";
            this.outputDescripLabel.Size = new System.Drawing.Size(101, 13);
            this.outputDescripLabel.TabIndex = 4;
            this.outputDescripLabel.Text = "Converted Distance";
            this.outputDescripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // convertedDistanceLabel
            // 
            this.convertedDistanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedDistanceLabel.Location = new System.Drawing.Point(179, 187);
            this.convertedDistanceLabel.Name = "convertedDistanceLabel";
            this.convertedDistanceLabel.Size = new System.Drawing.Size(120, 23);
            this.convertedDistanceLabel.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(66, 259);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(179, 259);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.Controls.Add(this.fromListBox);
            this.fromGroupBox.Location = new System.Drawing.Point(22, 87);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(118, 80);
            this.fromGroupBox.TabIndex = 8;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "From:";
            // 
            // toGoupBox
            // 
            this.toGoupBox.Controls.Add(this.toListBox);
            this.toGoupBox.Location = new System.Drawing.Point(179, 87);
            this.toGoupBox.Name = "toGoupBox";
            this.toGoupBox.Size = new System.Drawing.Size(114, 79);
            this.toGoupBox.TabIndex = 9;
            this.toGoupBox.TabStop = false;
            this.toGoupBox.Text = "To:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 301);
            this.Controls.Add(this.toGoupBox);
            this.Controls.Add(this.fromGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertedDistanceLabel);
            this.Controls.Add(this.outputDescripLabel);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.promptDistanceLabel);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.fromGroupBox.ResumeLayout(false);
            this.toGoupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptDistanceLabel;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.Label outputDescripLabel;
        private System.Windows.Forms.Label convertedDistanceLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.GroupBox toGoupBox;
    }
}

