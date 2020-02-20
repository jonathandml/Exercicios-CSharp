using Exercicio_arquivos.Entities;
using System;
using System.IO;
using System.Globalization;

namespace Exercicio_arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path: ");
            string sourcePath = Console.ReadLine();
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(sourcePath) + @"\out");
                string targetPath = Path.GetDirectoryName(sourcePath) + @"\out\Summary.csv";
                using (StreamReader reader = File.OpenText(sourcePath))
                {
                    using (StreamWriter writer = File.AppendText(targetPath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string[] fields = reader.ReadLine().Split(",");
                            string name =  fields[0];
                            double price = double.Parse(fields[1],CultureInfo.InvariantCulture);
                            int quantity = int.Parse(fields[2]);
                            Product p = new Product(name, price, quantity);
                            writer.WriteLine(p.Name + "," + p.TotalPrice().ToString("F2",CultureInfo.InvariantCulture));
                        }
                        Console.WriteLine("The file was created successfully!!!");
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error operating the file");
                Console.WriteLine(e.Message);
            }
        }
    }
}
