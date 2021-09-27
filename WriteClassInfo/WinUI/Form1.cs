using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonClassLibrary;

/**
* 9/26/2021
* CSC 253
* Kevin Griffin
* Takes user input, builds an object then write the object information to a file
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
            // Close
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear and put cursor on top text box
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            ageTextBox.Text = "";
            firstNameTextBox.Focus();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Person newPerson = new Person(firstNameTextBox.Text, lastNameTextBox.Text, int.Parse(ageTextBox.Text));

                MessageBox.Show(Write.WriteToFile(newPerson));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
