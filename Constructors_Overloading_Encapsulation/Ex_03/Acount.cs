using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    internal class Acount
    {
        public int Id { get; private set; }
        public double Saldo { get; private set; }
        public string User { get; private set; }


        public Acount(int id,string user)
        {
            Id = id;
            User = user;
        }

        public Acount(int id,string user,double saldo) : this(id,user) 
        {
            Saldo = saldo;
        }

       
        
        public void Deposit(double dolar)
        {
            Saldo += dolar;
        }

        public void Sake(double dolar)
        {
            double tax = 5.0;
            Saldo -= dolar;
            Saldo -= tax;
        }

        public override string ToString() {
            return " Usuario:" + User
                + " Conta:" + Id 
                + " Saldo:"+ Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
