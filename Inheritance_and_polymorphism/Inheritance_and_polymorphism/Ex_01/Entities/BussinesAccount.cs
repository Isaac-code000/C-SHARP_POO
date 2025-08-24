using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_01.Entities;

namespace Ex_01.Entities
{
    class BussinesAccount : Account
    {

        public double LoanLimit { get; private set; }


        public BussinesAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }


        public void Loan(double amount)
        {
            if (amount > LoanLimit)
            {
                throw new InvalidOperationException("Loan exceeds limit");
            }
            Balance += amount;
        }



    }
}
