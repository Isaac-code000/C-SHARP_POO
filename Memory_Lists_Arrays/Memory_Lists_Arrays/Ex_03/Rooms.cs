using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    internal class Rooms
    {
        public Tenant Tenant { get; set; }
        public int? Number { get; set; }


        public Rooms(Tenant tenant, int number)
        {
            Tenant = tenant;
            Number = number;
        }

        public override string ToString()
        {
            return "Number:" + Number
                + " Email:" + Tenant.Email;
        }

    }



}

