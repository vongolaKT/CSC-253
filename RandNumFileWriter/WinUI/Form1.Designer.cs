
namespace WinUI
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
            this.writeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberInputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(12, 161);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(75, 33);
            this.writeButton.TabIndex = 0;
            this.writeButton.Text = "Write!";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(134, 161);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 33);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(255, 161);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 33);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the amount of random numbers to write (integers only) : ";
            // 
            // numberInputTextBox
            // 
            this.numberInputTextBox.Location = new System.Drawing.Point(144, 84);
            this.numberInputTextBox.Name = "numberInputTextBox";
            this.numberInputTextBox.Size = new System.Drawing.Size(54, 20);
            this.numberInputTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 205);
            this.Controls.Add(this.numberInputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.writeButton);
            this.Name = "Form1";
            this.Text = "Random Number File Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberInputTextBox;
    }
}

