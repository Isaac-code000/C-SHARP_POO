using System;
using System.Collections.Generic;


namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            Console.WriteLine("Deseja enserir quantas pessoas nas lsita ?");
            int quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite o nome da pessoa: ");
                string name = Console.ReadLine();
                list.Add(name);
            }   

            foreach(string name in list)
            {
                Console.WriteLine(name);
            } 
            Console.WriteLine("A lista possui " + list.Count + " pessoas cadastradas.");

           

            list.Remove("isaac");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("A lista possui " + list.Count + " pessoas cadastradas.");
            Console.WriteLine("<---------------------------------------------------------->");


            list.Insert(0, "Isaac");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("A lista possui " + list.Count + " pessoas cadastradas.");
            Console.WriteLine("<---------------------------------------------------------->");


            string search = list.Find(x => x[0] == 'I');
            Console.WriteLine("Primeira pesso com a letra i"+search);
            int id = list.FindIndex(x => x.StartsWith('I'));
            Console.WriteLine("Sua posição:" + id);

            Console.WriteLine("<---------------------------------------------------------->");

            string search2 = list.FindLast(x => x[0] == 'I');
            Console.WriteLine("Ultima pessoa com a letra i"+search);
            int id2 = list.FindLastIndex(x => x.StartsWith('I'));

            Console.WriteLine("Sua posição:" + id);

            Console.WriteLine("<---------------------------------------------------------->");

            Console.WriteLine("Nomes com 5 caracteres:");
            List<string> tam5 = list.FindAll(x => x.Length == 5);

            foreach (string name in tam5)
            {
                Console.WriteLine(name);
            }   

            Console.WriteLine("<---------------------------------------------------------->");

            Console.WriteLine("Removendo o setimo da lista");
            list.RemoveAt(6);

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("Removendo todos que começam com M");
            list.RemoveAll(x => x[0] == 'M');

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }




        }
    }
}
