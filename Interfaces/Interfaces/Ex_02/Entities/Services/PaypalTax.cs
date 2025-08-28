using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02.Entities.Services
{
    internal class PaypalTax : IPaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
        public double MonthTax(double amount)
        {
            return amount * 0.01;
        }
    }
}
