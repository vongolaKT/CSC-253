using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersClassLibrary
{
    public class Letters
    {
        public Letters()
        {
            //default constructor
        }

        public static double AverageNumLetters(string input)
        {
            double totalChar = 0;

            // create array of tokenized strings
            string[] tokens = input.Split(null);

            // steps through each word in the array
            foreach (string word in tokens)
            {
                // steps through each character in each word string
                foreach (char character in word)
                {
                    // checks if each string character is actually a letter if so adds to total to be calculated
                    if (char.IsLetter(character))
                    {
                        totalChar += 1;
                    }
                }
            }

            // could assign to a variable average first then return but this is fine
            return totalChar / tokens.Length;
        }
    }
}
