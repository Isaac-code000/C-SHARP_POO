using System;
using Ex_03.Entities;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees");
            int n = int.Parse(Console.ReadLine());
            Enterprise enterprise = new Enterprise();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Outsource ? (s/n)");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 's')
                {

                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Hours:");
                    int hours = int.Parse(Console.ReadLine());

                    Console.WriteLine("Value per hour:");
                    double valuePerhour = double.Parse(Console.ReadLine());

                    Console.WriteLine("Additional charge:");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    OutsourceEmployee emp = new OutsourceEmployee(name, hours, valuePerhour, additionalCharge);
                    enterprise.Employees.Add(emp);
                }
                else
                {
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Hours:");
                    int hours = int.Parse(Console.ReadLine());

                    Console.WriteLine("Value per hour:");
                    double valuePerhour = double.Parse(Console.ReadLine());

                    Employee emp = new Employee(name, hours, valuePerhour);
                    enterprise.Employees.Add(emp);
                }

            }
                foreach (Employee emp in enterprise.Employees)
                {
                    Console.WriteLine(emp);
                }
        }
    }
}