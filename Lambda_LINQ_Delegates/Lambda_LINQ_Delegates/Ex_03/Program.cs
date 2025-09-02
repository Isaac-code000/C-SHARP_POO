using System;
using System.Dynamic;
using Ex_03.Services;

namespace Ex_03
{
    class Program
    {

        delegate void Smq(double a, double b);
        
        delegate double Sq(double a);
        static void Main(string[] args)
        {
            double a = 10.0;
            double b = 20.0;

            Smq smq = CalculationService.Sum;
            smq += CalculationService.Max;

            Sq sq = CalculationService.Square;

            smq(a, b);

            double square = sq(a);

            Console.WriteLine(square);

        }
    }
}
