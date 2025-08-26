using System;
using Ex_06.Entities;

namespace Ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of TaxPayer");
            int n = int.Parse(Console.ReadLine());
            double total = 0.0;
            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"TaxPayer #{i + 1} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new NaturalPerson(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(name, anualIncome, numberOfEmployees));
                }
            }

            foreach(TaxPayer tp in list)
            {
                total += tp.Tax();
                Console.WriteLine(tp);
            }
            Console.WriteLine($"Total tax: $ {total}");
        }
    }

}
