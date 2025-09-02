using System;
using System.Collections.Generic;
using Ex_02.Entities;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet",350.00)); 

            Comparison<Product> comp = (p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());   

            list.Sort(comp);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }   
        }

        
    }
}
