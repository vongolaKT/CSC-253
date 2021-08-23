using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnergyClassLibrary;

/**
* 8/22/2021
* CSC 253
* Kevin Griffin
* Given a mass and velocity, calculates, returns, and displays the kinetic energy in joules. With a class library
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
            // Clears input and output
            massTextBox.Text = "";
            velocityTextBox.Text = "";
            energyLabel.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double mass, velocity, energy;

            // TryParse input to make sure it is correct type
            if (double.TryParse(massTextBox.Text, out mass))
            {
                // TryParse input to make sure it is correct type
                if (double.TryParse(velocityTextBox.Text, out velocity))
                {
                    energy = Calculate.KineticEnergy(mass, velocity);

                    energyLabel.Text = energy.ToString("n1");
                }
                else
                {
                    // Error if wrong type of input
                    MessageBox.Show("Velocity input is invalid.");
                }
            }
            else
            {
                // Error if wrong type of input
                MessageBox.Show("Mass input is invalid.");
            }
        }
    }
}
