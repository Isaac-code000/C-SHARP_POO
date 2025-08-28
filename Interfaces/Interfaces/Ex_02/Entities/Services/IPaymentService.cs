using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02.Entities.Services
{
    interface IPaymentService
    {
        public double PaymentFee(double amount);
        public double MonthTax(double amount);
    }
}
