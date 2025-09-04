using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_09.Entities
{
    internal class Employee
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        
        public Employee(string email, string name, double salary)
        {
            Email = email;
            Name = name;
            Salary = salary;
        }
        override public string ToString()
        {
            return Email
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2");
        }
    }
}
