using Exercicio_Heranca.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine("Product #" + j + " data:");
                Console.Write("Common, used or imported(c/ u / i)?");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                switch (op)
                {
                    case 'c':
                        products.Add(new Product(name, price)); 
                        break;
                    case 'u':
                        Console.Write("Manufacture date: ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, date));
                        break;
                    case 'i':
                        Console.Write("Cumstoms fee: ");
                        double fee = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(name, price, fee));
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }


        }
    }
}
