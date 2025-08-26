using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_05.Entities.Enums;

namespace Ex_05.Entities
{
    sealed class Rectangle : Shape
    {
        public double Widht { get; set; }
        public double Heigth { get; set; }



        public Rectangle()
        {
        }
        public Rectangle(double widht, double heigth, Color cor) 
            : base(cor)
        {
            Widht = widht;
            Heigth = heigth;
        }

        public override double Area()
        {
            return Widht * Heigth;
        }

        override public string ToString()
        {
            return "Rectangle: " + Area() + " - " + base.ToString();
        }
    }
}
