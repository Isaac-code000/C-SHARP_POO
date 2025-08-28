using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_03.Entities.Enums;

namespace Ex_03.Entities
{
    abstract class AbstractShape : Ishape
    {

        public Colors Color { get; set; }
        public abstract double Area();
        public AbstractShape(Colors cor)
        {
            Color = cor;
        }
    }
}
