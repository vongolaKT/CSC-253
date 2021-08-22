using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureClassLibrary;

/**
* 8/22/2021
* CSC 253
* Kevin Griffin
* Displays a table that shows celsius to farenheight conversion from 0 to 20 with a class library for logic
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
            // Exit
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear list box just because
            temperatureListBox.Items.Clear();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // Display header seperated by tab spacing
            temperatureListBox.Items.Add("Celsius\tFarenheight");

            // holds celsius and farenheight temps
            double celsius, farenheight;

            for (celsius = 0; celsius <= 20; celsius++)
            {
                farenheight = Calculate.calculateFarenheight(celsius);

                temperatureListBox.Items.Add($"{celsius}\t{farenheight}");
            }
        }
    }
}
