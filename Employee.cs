using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private string _surname;
        private int _age;

        public Employee()
        {
        }
        public Employee(string surname, int age)
        {
            _surname = surname;
            _age = age;
        }
        private string Age()
        {
            return _age.ToString();
        }
        public void Surname(string surname)
        {
            _surname = surname;
        }
        public string Info()
        {
            string info = $"Surname:{_surname}, Age:{_age}";
            return info;
        }
    }
}
