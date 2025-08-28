using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01.Entities.Services
{
    internal class BrazilTax : ITaxService 
    {
        public  double Tax { get; set; }
        public double ValueTax(double amount)
        {
            if(amount <= 100)
            {
                Tax = 0.2;
            }
            else
            {
                Tax = 0.15;
            }
            return Tax;
        }
    }
}
