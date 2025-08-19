using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    internal class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }  
        
        public Product(double price,string name) {
            Price = price;
            Name = name;
        }

        public override string ToString()
        {
            return "Nome:" + Name
                + " Preço:" + Price;
        }



    }
}
