using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01.Entities
{
    class Invoice
    {

        public double BasePayment { get; set; }
        public double Tax { get; set; }


        public Invoice(double basePayment, double tax)
        {
            BasePayment = basePayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get
            {
                return BasePayment + (BasePayment * Tax);
            }
        }


        public override string ToString()
        {
            return "Base Value: $ " + BasePayment
                + " Tax: " + Tax.ToString("P", CultureInfo.InvariantCulture)
                + " Total Value: $ " + TotalPayment;
        }
    }
}