using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (list.Find(x => x.Id == id) == null)
                {
                    list.Add(new Employee(id, name, salary));
                }
                else
                {
                    Console.WriteLine("An employee with this id already exists, please insert again");
                    i--;
                }
            }
            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int idForRaise = int.Parse(Console.ReadLine());
            if (list.Find(x => x.Id == idForRaise) != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                list.Find(x => x.Id == idForRaise).IncreaseSalary(percentage);

            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee employee in list)
            {
                Console.WriteLine(employee);
            }


        }
    }
}
