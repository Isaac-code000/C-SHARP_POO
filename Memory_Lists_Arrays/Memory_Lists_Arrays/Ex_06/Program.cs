using System;



namespace Ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inform o tamanho da matriz N x N");
            int n = int.Parse(Console.ReadLine());   
            int[,] mat = new int[n, n];
            int count=0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe os dados da linha " + (i+1));
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   count += mat[i, j] < 0 ? 1 : 0 ;
                }
            }

            Console.WriteLine("A matriz tem " + count + " numeros negativos");

            Console.WriteLine("Diagonal principal: ");

            for(int i = 0;i < n; i++)
            {
                Console.Write(" "+mat[i,i]);
            }
        }
    }

}
