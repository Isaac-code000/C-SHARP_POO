using System;
using System.Globalization;
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


            var names = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });

            Show("Names started with 'C' and anonymous object:", names);

            var ordened = products.Where(p => p.Category.Tier == 3).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Show("Eletronics ordered by price then by name:", ordened);

            var paged = ordened.Skip(2).Take(4);    
            Show("Eletronics ordered by price then by name, skip 2 take 4:", paged);

            

            var max = products.Max(p => p.Price);
            Console.WriteLine("Max price:"+max);
            var min = products.Min(p => p.Price);
            Console.WriteLine("Min price:" + min);

            var sum = products.Sum(p => p.Price);
            Console.WriteLine("Sum price:" + sum);

            var avg = products.Average(p => p.Price);
            Console.WriteLine("Average price: $" + avg.ToString("F2",CultureInfo.InvariantCulture));

            var sumAggregate = products.Where(p => p.Category.Tier == 1).Select(p => p.Price).Aggregate(0.0,(x, y) => x + y);
            Console.WriteLine("Sum of Tier 1 prices (Aggregate): " + sumAggregate);

            var empt = products.Where(p => p.Category.Tier == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();

            var grouped = products.GroupBy(p => p.Category);

            foreach(IGrouping<Category, Product> group in grouped)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
            {
                
            }
        }
    }   
}