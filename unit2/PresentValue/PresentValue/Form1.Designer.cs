namespace PresentValue
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
            this.numOfYearsLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.futureAmount = new System.Windows.Forms.Label();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.desiredTextBox = new System.Windows.Forms.TextBox();
            this.outputDescripLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numOfYearsLabel
            // 
            this.numOfYearsLabel.AutoSize = true;
            this.numOfYearsLabel.Location = new System.Drawing.Point(8, 39);
            this.numOfYearsLabel.Name = "numOfYearsLabel";
            this.numOfYearsLabel.Size = new System.Drawing.Size(89, 13);
            this.numOfYearsLabel.TabIndex = 0;
            this.numOfYearsLabel.Text = "Number of Years:";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(29, 83);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(68, 13);
            this.interestRateLabel.TabIndex = 1;
            this.interestRateLabel.Text = "Interest Rate";
            // 
            // futureAmount
            // 
            this.futureAmount.AutoSize = true;
            this.futureAmount.Location = new System.Drawing.Point(21, 130);
            this.futureAmount.Name = "futureAmount";
            this.futureAmount.Size = new System.Drawing.Size(76, 13);
            this.futureAmount.TabIndex = 2;
            this.futureAmount.Text = "Future Amount";
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(143, 39);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearsTextBox.TabIndex = 3;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(143, 83);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 20);
            this.rateTextBox.TabIndex = 4;
            // 
            // desiredTextBox
            // 
            this.desiredTextBox.Location = new System.Drawing.Point(143, 130);
            this.desiredTextBox.Name = "desiredTextBox";
            this.desiredTextBox.Size = new System.Drawing.Size(100, 20);
            this.desiredTextBox.TabIndex = 5;
            // 
            // outputDescripLabel
            // 
            this.outputDescripLabel.AutoSize = true;
            this.outputDescripLabel.Location = new System.Drawing.Point(3, 211);
            this.outputDescripLabel.Name = "outputDescripLabel";
            this.outputDescripLabel.Size = new System.Drawing.Size(94, 13);
            this.outputDescripLabel.TabIndex = 6;
            this.outputDescripLabel.Text = "Amount to Deposit";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(143, 201);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 23);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(32, 281);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(143, 281);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(246, 281);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 362);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputDescripLabel);
            this.Controls.Add(this.desiredTextBox);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.futureAmount);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.numOfYearsLabel);
            this.Name = "Form1";
            this.Text = "Present Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOfYearsLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label futureAmount;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox desiredTextBox;
        private System.Windows.Forms.Label outputDescripLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

