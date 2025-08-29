using System;
using System.IO;
using Ex_05.Entities;

namespace Ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\text\employee.txt";
            
            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }   

                }

                

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
