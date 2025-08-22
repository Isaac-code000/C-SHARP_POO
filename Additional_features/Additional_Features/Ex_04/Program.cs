using System;
using System.Xml;


namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2023, 10, 1, 12, 30, 0);

            Console.WriteLine(d);

            Console.WriteLine("Data" +d.Date);
            Console.WriteLine("Ano" + d.Year);
            Console.WriteLine("Mês" + d.Month);
            Console.WriteLine("Dia" + d.Day);
            Console.WriteLine("Minuto" + d.Minute);
            Console.WriteLine("Segundos" + d.Second);
            Console.WriteLine("Milisegundos" + d.Millisecond);
            Console.WriteLine("ticks" + d.Ticks);
            Console.WriteLine("Dia da semana" + d.DayOfWeek);
            Console.WriteLine("Dia do ano" + d.DayOfYear);

            // Add and Subtract

            Console.WriteLine("Adicionando 10 dias");
            DateTime d2 = d.AddDays(10);
            Console.WriteLine(d.Day);
            Console.WriteLine(d2.Day);
            Console.WriteLine("Diferença entre d e d2");
            // A diferença entre d e d2 e uma duração, por isso o timeSpan 
            TimeSpan d3 = d2.Subtract(d);
            Console.WriteLine(d3);


            // Formatando a data com toString
            Console.WriteLine("Formatando um DateTime em string");
            string s1 = d.ToString("dd/MM/yyyy");
            string s2 = d.ToString("dd/MM/yyyy HH:mm:ss.fff");
            Console.WriteLine("dd/MM/yyyy");
            Console.WriteLine(s1);
            Console.WriteLine("dd/MM/yyyy HH:mm:ss.fff");
            Console.WriteLine(s2);

        }
    }
}