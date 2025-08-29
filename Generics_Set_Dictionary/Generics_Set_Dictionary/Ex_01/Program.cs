using System;
using Ex_01.Entities;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintService<int> ps = new PrintService<int>();
            Console.WriteLine("How many values ?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a number:");
                int value = int.Parse(Console.ReadLine());
                ps.Add(value);
            }
            ps.Print();
            Console.WriteLine("First: " + ps.First);
        }
    }
}
