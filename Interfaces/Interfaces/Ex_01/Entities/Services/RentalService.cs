using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01.Entities.Services
{
    internal class RentalService
    {
        public double ValuePerDay { get; set; }
        public double ValuePerHour { get; set; }

        private ITaxService _taxService;

        public RentalService(double valuePerDay, double valuePerHour,ITaxService tax)
        {
            ValuePerDay = valuePerDay;
            ValuePerHour = valuePerHour;
            _taxService = tax;
        }


        public Invoice ProcessInvoice(CarRental carRental)
        {
            double hours = carRental.Hours();
            double basePayment = 0.0;


            if (hours > 12)
            {
                basePayment = Math.Ceiling(hours) * ValuePerDay;
            }
            else
            {
                basePayment = Math.Ceiling(hours) * ValuePerHour;
            }

            Invoice invoice = new Invoice(basePayment, _taxService.ValueTax(basePayment));
            return invoice;
        }

    }
}
