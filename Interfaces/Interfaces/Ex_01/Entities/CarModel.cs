using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01.Entities
{
    sealed class CarModel
    {
        public string Name { get; set; }
    public CarModel(string name) {

            Name = name;
        }
    }
}
