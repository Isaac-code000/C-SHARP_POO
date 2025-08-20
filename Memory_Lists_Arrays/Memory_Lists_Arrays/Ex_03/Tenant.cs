using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ex_03
{
    internal class Tenant
    {
        public string Name { get; private set; }
        public string Email {  get; private set; }



        public Tenant(string name, string email)
        {
            Name = name;
            Email = email;
        }


        public override string ToString()
        {
            return "Name: " + Name 
                + " Email: " + Email;
        }
    }
}
