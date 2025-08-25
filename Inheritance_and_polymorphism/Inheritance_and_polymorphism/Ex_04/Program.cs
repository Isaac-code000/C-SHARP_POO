using System;
using System.Threading.Channels;
using Ex_04.Entities;

namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number os products");
            int n = int.Parse(Console.ReadLine());
            List<Product> Products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (ch == 'c')
                {
                    Product product = new Product(name, price);
 
                    Products.Add(product);
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UsedProduct usedProduct = new UsedProduct(name, price, date);
                    Products.Add(usedProduct);
                }
                else if (ch == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    ImportedProduct importedProduct = new ImportedProduct(name, price, customFee);
                    Products.Add(importedProduct);
                }
            }
            foreach (Product prod in Products)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}