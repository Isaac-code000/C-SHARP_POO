using System;


namespace Ex_03
{
    static class Program
    {
        public static void Main(string[] args)
        {

            Rectangle ret = new Rectangle();

            Console.WriteLine("Informe a altura e largura do triangulo");
            ret.Height = double.Parse(Console.ReadLine()); 
            ret.Width = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Dados:\n" + ret);
            


        }
    }
}