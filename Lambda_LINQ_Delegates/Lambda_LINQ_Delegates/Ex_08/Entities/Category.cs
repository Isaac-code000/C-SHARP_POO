using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08.Entities
{
    internal class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Tier { get; set; }

        public Category() { }
        public Category(string name, int id, int tier)
        {
            Name = name;
            Id = id;
            Tier = tier;
        }
    }
}
