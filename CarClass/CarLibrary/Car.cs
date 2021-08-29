using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        public static List<Car> cars = new List<Car>();

        private int _year;
        private string _make;
        private double _speed;

        public Car()
        {
            // Default Constructor - constructor name must match class name
        }

        // overloaded constructor with our desired information to build the object 
        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            // Instructions said the constructor itself should assign the speed to zero and since we are not passing a value in for speed we dont need to have it as an argument
            Speed = 0;
            Model = model;
        }
        // Long way with backing fields
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }

        }

        public double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        // auto properties look like this
        public string Model { get; set; }

        public static double Accelerate(Car car)
        {
            car.Speed += 5;

            return car.Speed;
        }

        public static double Brake(Car car)
        {
            if (car.Speed >= 5)
            {
                car.Speed -= 5;
            }
            // If speed is less than 5 speed is set to zero
            else
            {
                car.Speed = 0;
            }
            return car.Speed;
        }
    }
}
