using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_04.Entities.Enums;


namespace Ex_04.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> OrderList { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem order)
        {
            OrderList.Add(order);
        }

        public void RemoveItem(OrderItem order)
        {
            OrderList.Remove(order);
        }

        public double Total()
        {
            double total = 0.0;
            foreach(OrderItem orderitem in OrderList)
            {
                total +=orderitem.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine("Order items:");
            foreach (OrderItem orderitem in OrderList)
            {
                sb.Append(orderitem.Product.ToString());
                sb.AppendLine(orderitem.ToString());
            }
            sb.AppendLine($"Total price: {Total().ToString("F2")}");
            return sb.ToString();
        }
    }
}
