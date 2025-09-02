﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        override public string ToString()
        {
            return Name + ", " + Price.ToString("F2");
        }
    }
}
