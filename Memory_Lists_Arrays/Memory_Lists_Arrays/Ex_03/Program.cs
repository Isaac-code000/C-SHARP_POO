using System;


namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("How many rooms will be rented:");
            int quant = int.Parse(Console.ReadLine());
            Rooms[] rooms = new Rooms[10];

            for (int i = 0; i < quant;i++)
            {
                Console.WriteLine("Rent:#" + (i+1));
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();
                Console.Write("Room:");
                int room = int.Parse(Console.ReadLine());

                Tenant tenant = new Tenant(name, email);

                if(rooms[room]!=null)
                {
                    Console.WriteLine("Room occupied, please inform another;");
                    i--;
                    continue;
                }
                else
                {
                    rooms[room] = new Rooms(tenant,room); 
                }

                

            }

            for (int i = 0; i < 10;i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(rooms[i]);
                }
            }
        }
    }
}