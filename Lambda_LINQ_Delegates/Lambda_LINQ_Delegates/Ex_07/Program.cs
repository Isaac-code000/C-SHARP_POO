using System;

using System.Linq;


namespace Ex_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vect = new int[] { 1, 2, 3, 4, 5 };

            var result = vect.Where(x => x % 2 == 0).Select(x => x * 10).ToList();


            foreach (var item in result)
            {
                Console.WriteLine(item);
                
            }
        }
    }
}
