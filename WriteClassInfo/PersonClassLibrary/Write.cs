using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersonClassLibrary
{
    public static class Write
    {
        // static because not making an object
        public static string WriteToFile(Person person)
        {
            try
            {
                StreamWriter writer;

                writer = File.AppendText("UserInformation.csv");

                writer.WriteLine($"{person.FirstName},{person.LastName},{person.Age}");

                // Close and save file
                writer.Close();

                return "User Info added to file";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
