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
* 10/3/2021
* CSC 253
* Kevin Griffin
* Program to sort the previous Personnel database assignment using buttons and new tableadapter functions build on SQL statements with the wizard from PersonnelDataSet.xsd
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
            // TODO: This line of code loads data into the 'personnelDataSet.Personnel' table. You can move, or remove it, as needed.
            this.personnelTableAdapter.Fill(this.personnelDataSet.Personnel);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sortAscButton_Click(object sender, EventArgs e)
        {
            this.personnelTableAdapter.SortByPayAscending(this.personnelDataSet.Personnel);
        }

        private void sortDescButton_Click(object sender, EventArgs e)
        {
            this.personnelTableAdapter.SortByPayDesc(this.personnelDataSet.Personnel);
        }
    }
}
