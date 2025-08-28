using System;
using System.Globalization;
using Ex_01.Entities;
using Ex_01.Entities.Services;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter of model car");
            string name = Console.ReadLine();

            Console.WriteLine("Pickup: (dd/MM/yyyy HH:mm) ");
            DateTime pick = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Finish: (dd/MM/yyyy HH:mm) ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price perHours");
            double pHours = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter price perDays");
            double pDays = double.Parse(Console.ReadLine());

            
            RentalService service = new (pDays,pHours,new BrazilTax()); 
            CarRental rental = new CarRental(pick,finish, new CarModel(name));

            Console.WriteLine(service.ProcessInvoice(rental));

        }
    }
}
