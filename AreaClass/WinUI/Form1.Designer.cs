
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.circleCalcButton = new System.Windows.Forms.Button();
            this.rectangleCalcButton = new System.Windows.Forms.Button();
            this.cylinderCalcButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.circleRadiusTextBox = new System.Windows.Forms.TextBox();
            this.cylinderRadiusTextBox = new System.Windows.Forms.TextBox();
            this.cylinderHeightTextBox = new System.Windows.Forms.TextBox();
            this.rectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.rectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.circleDisplayLabel = new System.Windows.Forms.Label();
            this.rectangleDisplayLabel = new System.Windows.Forms.Label();
            this.cylinderDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Circle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rectangle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cylinder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Radius: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Length: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Width: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Radius: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Height: ";
            // 
            // circleCalcButton
            // 
            this.circleCalcButton.Location = new System.Drawing.Point(83, 241);
            this.circleCalcButton.Name = "circleCalcButton";
            this.circleCalcButton.Size = new System.Drawing.Size(75, 39);
            this.circleCalcButton.TabIndex = 8;
            this.circleCalcButton.Text = "Calculate Area";
            this.circleCalcButton.UseVisualStyleBackColor = true;
            this.circleCalcButton.Click += new System.EventHandler(this.circleCalcButton_Click);
            // 
            // rectangleCalcButton
            // 
            this.rectangleCalcButton.Location = new System.Drawing.Point(351, 241);
            this.rectangleCalcButton.Name = "rectangleCalcButton";
            this.rectangleCalcButton.Size = new System.Drawing.Size(75, 39);
            this.rectangleCalcButton.TabIndex = 9;
            this.rectangleCalcButton.Text = "Calculate Area";
            this.rectangleCalcButton.UseVisualStyleBackColor = true;
            this.rectangleCalcButton.Click += new System.EventHandler(this.rectangleCalcButton_Click);
            // 
            // cylinderCalcButton
            // 
            this.cylinderCalcButton.Location = new System.Drawing.Point(628, 241);
            this.cylinderCalcButton.Name = "cylinderCalcButton";
            this.cylinderCalcButton.Size = new System.Drawing.Size(75, 39);
            this.cylinderCalcButton.TabIndex = 10;
            this.cylinderCalcButton.Text = "Calculate Area";
            this.cylinderCalcButton.UseVisualStyleBackColor = true;
            this.cylinderCalcButton.Click += new System.EventHandler(this.cylinderCalcButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Width: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Width: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(572, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Width: ";
            // 
            // circleRadiusTextBox
            // 
            this.circleRadiusTextBox.Location = new System.Drawing.Point(83, 111);
            this.circleRadiusTextBox.Name = "circleRadiusTextBox";
            this.circleRadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.circleRadiusTextBox.TabIndex = 14;
            // 
            // cylinderRadiusTextBox
            // 
            this.cylinderRadiusTextBox.Location = new System.Drawing.Point(619, 111);
            this.cylinderRadiusTextBox.Name = "cylinderRadiusTextBox";
            this.cylinderRadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.cylinderRadiusTextBox.TabIndex = 15;
            // 
            // cylinderHeightTextBox
            // 
            this.cylinderHeightTextBox.Location = new System.Drawing.Point(619, 162);
            this.cylinderHeightTextBox.Name = "cylinderHeightTextBox";
            this.cylinderHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.cylinderHeightTextBox.TabIndex = 16;
            // 
            // rectangleWidthTextBox
            // 
            this.rectangleWidthTextBox.Location = new System.Drawing.Point(343, 162);
            this.rectangleWidthTextBox.Name = "rectangleWidthTextBox";
            this.rectangleWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectangleWidthTextBox.TabIndex = 17;
            // 
            // rectangleLengthTextBox
            // 
            this.rectangleLengthTextBox.Location = new System.Drawing.Point(343, 111);
            this.rectangleLengthTextBox.Name = "rectangleLengthTextBox";
            this.rectangleLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectangleLengthTextBox.TabIndex = 18;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(179, 374);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 39);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(496, 374);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // circleDisplayLabel
            // 
            this.circleDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.circleDisplayLabel.Location = new System.Drawing.Point(83, 324);
            this.circleDisplayLabel.Name = "circleDisplayLabel";
            this.circleDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.circleDisplayLabel.TabIndex = 21;
            // 
            // rectangleDisplayLabel
            // 
            this.rectangleDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rectangleDisplayLabel.Location = new System.Drawing.Point(343, 324);
            this.rectangleDisplayLabel.Name = "rectangleDisplayLabel";
            this.rectangleDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.rectangleDisplayLabel.TabIndex = 22;
            // 
            // cylinderDisplayLabel
            // 
            this.cylinderDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cylinderDisplayLabel.Location = new System.Drawing.Point(619, 324);
            this.cylinderDisplayLabel.Name = "cylinderDisplayLabel";
            this.cylinderDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.cylinderDisplayLabel.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cylinderDisplayLabel);
            this.Controls.Add(this.rectangleDisplayLabel);
            this.Controls.Add(this.circleDisplayLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.rectangleLengthTextBox);
            this.Controls.Add(this.rectangleWidthTextBox);
            this.Controls.Add(this.cylinderHeightTextBox);
            this.Controls.Add(this.cylinderRadiusTextBox);
            this.Controls.Add(this.circleRadiusTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cylinderCalcButton);
            this.Controls.Add(this.rectangleCalcButton);
            this.Controls.Add(this.circleCalcButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Area Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button circleCalcButton;
        private System.Windows.Forms.Button rectangleCalcButton;
        private System.Windows.Forms.Button cylinderCalcButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox circleRadiusTextBox;
        private System.Windows.Forms.TextBox cylinderRadiusTextBox;
        private System.Windows.Forms.TextBox cylinderHeightTextBox;
        private System.Windows.Forms.TextBox rectangleWidthTextBox;
        private System.Windows.Forms.TextBox rectangleLengthTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label circleDisplayLabel;
        private System.Windows.Forms.Label rectangleDisplayLabel;
        private System.Windows.Forms.Label cylinderDisplayLabel;
    }
}

