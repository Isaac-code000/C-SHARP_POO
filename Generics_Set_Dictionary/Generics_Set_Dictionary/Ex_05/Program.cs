using System;
using System.Collections.Generic;
using Ex_05.Entities;

namespace Ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> products = new HashSet<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));

            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(3, 4));
            points.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00);    

            Console.WriteLine(products.Contains(prod));
        }

    }

}
