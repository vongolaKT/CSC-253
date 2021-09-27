
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
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayFirstNameLabel = new System.Windows.Forms.Label();
            this.displayLastNameLabel = new System.Windows.Forms.Label();
            this.displayAgeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(25, 156);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 36);
            this.previousButton.TabIndex = 0;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(293, 156);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 36);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(162, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // displayFirstNameLabel
            // 
            this.displayFirstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayFirstNameLabel.Location = new System.Drawing.Point(12, 94);
            this.displayFirstNameLabel.Name = "displayFirstNameLabel";
            this.displayFirstNameLabel.Size = new System.Drawing.Size(102, 19);
            this.displayFirstNameLabel.TabIndex = 6;
            // 
            // displayLastNameLabel
            // 
            this.displayLastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLastNameLabel.Location = new System.Drawing.Point(148, 94);
            this.displayLastNameLabel.Name = "displayLastNameLabel";
            this.displayLastNameLabel.Size = new System.Drawing.Size(99, 19);
            this.displayLastNameLabel.TabIndex = 7;
            // 
            // displayAgeLabel
            // 
            this.displayAgeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayAgeLabel.Location = new System.Drawing.Point(279, 94);
            this.displayAgeLabel.Name = "displayAgeLabel";
            this.displayAgeLabel.Size = new System.Drawing.Size(97, 19);
            this.displayAgeLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 259);
            this.Controls.Add(this.displayAgeLabel);
            this.Controls.Add(this.displayLastNameLabel);
            this.Controls.Add(this.displayFirstNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Name = "Form1";
            this.Text = "Read Class Info From File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label displayFirstNameLabel;
        private System.Windows.Forms.Label displayLastNameLabel;
        private System.Windows.Forms.Label displayAgeLabel;
    }
}

