using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_03.Entities.Enums;

namespace Ex_03.Entities
{
    internal class Rectangle : AbstractShape
    {
        public int Height { get; set; }
        public double Width { get; set; }


        public Rectangle(int height, double width,Colors cor) : base(cor)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
