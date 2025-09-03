using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08.Entities
{
    internal class Product
    {
        public string Name {  get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product() { }
        public Product(string name, int id, double price, Category category)
        {
            Name = name;
            Id = id;
            Price = price;
            Category = category;
        }


        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2")
                + ", "
                + Category.Name;    
        }
    }
}
