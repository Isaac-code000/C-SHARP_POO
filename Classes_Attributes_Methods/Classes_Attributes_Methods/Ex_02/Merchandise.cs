using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    internal class Merchandise
    {

        public string Name=" ";
        public double Price=0.0;
        public int Quant=0;

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
