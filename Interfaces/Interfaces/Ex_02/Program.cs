using System;
using System.Globalization;
using Ex_02.Entities;
using Ex_02.Entities.Services;


namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Number of contract");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Date (dd/MM/yyyy)");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine("Contract value");
                double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Enter number of installments");
                int numberOfInstallments = int.Parse(Console.ReadLine());

                Contract contract = new Contract(id, date, totalValue);
                PaymentService paymentService = new PaymentService(numberOfInstallments,new PaypalTax());

                paymentService.Installments(contract.TotalValue, contract.Date, contract.Installments);

                Console.WriteLine("Total price of contract");
                Console.WriteLine(paymentService.TotalPayment(contract.Installments)); ;

                Console.WriteLine("All Installments");
                foreach (Installment item in contract.Installments)
                {
                    Console.WriteLine(item);
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Number of contract");

            }
        }
    }
}