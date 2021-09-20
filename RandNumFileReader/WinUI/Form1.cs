using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandNumClassLibrary;
/**
* 9/19/2021
* CSC 253
* Kevin Griffin
* Read and displays information from a file that was randomly written to with numbers
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
            // Just in case something goes wrong
            try
            {
                // these are pretty self explanatory assigning variables to the returned value of each method and displaying them
                int count = Read.FileNumCount();
                int sum = Read.FileNumSum();

                countLabel.Text = count.ToString();
                sumLabel.Text = sum.ToString();

                List<int> nums = Read.GetNums();

                foreach (int num in nums)
                {
                    randNumListBox.Items.Add(num.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
