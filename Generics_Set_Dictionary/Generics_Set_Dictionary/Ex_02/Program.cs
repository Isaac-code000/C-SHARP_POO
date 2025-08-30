using System;
using Ex_02.Entities;
using Ex_02.Services;

namespace Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.WriteLine("Enter the number of products");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Price:");
                double price = double.Parse(Console.ReadLine());
                list.Add(new Product(name, price));
            }

            CalculationService cs = new CalculationService();

            Product max = cs.Max(list);
            Console.WriteLine(max);


        }
    }
}   
