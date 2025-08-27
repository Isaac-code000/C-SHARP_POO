using System;
using Ex_02.Entities;
using Ex_02.Entities.Exceptions;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Holder:");
                string holder = Console.ReadLine();
                Console.WriteLine("Number account");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Initial balance:");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.WriteLine("Withdraw Limit");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine(account);

                Console.WriteLine("Enter your first deposit");
                double deposit = double.Parse(Console.ReadLine());

                account.Deposit(deposit);
                Console.WriteLine(account);


                Console.WriteLine("Enter an amount to withdraw:");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
                Console.WriteLine(account);


            }
 catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}