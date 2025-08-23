using System;
using Ex_04.Entities;
using Ex_04.Entities.Enums;


namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            
     
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            string status = Console.ReadLine();

            Console.WriteLine("How many itens to this Order ?");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, Enum.Parse<OrderStatus>(status));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Product Name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price:");
                double productPrice = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                Console.WriteLine("Quantity:");
                int quantity = int.Parse(Console.ReadLine());


                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, product.Price,product);
                order.AddItem(orderItem);
                
            }

            Console.WriteLine(client);
            Console.WriteLine(order);
            

        }
    }

}