using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04.Entities
{
    sealed class UsedProduct : Product
    {

        public DateTime Manufacturing { get; set; }


        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufacturing) : base(name, price)
        {
            Manufacturing = manufacturing;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + "(Used)" + "Manufacturing date:" + Manufacturing;
        }




    }
}