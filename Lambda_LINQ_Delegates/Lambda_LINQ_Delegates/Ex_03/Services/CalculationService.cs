using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03.Services
{
    static class CalculationService
    {
        static public void Sum(double a, double b)
        {
            Console.WriteLine("Soma:"+(a+b));
        }

        static public void Max(double a, double b)
        {
            double maior = a > b ? a : b;

            Console.WriteLine("Maior:" + maior);
        }

        static public double Square(double a)
        {
            return a * a;
        }   
    }
}
