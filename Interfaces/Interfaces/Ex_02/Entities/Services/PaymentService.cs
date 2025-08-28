using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02.Entities.Services
{
    internal class PaymentService
    {
        public int NumberOfInstallments { get; set; }
        IPaymentService _paymentService;


        public PaymentService(int numberOfInstallments, IPaymentService paymentService)
        {
            NumberOfInstallments = numberOfInstallments;
            _paymentService = paymentService;
        }

        public void Installments(double amount, DateTime date,List<Installment> list)
        {
            double initialValue = amount / NumberOfInstallments;
            for (int i = 1; i <= NumberOfInstallments; i++)
            {
                double monthlyTax = _paymentService.MonthTax(initialValue) * i;
                double paymentFee = _paymentService.PaymentFee(initialValue + monthlyTax);
                double finalValue = initialValue + monthlyTax + paymentFee;
                DateTime dueDate = date.AddMonths(i);

                list.Add(new Installment(finalValue,dueDate));
            }
            
        }
        public double TotalPayment(List<Installment> list)
        {
            double total = 0.0;
            foreach (Installment item in list)
            {
                total += item.Amount;
            }
            return total;
        }
    }
}
