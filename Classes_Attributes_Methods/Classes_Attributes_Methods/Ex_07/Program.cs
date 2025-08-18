



using System.Globalization;

namespace Ex_07
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a cotação do dolar");
            double cot = double.Parse(Console.ReadLine());  
            
            Console.WriteLine("Informe quantos dolares vc quer comprar");
            double value = double.Parse(Console.ReadLine());
   
            Console.WriteLine("Total a pagar em R$:" + Convert.Value_real(cot,value).ToString("F2",CultureInfo.InvariantCulture));

        }
    }

}



