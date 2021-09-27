using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassLibrary
{
    public class DemoClass
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public DemoClass()
        {
            FirstName = "";
            MiddleName = "";
            LastName = "";
            Age = 0;
        }

        // CLASEXAMPLE #2 (Parameterized Constructor)
        public DemoClass(string firstName, string middleName, string lastName, int age)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
        }

       
        // CLASEXAMPLE #3 (Properties)
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        // CLASEXAMPLE #3 (Auto-Property) 
        public string MiddleName { get; set; }


        public void AddToAge(int input)
        {
            _age += input;
        }

        public void AddToAge(string input)
        {
            int num;

            if (int.TryParse(input, out num))        
            {
                _age += num;
        
            }
            else
            {
                Console.WriteLine("Not a valid number");
            }
        }

    }
}
