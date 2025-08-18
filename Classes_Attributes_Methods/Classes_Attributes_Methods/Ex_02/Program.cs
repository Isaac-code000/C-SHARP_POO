using System;
using System.Globalization;



namespace Ex_02
{
    class program
    {
        static void Main(string[] args)
        {
            Merchandise p = new Merchandise();  

            Console.WriteLine("Informe o nome, preço, e quantidade do produto");
            p.Name = Console.ReadLine();
            p.Price = double.Parse(Console.ReadLine());
            p.Quant = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto:" + p);
            Console.WriteLine("Informe quantos produtos vc quer adicionar");
            p.Quant += int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto:" + p);
            Console.WriteLine("Informe quantos produtos vc quer remover");
            p.Quant -= int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto:" + p);
            
        }
    }
}