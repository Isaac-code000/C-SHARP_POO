using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex_03.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Client(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Client))
            {
                throw new ArgumentException("Invalid comparison");
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }


    }
}
