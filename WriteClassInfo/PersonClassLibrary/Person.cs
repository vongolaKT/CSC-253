using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassLibrary
{
    public class Person
    {
        // Accessable list to build objects in for later assignment
        public static List<Person> people = new List<Person>();

        // Private Backing Fields
        private string _firstName;
        private string _lastName;
        private int _age;


        // Default Contructor
        public Person()
        {
            FirstName = "";
            LastName = "";
            Age = 0;
        }

        // Constructor for all information
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


        // Access private variables with public variables
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
