using System;
using Ex_05.Entities;

namespace Ex_05
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.00));
            products.Add(new Product("HD Case", 80.90));

            

            Action<Product> UpdatePrice = p => { p.Price += p.Price * 0.1; };   

            products.ForEach(UpdatePrice);
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }

        }
        
    }
}