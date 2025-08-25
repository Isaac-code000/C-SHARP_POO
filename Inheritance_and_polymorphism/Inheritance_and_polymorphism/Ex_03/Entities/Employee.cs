using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03.Entities
{
    class Employee
    {
        
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerhour { get; set; }




        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerhour)
        {
            Name = name;
            Hours = hours;
            ValuePerhour = valuePerhour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerhour;
        }

        public override string ToString()
        {
            return Name + " - $ " + Payment().ToString("F2");
        }
    }
}
