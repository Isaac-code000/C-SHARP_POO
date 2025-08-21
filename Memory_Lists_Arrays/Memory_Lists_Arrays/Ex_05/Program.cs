using System;
using System.Globalization;



namespace Ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serao registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            
            
            for (int i = 0;i<n;i++)
            {
                Console.WriteLine("Employee #" + (i+1));
                Console.WriteLine("ID:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Salary:");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                
            }
            Console.Write("Digite o ID do funcionario que tera aumento: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == idIncrease);
            if (emp == null)
            {
                Console.WriteLine("Esse ID nao existe!");
                return;
            }
            else
            {
                Console.WriteLine("Informe a % de aumento");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.IncreaseSalary(percentage);

                Console.WriteLine("Lista de funcionarios atualizada: ");
                foreach (Employee func in list)
                {
                    Console.WriteLine(func);
                }
            }
        }
    }
}