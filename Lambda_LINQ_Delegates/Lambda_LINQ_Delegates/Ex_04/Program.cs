using System;
using Ex_04.Entities;

namespace Ex_04
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));


            list.RemoveAll(list => list.Price >= 100.00);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }
    }
}