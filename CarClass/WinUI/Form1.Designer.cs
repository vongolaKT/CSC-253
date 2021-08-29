
namespace WinUI
{
    partial class CarForm
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
            this.createCarButton = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.accelerateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showMakeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.showSpeedLabel = new System.Windows.Forms.Label();
            this.showYearLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.showModelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createCarButton
            // 
            this.createCarButton.Location = new System.Drawing.Point(58, 359);
            this.createCarButton.Name = "createCarButton";
            this.createCarButton.Size = new System.Drawing.Size(97, 48);
            this.createCarButton.TabIndex = 0;
            this.createCarButton.Text = "Add Car";
            this.createCarButton.UseVisualStyleBackColor = true;
            this.createCarButton.Click += new System.EventHandler(this.createCarButton_Click);
            // 
            // brakeButton
            // 
            this.brakeButton.Location = new System.Drawing.Point(240, 359);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(94, 48);
            this.brakeButton.TabIndex = 1;
            this.brakeButton.Text = "Brake";
            this.brakeButton.UseVisualStyleBackColor = true;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // accelerateButton
            // 
            this.accelerateButton.Location = new System.Drawing.Point(415, 359);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(94, 48);
            this.accelerateButton.TabIndex = 2;
            this.accelerateButton.Text = "Accelerate";
            this.accelerateButton.UseVisualStyleBackColor = true;
            this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(611, 359);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 48);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Make: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Car: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Make: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Year: ";
            // 
            // showMakeLabel
            // 
            this.showMakeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showMakeLabel.Location = new System.Drawing.Point(538, 91);
            this.showMakeLabel.Name = "showMakeLabel";
            this.showMakeLabel.Size = new System.Drawing.Size(91, 26);
            this.showMakeLabel.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Current Speed: ";
            // 
            // showSpeedLabel
            // 
            this.showSpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showSpeedLabel.Location = new System.Drawing.Point(538, 239);
            this.showSpeedLabel.Name = "showSpeedLabel";
            this.showSpeedLabel.Size = new System.Drawing.Size(91, 40);
            this.showSpeedLabel.TabIndex = 13;
            // 
            // showYearLabel
            // 
            this.showYearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showYearLabel.Location = new System.Drawing.Point(538, 182);
            this.showYearLabel.Name = "showYearLabel";
            this.showYearLabel.Size = new System.Drawing.Size(91, 26);
            this.showYearLabel.TabIndex = 14;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(134, 104);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 15;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(134, 232);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 16;
            // 
            // showModelLabel
            // 
            this.showModelLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showModelLabel.Location = new System.Drawing.Point(538, 139);
            this.showModelLabel.Name = "showModelLabel";
            this.showModelLabel.Size = new System.Drawing.Size(91, 26);
            this.showModelLabel.TabIndex = 17;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(134, 164);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Model: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Model: ";
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 433);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.showModelLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.showYearLabel);
            this.Controls.Add(this.showSpeedLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.showMakeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.accelerateButton);
            this.Controls.Add(this.brakeButton);
            this.Controls.Add(this.createCarButton);
            this.Name = "CarForm";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createCarButton;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label showMakeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label showSpeedLabel;
        private System.Windows.Forms.Label showYearLabel;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label showModelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

