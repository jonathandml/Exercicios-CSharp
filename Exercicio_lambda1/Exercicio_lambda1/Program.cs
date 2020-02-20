using Exercicio_lambda1.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Exercicio_lambda1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path: ");
            string path = Console.ReadLine();
            List<Product> products = new List<Product>();
            try
            {
                using(StreamReader file = File.OpenText(path))
                {
                    while (!file.EndOfStream)
                    {
                        string[] fields = file.ReadLine().Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1],CultureInfo.InvariantCulture);
                        products.Add(new Product(name, price));
                    }
                    //var avg = products.Average(p => p.Price);
                    var avg = (from p in products select p.Price).Average(); 
                    Console.WriteLine("Averege price: " + avg.ToString("F2", CultureInfo.InvariantCulture));
                    //var p1 = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
                    var p1 = from p in products
                             where p.Price < avg
                             orderby p.Name descending
                             select p.Name;
                    foreach(string p in p1)
                    {
                        Console.WriteLine(p);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred!!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
