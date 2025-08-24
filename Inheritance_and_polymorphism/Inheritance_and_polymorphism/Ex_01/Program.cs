using System;
using System.Globalization;
using Ex_01.Entities;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinesAccount account = new BussinesAccount(1001, "Alex", 500.0, 400.0);

            Console.WriteLine(account);

            Console.WriteLine("Deposti:");
            double depositAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            account.Deposit(depositAmount);

            Console.WriteLine(account);

            Console.WriteLine("WhitDraw:");
            double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(withdrawAmount);

            Console.WriteLine(account);


            Console.WriteLine("Loan:");
            double loanAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Loan(loanAmount);

            Console.WriteLine(account);





        }
    }
}
