using System;
using Ex_08.Entities;



namespace Ex_08
{
    class Program
    {

        static void Show<T>(string message,IEnumerable<T> colection) {
                Console.WriteLine(message);
            foreach (T item in colection)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Category cat1 = new Category("Tools", 1001, 2);
            Category cat2 = new Category("Computers", 1002, 1);
            Category cat3 = new Category("Electronics", 1003, 3);

            List<Product> products = new List<Product>()
            {
            new Product(){Name = "Computer", Price = 1100.0, Category = cat2},
            new Product(){Name = "Hammer", Price = 90.0, Category = cat1},
            new Product(){Name = "TV", Price = 1700.0, Category = cat3},
            new Product(){Name = "Notebook", Price = 800.0, Category = cat2},
            new Product(){Name = "Saw", Price = 80.0, Category = cat1},
            new Product(){Name = "Tablet", Price = 700.0, Category = cat2},
            new Product(){Name = "Camera", Price = 700.0, Category = cat3},
            new Product(){Name = "Printer", Price = 350.0, Category = cat3},
            new Product(){Name = "MacBook", Price = 1800.0, Category = cat2},
            new Product(){Name = "Sound Bar", Price = 700.0, Category = cat3},
            new Product(){Name = "Level", Price = 70.0, Category = cat1}    
            };

            var tier2 = products.Where(p => p.Category.Tier == 2 && p.Price < 900.0);
            var tier1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            var tier3 = products.Where(p => p.Category.Tier == 3 && p.Price < 900.0);


            
            Show("Tier 1 < 900:",  tier1);
            
            Show("Tier 2 < 900:",  tier2);
            
            Show("Tier 3 < 900",  tier3);

            var tools = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); 
            
            Show("Tools:", tools);
        }
    }
}