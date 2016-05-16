namespace Stadium_Seating
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
            this.classAInputLabel = new System.Windows.Forms.Label();
            this.classBInputLabel = new System.Windows.Forms.Label();
            this.classCInputLabel = new System.Windows.Forms.Label();
            this.inputClassATextBox = new System.Windows.Forms.TextBox();
            this.inputClassBTextBox = new System.Windows.Forms.TextBox();
            this.inputClassCTextBox = new System.Windows.Forms.TextBox();
            this.ticketSoldGroupBox = new System.Windows.Forms.GroupBox();
            this.classAOutputLabelDescrip = new System.Windows.Forms.Label();
            this.classBOutputLabelDescrip = new System.Windows.Forms.Label();
            this.classCOutputLabelDescrip = new System.Windows.Forms.Label();
            this.classAOutputLabel = new System.Windows.Forms.Label();
            this.classBOutputLabel = new System.Windows.Forms.Label();
            this.classCOutputLabel = new System.Windows.Forms.Label();
            this.totalLabelDescrip = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.revenueGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketSoldGroupBox.SuspendLayout();
            this.revenueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // classAInputLabel
            // 
            this.classAInputLabel.AutoSize = true;
            this.classAInputLabel.Location = new System.Drawing.Point(39, 31);
            this.classAInputLabel.Name = "classAInputLabel";
            this.classAInputLabel.Size = new System.Drawing.Size(42, 13);
            this.classAInputLabel.TabIndex = 0;
            this.classAInputLabel.Text = "Class A";
            // 
            // classBInputLabel
            // 
            this.classBInputLabel.AutoSize = true;
            this.classBInputLabel.Location = new System.Drawing.Point(39, 73);
            this.classBInputLabel.Name = "classBInputLabel";
            this.classBInputLabel.Size = new System.Drawing.Size(42, 13);
            this.classBInputLabel.TabIndex = 2;
            this.classBInputLabel.Text = "Class B";
            // 
            // classCInputLabel
            // 
            this.classCInputLabel.AutoSize = true;
            this.classCInputLabel.Location = new System.Drawing.Point(39, 114);
            this.classCInputLabel.Name = "classCInputLabel";
            this.classCInputLabel.Size = new System.Drawing.Size(42, 13);
            this.classCInputLabel.TabIndex = 4;
            this.classCInputLabel.Text = "Class C";
            // 
            // inputClassATextBox
            // 
            this.inputClassATextBox.Location = new System.Drawing.Point(118, 31);
            this.inputClassATextBox.Name = "inputClassATextBox";
            this.inputClassATextBox.Size = new System.Drawing.Size(100, 20);
            this.inputClassATextBox.TabIndex = 1;
            // 
            // inputClassBTextBox
            // 
            this.inputClassBTextBox.Location = new System.Drawing.Point(118, 66);
            this.inputClassBTextBox.Name = "inputClassBTextBox";
            this.inputClassBTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputClassBTextBox.TabIndex = 3;
            // 
            // inputClassCTextBox
            // 
            this.inputClassCTextBox.Location = new System.Drawing.Point(118, 107);
            this.inputClassCTextBox.Name = "inputClassCTextBox";
            this.inputClassCTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputClassCTextBox.TabIndex = 5;
            // 
            // ticketSoldGroupBox
            // 
            this.ticketSoldGroupBox.Controls.Add(this.inputClassCTextBox);
            this.ticketSoldGroupBox.Controls.Add(this.inputClassBTextBox);
            this.ticketSoldGroupBox.Controls.Add(this.inputClassATextBox);
            this.ticketSoldGroupBox.Controls.Add(this.classCInputLabel);
            this.ticketSoldGroupBox.Controls.Add(this.classBInputLabel);
            this.ticketSoldGroupBox.Controls.Add(this.classAInputLabel);
            this.ticketSoldGroupBox.Location = new System.Drawing.Point(56, 63);
            this.ticketSoldGroupBox.Name = "ticketSoldGroupBox";
            this.ticketSoldGroupBox.Size = new System.Drawing.Size(246, 210);
            this.ticketSoldGroupBox.TabIndex = 0;
            this.ticketSoldGroupBox.TabStop = false;
            this.ticketSoldGroupBox.Text = "Tickets Sold";
            // 
            // classAOutputLabelDescrip
            // 
            this.classAOutputLabelDescrip.AutoSize = true;
            this.classAOutputLabelDescrip.Location = new System.Drawing.Point(19, 29);
            this.classAOutputLabelDescrip.Name = "classAOutputLabelDescrip";
            this.classAOutputLabelDescrip.Size = new System.Drawing.Size(42, 13);
            this.classAOutputLabelDescrip.TabIndex = 7;
            this.classAOutputLabelDescrip.Text = "Class A";
            this.classAOutputLabelDescrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // classBOutputLabelDescrip
            // 
            this.classBOutputLabelDescrip.AutoSize = true;
            this.classBOutputLabelDescrip.Location = new System.Drawing.Point(19, 64);
            this.classBOutputLabelDescrip.Name = "classBOutputLabelDescrip";
            this.classBOutputLabelDescrip.Size = new System.Drawing.Size(42, 13);
            this.classBOutputLabelDescrip.TabIndex = 8;
            this.classBOutputLabelDescrip.Text = "Class B";
            this.classBOutputLabelDescrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // classCOutputLabelDescrip
            // 
            this.classCOutputLabelDescrip.AutoSize = true;
            this.classCOutputLabelDescrip.Location = new System.Drawing.Point(19, 105);
            this.classCOutputLabelDescrip.Name = "classCOutputLabelDescrip";
            this.classCOutputLabelDescrip.Size = new System.Drawing.Size(42, 13);
            this.classCOutputLabelDescrip.TabIndex = 9;
            this.classCOutputLabelDescrip.Text = "Class C";
            this.classCOutputLabelDescrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // classAOutputLabel
            // 
            this.classAOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classAOutputLabel.Location = new System.Drawing.Point(93, 29);
            this.classAOutputLabel.Name = "classAOutputLabel";
            this.classAOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.classAOutputLabel.TabIndex = 10;
            this.classAOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classBOutputLabel
            // 
            this.classBOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBOutputLabel.Location = new System.Drawing.Point(93, 64);
            this.classBOutputLabel.Name = "classBOutputLabel";
            this.classBOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.classBOutputLabel.TabIndex = 11;
            this.classBOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classCOutputLabel
            // 
            this.classCOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCOutputLabel.Location = new System.Drawing.Point(93, 105);
            this.classCOutputLabel.Name = "classCOutputLabel";
            this.classCOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.classCOutputLabel.TabIndex = 12;
            this.classCOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabelDescrip
            // 
            this.totalLabelDescrip.AutoSize = true;
            this.totalLabelDescrip.Location = new System.Drawing.Point(19, 149);
            this.totalLabelDescrip.Name = "totalLabelDescrip";
            this.totalLabelDescrip.Size = new System.Drawing.Size(31, 13);
            this.totalLabelDescrip.TabIndex = 13;
            this.totalLabelDescrip.Text = "Total";
            this.totalLabelDescrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutputLabel.Location = new System.Drawing.Point(93, 139);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalOutputLabel.TabIndex = 14;
            this.totalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revenueGroupBox
            // 
            this.revenueGroupBox.Controls.Add(this.totalOutputLabel);
            this.revenueGroupBox.Controls.Add(this.totalLabelDescrip);
            this.revenueGroupBox.Controls.Add(this.classCOutputLabel);
            this.revenueGroupBox.Controls.Add(this.classBOutputLabel);
            this.revenueGroupBox.Controls.Add(this.classAOutputLabel);
            this.revenueGroupBox.Controls.Add(this.classCOutputLabelDescrip);
            this.revenueGroupBox.Controls.Add(this.classBOutputLabelDescrip);
            this.revenueGroupBox.Controls.Add(this.classAOutputLabelDescrip);
            this.revenueGroupBox.Location = new System.Drawing.Point(378, 63);
            this.revenueGroupBox.Name = "revenueGroupBox";
            this.revenueGroupBox.Size = new System.Drawing.Size(228, 210);
            this.revenueGroupBox.TabIndex = 1;
            this.revenueGroupBox.TabStop = false;
            this.revenueGroupBox.Text = "Revenue Generated";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(162, 300);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 43);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(282, 300);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 43);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(412, 300);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 43);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(650, 355);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.revenueGroupBox);
            this.Controls.Add(this.ticketSoldGroupBox);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ticketSoldGroupBox.ResumeLayout(false);
            this.ticketSoldGroupBox.PerformLayout();
            this.revenueGroupBox.ResumeLayout(false);
            this.revenueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label classAInputLabel;
        private System.Windows.Forms.Label classBInputLabel;
        private System.Windows.Forms.Label classCInputLabel;
        private System.Windows.Forms.TextBox inputClassATextBox;
        private System.Windows.Forms.TextBox inputClassBTextBox;
        private System.Windows.Forms.TextBox inputClassCTextBox;
        private System.Windows.Forms.GroupBox ticketSoldGroupBox;
        private System.Windows.Forms.Label classAOutputLabelDescrip;
        private System.Windows.Forms.Label classBOutputLabelDescrip;
        private System.Windows.Forms.Label classCOutputLabelDescrip;
        private System.Windows.Forms.Label classAOutputLabel;
        private System.Windows.Forms.Label classBOutputLabel;
        private System.Windows.Forms.Label classCOutputLabel;
        private System.Windows.Forms.Label totalLabelDescrip;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.GroupBox revenueGroupBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

