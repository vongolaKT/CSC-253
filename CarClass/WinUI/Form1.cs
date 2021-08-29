using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarLibrary;

namespace WinUI
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createCarButton_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(yearTextBox.Text, out year))
            {
                Car.cars.Add(new Car(year, makeTextBox.Text, modelTextBox.Text));

                makeTextBox.Text = "";
                yearTextBox.Text = "";
                modelTextBox.Text = "";

                showMakeLabel.Text = Car.cars[Car.cars.Count - 1].Make;
                showYearLabel.Text = Car.cars[Car.cars.Count - 1].Year.ToString();
                showModelLabel.Text = Car.cars[Car.cars.Count - 1].Model;
                showSpeedLabel.Text = Car.cars[Car.cars.Count - 1].Speed.ToString();
            }
            else
            {
                MessageBox.Show("Check your input!");
            }
        }

        private void brakeButton_Click(object sender, EventArgs e)
        {
            // Brake if speed is greater than zero
            if (Car.cars[Car.cars.Count - 1].Speed > 0)
            {
                Car.Brake(Car.cars[Car.cars.Count - 1]);
            }
            else
            {
                MessageBox.Show("Speed Already 0!");
            }

            // Update Speed
            showSpeedLabel.Text = Car.cars[Car.cars.Count - 1].Speed.ToString();
        }

        private void accelerateButton_Click(object sender, EventArgs e)
        {
            // Accelerate
            Car.Accelerate(Car.cars[Car.cars.Count - 1]);
            // Update Speed
            showSpeedLabel.Text = Car.cars[Car.cars.Count - 1].Speed.ToString();
        }
    }
}
