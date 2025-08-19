using System;
using System.Globalization;



namespace Ex_03
{
    class Program
    {

        static void Main(string[] args)
        {

            Acount user;

            Console.Write("Informe o numero da conta: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Informe o titular da conta: ");
            string name = Console.ReadLine();   

            Console.Write("Deseja efetuar um deposito inicial ? (s/n)");
            char op = char.Parse(Console.ReadLine());

            if(op == 's')
            {
                
                Console.Write("Informe quanto vc deseja depositar: ");
                double dep = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                user = new Acount(id,name,dep);
                Console.WriteLine(user);
            }
            else
            {
                user = new Acount(id, name);
                Console.WriteLine(user);
            }


            Console.WriteLine("Informe um valor para deposito");
            double deposit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            user.Deposit(deposit);

   
            Console.WriteLine("Dados da conta atualizados:\n" + user);

            Console.WriteLine("Informe um valor para saque");
            double sake = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            user.Sake(sake);


            Console.WriteLine("Dados da conta atualizados:\n" + user);
        }

    }


}


