using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex_04
{
    public class Employee
    {
        public String Name= " ";
        public double Gross_salary = 0.0;
        public double Tax = 0.0;
        public double Liquid_salary = 0.0;

        public double Salary()
        {
            return Gross_salary - (Gross_salary * (Tax/100));
        }

        public override string ToString()
        {
            return "Salario Bruto:" + Gross_salary
            + " Salario liquido:" + Liquid_salary
                 + " Total de imposto pago:" + (Gross_salary - Liquid_salary);
        }
       

    }
}
