using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordClassLibrary
{
    public class Separate
    {
        public static string SeparateWord(string text)
        {
            // to build a new string to return
            string separatedString = "";

            for (int i = 0; i < text.Length; i++)
            {
                // does not put a space before the first upper case
                if (char.IsUpper(text[i]) && i > 0)
                {
                    separatedString += " ";
                }
                // does not make the first capital to lowercase
                if (i > 0)
                {
                    separatedString += text[i].ToString().ToLower();
                }
                else
                {
                    separatedString += text[i];
                }
                
            }
            // also could have made a char array delim of all uppercase and trim string then split into tokens and put back into a sentence with spaces
            return separatedString;
        }
    }
}
