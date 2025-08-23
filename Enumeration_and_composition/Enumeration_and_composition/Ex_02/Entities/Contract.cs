using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02.Entities
{
    class Contract
    {
        public DateTime Date { get; set; }
        public TimeSpan Hours { get; set; }
        public double ValuePerHour { get; set; }



        public Contract(DateTime date, TimeSpan hours, double valuePerHour)
        {
            Date = date;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }


        public double TotalValue()
        {
            return ValuePerHour * Hours.TotalHours;
        }

        override public string ToString()
        {
            return Date
                + ", "
                + Hours
                + " hours, $"
                + TotalValue().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }   
    }
}
