using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    internal class Product_prop
    {
        private String _name;
        public double Price { get; private set; }
        public int Quant { get; private set; }

        public Product_prop(String name, double price, int quant)
        {
            _name = name;
            Price = price;
            Quant = quant;
        }

       public String Name
        {
            get { return _name; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }


        /*
         Normal Get/Set

        public String Get_name()
        {
            return _name;   
        }

        public void Set_name(String name)
        {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
        }

        public double Get_price()
        {
            return Price;
        }

        public double Get_quant()
        {
            return Price;
        }

        */

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