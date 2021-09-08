using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterClassLibrary;

/**
* 9/7/2021
* CSC 253
* Kevin Griffin
* Takes in input from the user then finds and displays the most used character in the entire string
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
            // close
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear input and output
            inputTextBox.Text = "";
            characterDisplayLabel.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // gets input from the string to pass into the method
            // also makes it all lowercase so that same letters will be counted together whether they are lower or uppercase
            string userString = inputTextBox.Text.ToLower();

            // assigns the text to the returned most frequent character which was converted to a string to display
            characterDisplayLabel.Text = Character.FindFrequentCharacter(userString).ToString();
        }
    }
}
