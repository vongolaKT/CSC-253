using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomWriteClassLibrary;
/**
* 9/19/2021
* CSC 253
* Kevin Griffin
* Takes a number given from user and adds that amount of random numbers to a text file
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
            // clear and focus
            numberInputTextBox.Text = "";
            numberInputTextBox.Focus();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            // catch exceptions
            try
            {
                int amountNumbers = int.Parse(numberInputTextBox.Text);

                Write.WriteRandom(amountNumbers);

                MessageBox.Show("Numbers Generated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
