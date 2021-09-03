using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LettersClassLibrary;

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
            // clear
            inputTextBox.Text = "";
            numDisplayLabel.Text = "";
            inputTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            // pass input into our method and assign the returned double to average
            double average = Letters.AverageNumLetters(input);
            // display
            numDisplayLabel.Text = average.ToString();
        }
    }
}
