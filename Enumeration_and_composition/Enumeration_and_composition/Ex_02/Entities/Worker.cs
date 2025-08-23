using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_02.Entities.Enum;

namespace Ex_02.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public Level Level { get; set; }

        public Departament Departament { get; set; }

        public List<Contract> contracts { get; set; } = new List<Contract>();

        public void AddContract(Contract contract)
        {
            contracts.Add(contract);// Implementation for adding a contract to the worker
        }

        public Worker(string name, double baseSalary, Level level, Departament departament)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Departament = departament;
        }

        public void RemoveContract(Contract contract)
        {
            // Implementation for removing a contract from the worker
            contracts.Remove(contract);
        }

        public void Income(int year, int month)
        {
            foreach(Contract contract in contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    BaseSalary += contract.TotalValue(); // Add the total value of the contract to the base salary
                }

            }
        }

        override public string ToString()
        {
            return Name
                + ", "
                + Level
                + ","
                + BaseSalary.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
    }

