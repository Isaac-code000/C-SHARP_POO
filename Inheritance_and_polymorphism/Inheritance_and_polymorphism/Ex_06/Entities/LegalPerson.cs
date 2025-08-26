using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06.Entities
{
    sealed class LegalPerson : TaxPayer
    {
        public int NumberOfEmployees { get; set; }  



        public LegalPerson()
        {
        }   

        public LegalPerson(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            return (NumberOfEmployees > 10) ?
                (AnualIncome * 0.14) :
                (AnualIncome * 0.16);
        }
        override public string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2");
        }   

    }
}
