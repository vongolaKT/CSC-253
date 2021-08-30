using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaClassLibrary
{
    public class Area
    {
        public Area()
        {
            // Default Constructor
        }

        // three of the same name overloaded method to handle each type of shape to get the areas based on the paramaters

        public static double CalculateArea(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public static double CalculateArea(double width, double length)
        {
            return width * length;
        }

        public static double CalculateArea(double radius, double height, double pi)
        {
            return Math.Pow(radius, 2) * pi * height;
        }
    }
}
