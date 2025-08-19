using System;
using System.Globalization;
using Ex_01;



namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Informe o nome, preço, e quantidade do produto");
            String name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            int quant = int.Parse(Console.ReadLine());

            Product produto = new Product(name, price, quant);

            Product produto2 = new Product(name, price);

            Product produto3 = new Product
            {
                Name = name,
                Price = price,
                Quant = quant,
            };

            Console.WriteLine($"Dados do produto:" + produto);
            Console.WriteLine("Informe quantos produtos vc quer adicionar");
            produto.Quant += int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto:" + produto);
            Console.WriteLine("Informe quantos produtos vc quer remover");
            produto.Quant -= int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto:" + produto);

        }
    }
}

