using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07
{
    class Convert
    {
        public static double Iof = 6.0/100;

        public static double Value_real(double cot,double value)
        {
            double tax = Iof * value;
            return cot * (value+tax);
        }
    }

}



