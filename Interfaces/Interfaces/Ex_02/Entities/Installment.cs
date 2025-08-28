using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02.Entities
{
    internal class Installment
    {
        public double Amount { get; set; }
        public DateTime DueDate { get; set; }

        public Installment(double amount, DateTime dueDate)
        {
            Amount = amount;
            DueDate = dueDate;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2");
        }
    }
}
