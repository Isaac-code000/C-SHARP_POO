using System;
using System.Globalization;



namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Informe as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           

             
  
             char maior = x.Area() > y.Area() ? 'x' : 'y';
             Console.WriteLine("Triangulo X:"+ x.Area().ToString("F2",CultureInfo.InvariantCulture));
             Console.WriteLine("Triangulo y:"+ y.Area().ToString("F2",CultureInfo.InvariantCulture));
             Console.WriteLine($"Maior:{maior}");

        }

    }



}
