using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_05.Entities.Enums;

namespace Ex_05.Entities
{
    abstract class Shape
    {
        public Color Cor { get; set; }
        public abstract double Area();
        

        public Shape()
        {
        }

        public Shape(Color cor)
        {
            Cor = cor;
        }

        override public string ToString()
        {
            return "Cor: " + Cor;
        }
    }
}
