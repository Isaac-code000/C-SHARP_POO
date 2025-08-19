using System;
using System.Globalization;
using System.Net.Http.Headers;



namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Quantos produtos vc deseja cadastrar ?");
            int quant = int.Parse(Console.ReadLine());



            Product[] vet = new Product[quant];
            double average = 0.0;

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Informe o nome do produto");
                string name = Console.ReadLine();
                Console.WriteLine("Informe o preço do produto");
                double price = double.Parse(Console.ReadLine());

                vet[i] = new Product(price, name);

                average += price;
            }

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.WriteLine("Media: "+(average/quant).ToString("F2",CultureInfo.InvariantCulture));
        }

    }
}
