using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RandNumClassLibrary
{
    public class Read
    {
        public static List<int> GetNums()
        {
            // open file
            StreamReader inputFile = File.OpenText("../../../RandNumClassLibrary/Random.txt");

            // create local variables
            List<int> nums = new List<int>();

            // loop through enitre file
            while (!inputFile.EndOfStream)
            {

                // add to list of nums by parsing the text
                nums.Add(int.Parse(inputFile.ReadLine()));

            }

            // close file
            inputFile.Close();

            return nums;
        }

        public static int FileNumSum()
        {
            // open file
            StreamReader inputFile = File.OpenText("../../../RandNumClassLibrary/Random.txt");

            // create accumulator
            int sum = 0;

            // loop through enitre file
            while (!inputFile.EndOfStream)
            {
                // accumulate with current line
                sum += int.Parse(inputFile.ReadLine());
            }

            // close file
            inputFile.Close();

            return sum;
        }

        public static int FileNumCount()
        {
            // open file
            StreamReader inputFile = File.OpenText("../../../RandNumClassLibrary/Random.txt");

            // create counter
            int count = 0;

            // loop through enitre file
            while (!inputFile.EndOfStream)
            {
                // Read each line to step through
                inputFile.ReadLine();
                // count each line
                count++;
            }

            // close file
            inputFile.Close();

            return count;
        }
    }
}
