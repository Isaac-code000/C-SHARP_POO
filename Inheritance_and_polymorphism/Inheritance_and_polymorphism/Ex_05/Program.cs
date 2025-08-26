using System;
using Ex_05.Entities;
using Ex_05.Entities.Enums;


namespace Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of shapes");
            int n = int.Parse(Console.ReadLine());
            List<Shape> Shapes = new List<Shape>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(width, height,color);
                    Shapes.Add(rectangle);

                }
                else if (ch == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(radius, color);
                    Shapes.Add(circle);
                   
                }
            }   

            foreach(Shape shape in Shapes)
            {
                Console.WriteLine(shape);
            }   


        }
    }
}
