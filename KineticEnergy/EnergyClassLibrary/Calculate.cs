using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyClassLibrary
{
    public class Calculate
    {
        Calculate() 
        {
        
        }

        public static double KineticEnergy(double mass, double velocity)
        {
            return 0.5 * mass * Math.Pow(velocity, 2.0);
        }
    }
}
