using Exercicio_enums.Entities;
using Exercicio_enums.Entities.Enums;
using System;

namespace Exercicio_enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, new Client(name, email, birthDate)); 

            Console.Write("How many items to this order ?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #" + (i+1) + " item data");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                order.AddItem(new OrderItem(quantity, price, new Product(pName, price)));
            }
            Console.WriteLine(order);

        }
    }
}
