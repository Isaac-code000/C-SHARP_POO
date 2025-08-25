using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03.Entities
{
    internal class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutsourceEmployee()
        {
        }
        public OutsourceEmployee(string name, int hours, double valuePerhour, double additionalCharge)
            : base(name, hours, valuePerhour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }
    }
}