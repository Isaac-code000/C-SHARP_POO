using System;
using System.Globalization;


namespace Ex_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, c;
            Console.WriteLine("Informe a quantidade de linhas da matriz");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de colunas da matriz");
            c = int.Parse(Console.ReadLine());  

            int[,] mat = new int[l, c]; 

            for(int i = 0; i < l; i++)
            {
                Console.WriteLine("Informe os dados da linha " + (i + 1));
                string[] values = Console.ReadLine().Split(' ');    
                for (int j = 0; j < c;j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Informe um valor a ser buscado na matriz");
            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if(mat[i, j] == search)
                    {
                        Console.WriteLine("Position "+ i +","+ j+ ":");

                        if(i - 1 >= 0)
                        {
                            Console.WriteLine("Up: " + mat[(i-1),j]);
                        }
                        if (i + 1 < l)
                        {
                            Console.WriteLine("Down: " + mat[(i + 1), j]);
                        }

                        if(j - 1 >= 0)
                        {
                            Console.WriteLine("Left: " + mat[i, (j - 1)]);
                        }
                        
                        if(j + 1 < c)
                        {
                            Console.WriteLine("Right: " + mat[i, (j + 1)]);
                        }
                    }
                }
            }
        }
    }
}