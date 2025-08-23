using System;
using Ex_01.Entities;
using Ex_01.Entities.Enums;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Order
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            // Print the order details
            Console.WriteLine(order.Status);
            string s1 = order.Status.ToString();
            Console.WriteLine(s1);  

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}


