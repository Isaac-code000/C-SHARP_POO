using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }


        public Account(int number, string holder, double balance)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            Balance -= amount;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Account {Number}, Holder: {Holder}, Balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }




    }
}
