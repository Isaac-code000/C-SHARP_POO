using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    internal class Product
    {
        public String Name;
        public double Price;
        public int Quant;

        public Product(String name, double price, int quant)
        {
            Name = name;
            Price = price;
            Quant = quant;
        }

        public Product(String name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {

        }

        public void insert(int r)
        {
            Quant += r;
        }
        public void remove_product(int r)
        {
            Quant -= r;
        }

        public double total_value()
        {
            return Quant * Price;
        }

        public override string ToString()
        {
            return "Nome:" + Name
                + " Quantidade:" + Quant
                + " Preço:" + total_value();
        }
    }
}
