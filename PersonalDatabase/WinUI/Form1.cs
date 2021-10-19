using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* 10/18/2021
* CSC 253
* Kevin Griffin
* Added a search function to the existing Personnel database assignment, allowing to search people by name
*/


namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SearchName(this.personnelDataSet.Employee, searchTextBox.Text);
        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);
        }
    }
}
