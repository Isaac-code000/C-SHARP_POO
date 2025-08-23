using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Ex_02.Entities;
using Ex_02.Entities.Enum;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu departamento");
            string dep = Console.ReadLine();

            Console.WriteLine("Nome do funcionário:");
            string name = Console.ReadLine();

            Console.WriteLine("Nivel tecnico");
            string level = Console.ReadLine();

            Console.WriteLine("Salario base");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos contratos esse trabalhador possui");
            int n = int.Parse(Console.ReadLine());

            Departament departament = new Departament(dep);

            Worker worker = new Worker(name, salary, Enum.Parse<Level>(level), departament);

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Data do contrato:");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Horas totais:");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                
                Contract contract = new Contract(date, TimeSpan.FromHours(hours), valuePerHour);
                worker.AddContract(contract);
            }

            Console.WriteLine("Informe o ano e o mes para calcular o salario");
            DateTime entered = DateTime.Parse(Console.ReadLine());

            worker.Income(entered.Year, entered.Month);

            Console.WriteLine(worker);
        }
    }
}
