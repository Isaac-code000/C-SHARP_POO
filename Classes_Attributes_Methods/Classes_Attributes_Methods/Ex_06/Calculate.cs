using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    internal class Calculate
    {

        public static double Pi = 3.14;

        public static double Circuference(double Raio)
        {
            return 2.0 * Pi * Raio;
        }

        public static double Volume(double Raio)
        {
            return (4.0 / 3.0) * Pi * Math.Pow(Raio, 3);
        }
    }
}
