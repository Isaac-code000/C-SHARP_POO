using System;
using System.Globalization;


namespace Ex_06
{
    class Program 
    {

       
        static void Main(string[] args) 
        {
            

            Console.WriteLine("Informe o raio da circunferencia");
            double raio = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Comprimento da circunferencia:" + Calculate.Circuference(raio).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume da circunferencia:" + Calculate.Volume(raio).ToString("F2",CultureInfo.InvariantCulture));

        
        }
    }

}
