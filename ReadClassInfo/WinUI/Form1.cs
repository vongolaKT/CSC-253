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
* Load Class info from csv file and create object in list then display info based on current location in list. Could have just loaded to a list box seperating each attribute with a tab then go to new line with each object
* I did what came to mind first, but that wouldve been better probably, less interaction though.
*/

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load all info from file
            MessageBox.Show(Read.ReadFromFile());

            // Manually display first Persons info
            DisplayPersonInfo();
        }

        private void DisplayPersonInfo()
        {
            // Display info based on current place in the list
            displayAgeLabel.Text = Person.people[Person.personIndex].Age.ToString();
            displayFirstNameLabel.Text = Person.people[Person.personIndex].FirstName;
            displayLastNameLabel.Text = Person.people[Person.personIndex].LastName;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit
            this.Close();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (Person.personIndex == 0)
            {
                MessageBox.Show("Can't go back already at first person!");
            }
            else
            {
                Person.personIndex--;
                DisplayPersonInfo();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (Person.personIndex == (Person.people.Count - 1))
            {
                MessageBox.Show("Can't go forward already at last person!");
            }
            else
            {
                Person.personIndex++;
                DisplayPersonInfo();
            }
        }
    }
}
