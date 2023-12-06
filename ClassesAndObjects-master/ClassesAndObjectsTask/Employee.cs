using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjectsTask
{
    internal class Employee
    {

        private string surname { get; set; }

        private int age { get; set; }
        
        public Employee() { }

        public Employee(string initialSurname, int initialAge)
        {
            surname = initialSurname;
            age = initialAge;
        }

        private string GetAge()
        {
            return age.ToString();
        }

        public void SetSurname(string newSurname)
        {
            surname = newSurname;
        }

        public string ReturnEmployeeInfo()
        {
            return $"Surname: {surname}, Age: {age}";

        }


    }
}
