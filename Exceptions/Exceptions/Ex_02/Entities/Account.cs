using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_02.Entities.Exceptions;

namespace Ex_02.Entities
{
    sealed class Account
    {
        public int Number { get; set; }
        public double Balance { get; set; }
        public string Holder { get; set; }  
        public double WithdrawLimit { get; set; }   

        

        public Account(int number, string holder, double initialBalance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = initialBalance;
            WithdrawLimit = withdrawLimit;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if(amount > Balance)
            { 
                throw new DomainException("Insufficient balance");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "Holder: " + Holder
                + ",Number: " + Number
                + ", Balance: $ " + Balance.ToString("F2");
        }
    }
}
