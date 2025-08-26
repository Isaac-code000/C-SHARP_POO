using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_05.Entities.Enums;

namespace Ex_05.Entities
{
    sealed class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle(double radius, Color cor) : base(cor)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }

        override public string ToString()
        {
            return "Circle: " + Area().ToString("F2",CultureInfo.InvariantCulture) + " - " + base.ToString();
        }

    }
}
