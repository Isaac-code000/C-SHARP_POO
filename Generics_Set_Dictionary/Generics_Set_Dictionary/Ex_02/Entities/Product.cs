using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Invalid comparison");
            }

            Product other = obj as Product;
                return Price.CompareTo(other.Price);
        }


        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2");  
        }
    }
}
