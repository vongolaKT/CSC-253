using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TemperatureClassLibrary
{
    public class Calculate
    {
        public Calculate()
        {
            // Default
        }
        public static double calculateFarenheight(double celsius)
        {
            return (9.0 / 5.0) * celsius + 32;
        }
    }
}
