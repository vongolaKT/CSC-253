using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordCountClassLibrary;

/**
* 8/2/2021
* CSC 253
* Kevin Griffin
* Takes input from the user and counts then returns the amount of words in the input
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
            // clear and focus
            inputTextBox.Text = "";
            numDisplayLabel.Text = "";
            inputTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // assign input to variable
            string input = inputTextBox.Text;

            // send our inpput to our method which returns the number of words to numWords
            int numWords = Words.CountWords(input);

            // display number of words
            numDisplayLabel.Text = numWords.ToString();
        }
    }
}
