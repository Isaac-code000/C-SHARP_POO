using System;
using Ex_03.Entities;
using Ex_03.Entities.Enums;

namespace Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ishape s = new Rectangle(3, 4, Colors.black);
            Ishape s2 = new Triangle(5,4, Colors.white);

            Console.WriteLine("Area retangulo: " + s.Area());
            Console.WriteLine("Area triangulo: " + s2.Area());
        }
    }

}
