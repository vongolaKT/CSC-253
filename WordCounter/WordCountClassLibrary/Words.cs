using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountClassLibrary
{
    public class Words
    {
        public Words()
        {
            // Default constructor
        }

        public static int CountWords(string input)
        {
            int numWords = 0;
            // tokenize the string to an array splitting it by null which is whitespace
            string[] tokens = input.Split(null);

            // step through the array to add up all the strings
            foreach (string word in tokens)
            {
                numWords += 1;
            }

            return numWords;
        }
    }
}
