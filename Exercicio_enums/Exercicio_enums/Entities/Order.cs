using Exercicio_enums.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_enums.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach(OrderItem i in Items)
            {
                sum += i.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder summary = new StringBuilder();
            summary.AppendLine("ORDER SUMMARY: ");
            summary.AppendLine("Order Status: " + Status.ToString());
            summary.Append("Client: " + Client.Name);
            summary.Append(" (" + Client.BirthDate.ToString("dd:MM:yyyy") +") - ");
            summary.AppendLine(Client.Email);
            summary.AppendLine("Order items: ");
            foreach (OrderItem i in Items)
            {
                summary.AppendLine(i.ToString());
            }
            summary.AppendLine("Total price: $" + Total().ToString("F2",CultureInfo.InvariantCulture));
            return summary.ToString();

        }
    }
}
