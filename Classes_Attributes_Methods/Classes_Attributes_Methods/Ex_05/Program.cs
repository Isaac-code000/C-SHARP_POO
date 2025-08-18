using System;

namespace Ex_05
{
    public class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            bool check = false;

            Console.WriteLine("Informe seu Nome");
            student.Name = Console.ReadLine();

            while (check!=true)
            {
                Console.WriteLine("Informe sua primeira nota");
                student.First = double.Parse(Console.ReadLine());
                if (student.First > 30.0 || student.First < 0)
                {
                    check = false;
                    Console.WriteLine("Nota invalida, Max: 30.0 Min: 0.0 ");
                    continue;
                }
                else
                {
                    check = true;
                }
                Console.WriteLine("Informe sua segunda nota");
                student.Second = double.Parse(Console.ReadLine());
                if (student.First > 35.0 || student.First < 0)
                {
                    check = false;
                    Console.WriteLine("Nota invalida, Max: 35.0 Min: 0.0 ");
                    continue;
                }
                else
                {
                    check = true;
                }
                Console.WriteLine("Informe sua terceira nota");
                student.Third = double.Parse(Console.ReadLine());
                if (student.First > 35.0 || student.First < 0)
                {
                    check = false;
                    Console.WriteLine("Nota invalida, Max: 35.0 Min: 0.0 ");
                    continue;
                }
                else
                {
                    check = true;
                }
            }
            Console.WriteLine(student);
        }
    }
}