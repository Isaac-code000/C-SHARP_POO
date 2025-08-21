using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; } 
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Id + ",Nome: " + Name + ",Salario: " + Salary.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }   

    }
}
