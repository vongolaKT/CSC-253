using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersonClassLibrary
{
    public static class Read
    {
        public static string ReadFromFile()
        {
            try
            {
                StreamReader reader = File.OpenText("UserInformation.csv");

                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    Person.people.Add(new Person(tokens[0], tokens[1], int.Parse(tokens[2])));
                }

                // Close file
                reader.Close();
                return "Information Loaded";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
