using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04.Entities.Enums
{
    enum OrderStatus : int
    {
        pendigPayment = 0,
        processing = 1,
        shipped = 2,
        delivered = 3
    }
}
