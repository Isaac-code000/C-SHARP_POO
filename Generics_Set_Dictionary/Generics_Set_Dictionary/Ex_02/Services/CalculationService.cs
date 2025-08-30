using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02.Services
{
    internal class CalculationService
    {

        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The list cannot be empty.");
            }

            T max = list[0];
            foreach (T item in list)
            {
                if (item.CompareTo(max)>0)
                {
                    max = item;
                }
            }
            return max ;
        }
    }
}