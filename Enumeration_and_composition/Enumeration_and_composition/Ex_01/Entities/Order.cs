using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_01.Entities.Enums;

namespace Ex_01.Entities
{
    class Order
    {
        public int Id { get; set; } 
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }




        override public string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }



    }
}
