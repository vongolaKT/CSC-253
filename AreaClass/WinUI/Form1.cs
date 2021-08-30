using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AreaClassLibrary;

/**
* 8/29/2021
* CSC 253
* Kevin Griffin
* Gets input from user and calculates the area of a given type of shape. These are all passed to the same overloaded method to calculate and return the area. Then displays
*/

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Circle clear
            circleRadiusTextBox.Text = "";
            circleDisplayLabel.Text = "";
            // Rectangle clear
            rectangleLengthTextBox.Text = "";
            rectangleWidthTextBox.Text = "";
            rectangleDisplayLabel.Text = "";
            // Cylinder clear
            cylinderHeightTextBox.Text = "";
            cylinderRadiusTextBox.Text = "";
            cylinderDisplayLabel.Text = "";
        }

        private void circleCalcButton_Click(object sender, EventArgs e)
        {
            double radius;
            if (double.TryParse(circleRadiusTextBox.Text, out radius))
            {
                double area = Area.CalculateArea(radius);

                circleDisplayLabel.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("Check your input!");
            }
        }

        private void rectangleCalcButton_Click(object sender, EventArgs e)
        {
            double width, length;

            if (double.TryParse(rectangleLengthTextBox.Text, out length))
            {
                if (double.TryParse(rectangleWidthTextBox.Text, out width))
                {
                    double area = Area.CalculateArea(width, length);

                    rectangleDisplayLabel.Text = area.ToString();
                }
                else
                {
                    MessageBox.Show("Check width input!");
                }     
            }
            else
            {
                MessageBox.Show("Check length input!");
            }
        }

        private void cylinderCalcButton_Click(object sender, EventArgs e)
        {
            // needed either different paramater type or one more paramater to successfully overload the same method so i added a parameter pi and passed it in
            double radius, height, pi;
            pi = Math.PI;

            if (double.TryParse(cylinderRadiusTextBox.Text,out radius))
            {
                if (double.TryParse(cylinderHeightTextBox.Text, out height))
                {
                    double area = Area.CalculateArea(radius, height, pi);

                    cylinderDisplayLabel.Text = area.ToString();
                }
                else
                {
                    MessageBox.Show("Check height input!");
                }
            }
            else
            {
                MessageBox.Show("Check radius input!");
            }
        }
    }
}
