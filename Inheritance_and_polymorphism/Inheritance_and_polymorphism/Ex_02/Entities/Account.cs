using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        public Account()
        {
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }
        public override string ToString()
        {
            return "Account "
                + Number
                + ", Holder: "
                + Holder
                + ", Balance: $ "
                + Balance.ToString("F2");
        }
    }
}
