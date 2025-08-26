using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06.Entities
{
    sealed class NaturalPerson : TaxPayer
    {
        public double HealthExpenditures { get; set; }



        public NaturalPerson()
        {
        }

        public NaturalPerson(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            return (AnualIncome < 20000.00) ?
                (AnualIncome * 0.15) - (HealthExpenditures * 0.5) : 
                (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
        }

        override public string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
