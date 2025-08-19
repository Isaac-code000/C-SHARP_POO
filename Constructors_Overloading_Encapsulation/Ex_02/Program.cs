using System;
using Ex_01;


namespace Ex_02
{
    static class Program
    {
        static void Main(string[] args)
        {
            Product_prop p = new Product_prop("TV", 50.0, 10);

            p.Name = "t";
            

            Console.WriteLine("Nome do produto:" + p.Name);
            Console.WriteLine("Preço do produto:" + p.Price);
        }
        }
    }

