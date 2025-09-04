using System;
using System.Globalization;
using Ex_09.Entities;

namespace Ex_09
{
    class Program
    {

        public static void Show<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.WriteLine(item);

            }

        }
        static void Main(string[] args)
        {
            try
            {
                string path = @"c:\text\employees.txt";
                List<Employee> employees = new List<Employee>();

                using (StreamReader sr = File.OpenText(path))
                {

                    while (!(sr.EndOfStream))
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2]);


                        employees.Add(new Employee(email, name, salary));
                    }

                    Console.WriteLine("Salary:");
                    double salaryFilter = double.Parse(Console.ReadLine());

                    var emails = employees.Where(e => e.Salary > salaryFilter).OrderBy(e => e.Email).Select(e => e.Email).ToList();
                    Show("Email of people whose salary is more than " + salaryFilter.ToString("F2") + ":", emails);

                    var salaryM = employees.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();

                  
                    Console.WriteLine("Sum of salarys of employees with the initial M " + salaryM.ToString("F2",CultureInfo.InvariantCulture));


                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
