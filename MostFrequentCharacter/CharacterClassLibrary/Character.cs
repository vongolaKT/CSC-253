using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterClassLibrary
{
    public class Character
    {
        // since this class is not building objects I do not need a default constructor
        public static char FindFrequentCharacter(string userString)
        {
            // set to defaults so that thye first character in the string will always be assigned
            int mostOccurrences = -1;
            char mostFrequentChar = ' ';

            // loop through each character to look for more of the same character
            foreach (char currentChar in userString)
            {
                // this will skip the current character if it is already the most frequent character also excludes null/whitespace, not sure if thats the intended way but thats what I chose to do
                if (currentChar == mostFrequentChar || currentChar == ' ')
                {
                    continue;
                }
                else
                {
                    int currentCharOccurence = 0;

                    // checks all characters in the string including itself and the counter accumulates if there is a match
                    foreach (char charMatch in userString)
                    {
                        if (currentChar == charMatch)
                        {
                            currentCharOccurence++;
                        }

                        if (mostOccurrences < currentCharOccurence)
                        {
                            // if the current character has more occurances than the most it will replace
                            // however if the new character has the same ammount of occurances nothing will change
                            // meaning that this will always pick the first character that appears in the string if there is a tie.
                            mostOccurrences = currentCharOccurence;
                            mostFrequentChar = currentChar;
                        }
                    }
                }
            }

            return mostFrequentChar;
        }
    }
}
