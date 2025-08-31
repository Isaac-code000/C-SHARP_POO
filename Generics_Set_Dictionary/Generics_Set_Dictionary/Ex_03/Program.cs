using System;
using Ex_03.Entities;
namespace Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Maria Brown", "maria.gmail.com");
            Client client1 = new Client("Alex Green", "alex.gmail.com");


            Console.WriteLine(client.Equals(client1));
            Console.WriteLine(client == client1);
            Console.WriteLine(client.GetHashCode());
            Console.WriteLine(client1.GetHashCode());
        }
    }
}
