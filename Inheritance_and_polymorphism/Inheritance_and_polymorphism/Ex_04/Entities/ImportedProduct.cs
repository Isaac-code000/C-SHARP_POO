using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04.Entities
{
    sealed class ImportedProduct : Product
    {
        public double CustomFee { get; set; }


        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price,double customFee) 
            : base(name,price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Custom fee: $ " + CustomFee.ToString("F2") + ") Total price: $ " + TotalPrice().ToString("F2");
        }
        public double TotalPrice()
        {
            return Price + CustomFee;
        }
    }


}
