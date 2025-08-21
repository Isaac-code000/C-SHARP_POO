using System;



namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double? a = null;
            double? b = 10.0;


            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(a.HasValue);

            if (a.HasValue) {
                Console.WriteLine(a.Value);
            }
            else
            {
                Console.WriteLine("null value");
            }
            
            a = b ?? 0;

            Console.WriteLine(a.GetValueOrDefault());

            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }




        }
    }
}
