using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_03
{
    class Rectangle
    {
        public double Height;
        public double Width;

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return 2 * (Height + Width);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Height,2.0) + Math.Pow(Width,2.0));
        }

        public override string ToString()
        {
            return "Area:" + Area()
                + " Perimetro:" + Perimeter() 
                + " Diagonal:" + Diagonal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
