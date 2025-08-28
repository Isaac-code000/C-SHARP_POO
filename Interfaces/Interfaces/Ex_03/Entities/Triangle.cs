using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_03.Entities.Enums;

namespace Ex_03.Entities
{
    internal class Triangle : AbstractShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double b, double h, Colors cor) : base(cor)
        {
            Base = b;
            Height = h;
        }
        public override double Area()
        {
            return (Base * Height) / 2;
        }
    }
    
    }

