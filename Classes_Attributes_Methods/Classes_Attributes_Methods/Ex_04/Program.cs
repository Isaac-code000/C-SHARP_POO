
namespace Ex_04
{
    class Program
    {
        public static void Main(string[] args)
        {

            Employee func = new Employee();

            Console.WriteLine("Informe o nome do funcionario");
            func.Name = Console.ReadLine();

            Console.WriteLine("Informe o salario bruto do funcionario");
            func.Gross_salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o imposto que o funcionario há de pagar");
            func.Tax= double.Parse(Console.ReadLine());

            func.Liquid_salary = func.Salary();

            Console.WriteLine(func);


      }
    }
}
