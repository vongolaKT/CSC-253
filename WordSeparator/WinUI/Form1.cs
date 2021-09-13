using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordClassLibrary;

/**
* 9/12/2021
* CSC 253
* Kevin Griffin
* Take input that has all words capitalized and together with no spaces and separate them while only leaving the first word capitalized
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
            // exit
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear input and output
            inputTextBox.Text = "";
            outputLabel.Text = "";
        }

        private void separateButton_Click(object sender, EventArgs e)
        {
            string separatedText = Separate.SeparateWord(inputTextBox.Text);

            outputLabel.Text = separatedText;
        }
    }
}
