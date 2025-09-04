using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using Ex_10.Entities;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Ex_10
{
    class Program
    {

        public static void Show<T>(string messege,IEnumerable<T> colection)
        {
            Console.WriteLine(messege);
            foreach (T item in colection)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                List<Product> products = new List<Product>();
                using (StreamReader rs = File.OpenText(@"c:\text\products.txt"))
                {
                    while (!rs.EndOfStream)
                    {
                        string[] strings = rs.ReadLine().Split(',');
                        string name = strings[0];
                        double price = double.Parse(strings[1], CultureInfo.InvariantCulture);
                        products.Add(new Product(name, price));
                    }
                    var avg = products.Average(p => p.Price);

                    var lowerThanAvg = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name).ToList();

                    Show("Products lower than average price: " + avg.ToString("F2", CultureInfo.InvariantCulture), lowerThanAvg);
                }



            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
