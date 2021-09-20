using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RandomWriteClassLibrary
{
    public class Write
    {
        public static void WriteRandom(int amountNumbers)
        {
            // make random number generator
            Random rand = new Random();

            // make and open file
            StreamWriter outputFile;

            outputFile = File.AppendText("Random.txt");

            int index = 0;
            // loop the amount of times specified and write the numbers
            while (index < amountNumbers)
            {
                outputFile.WriteLine(rand.Next(101));

                index++;
            }

            // close file
            outputFile.Close();
        }
    }
}
