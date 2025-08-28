using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01.Entities.Services
{
    internal interface ITaxService
    {
        public double ValueTax(double amount);
    }
}
