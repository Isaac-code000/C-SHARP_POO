using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01.Entities
{
    internal class CarRental
    {
        public DateTime PickUp { get; set; }
        public DateTime Return { get; set; }

        public CarModel Car { get; set; }

        public Invoice Invoice { get; set; }



       
        public CarRental(DateTime pickup, DateTime ret, CarModel car)
        {
            PickUp = pickup;
            Return = ret;
            Car = car;
            
        }

        public double Hours()
        {
            TimeSpan diference = Return.Subtract(PickUp);

            return diference.TotalHours;
        }

    }
}
