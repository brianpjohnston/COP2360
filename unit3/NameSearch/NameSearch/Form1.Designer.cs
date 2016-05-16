namespace NameSearch
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
            this.boyNamePrompt = new System.Windows.Forms.Label();
            this.girlNamePrompt = new System.Windows.Forms.Label();
            this.boyTextBox = new System.Windows.Forms.TextBox();
            this.girlTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boyNamePrompt
            // 
            this.boyNamePrompt.AutoSize = true;
            this.boyNamePrompt.Location = new System.Drawing.Point(12, 42);
            this.boyNamePrompt.Name = "boyNamePrompt";
            this.boyNamePrompt.Size = new System.Drawing.Size(100, 13);
            this.boyNamePrompt.TabIndex = 0;
            this.boyNamePrompt.Text = "Enter a boy\'s name:";
            // 
            // girlNamePrompt
            // 
            this.girlNamePrompt.AutoSize = true;
            this.girlNamePrompt.Location = new System.Drawing.Point(12, 82);
            this.girlNamePrompt.Name = "girlNamePrompt";
            this.girlNamePrompt.Size = new System.Drawing.Size(97, 13);
            this.girlNamePrompt.TabIndex = 1;
            this.girlNamePrompt.Text = "Enter a girls name: ";
            // 
            // boyTextBox
            // 
            this.boyTextBox.Location = new System.Drawing.Point(176, 42);
            this.boyTextBox.Name = "boyTextBox";
            this.boyTextBox.Size = new System.Drawing.Size(100, 20);
            this.boyTextBox.TabIndex = 6;
            // 
            // girlTextBox
            // 
            this.girlTextBox.Location = new System.Drawing.Point(176, 82);
            this.girlTextBox.Name = "girlTextBox";
            this.girlTextBox.Size = new System.Drawing.Size(100, 20);
            this.girlTextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(34, 156);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(142, 156);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(245, 156);
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
            this.ClientSize = new System.Drawing.Size(406, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.girlTextBox);
            this.Controls.Add(this.boyTextBox);
            this.Controls.Add(this.girlNamePrompt);
            this.Controls.Add(this.boyNamePrompt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label boyNamePrompt;
        private System.Windows.Forms.Label girlNamePrompt;
        private System.Windows.Forms.TextBox boyTextBox;
        private System.Windows.Forms.TextBox girlTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

