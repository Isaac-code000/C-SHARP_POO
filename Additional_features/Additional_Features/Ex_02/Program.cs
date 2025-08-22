using System;
using System.Globalization;


namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;


            Console.WriteLine("Horario atual:" + d1);
            Console.Write("Ticks: " + d1.Ticks);

            // Instanciando com o construtor
            DateTime d2 = new DateTime(2023, 10, 1, 12, 30, 0);
            Console.WriteLine(d2);

            // Convertendo string para DateTime

            DateTime d3 = DateTime.Parse("2023-10-01");
            DateTime d4 = DateTime.Parse("2023-10-01 13:05:55");
            DateTime d5 = DateTime.Parse("15/08/2000");

            // Convertendo com formatação
            DateTime d6 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d7 = DateTime.ParseExact("15/08/2000 13:05:55", "yyyy-MM-dd HH:mm:ss",CultureInfo.InvariantCulture);
        }
    }
}
