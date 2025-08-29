using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string employee)
        {
            string[] division = employee.Split(",");
            Name = division[0];
            Salary = double.Parse(division[1],CultureInfo.InvariantCulture);
        }

        override public string ToString()
        {
            return Name + ", " + Salary;
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }
            Employee other = obj as Employee;   
            return Salary.CompareTo(other.Salary);
        }
    }
}
