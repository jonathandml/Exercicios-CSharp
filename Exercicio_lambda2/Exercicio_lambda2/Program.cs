using Exercicio_lambda2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exercicio_lambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path: ");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>();
            using (StreamReader file = File.OpenText(path))
            {
                while (!file.EndOfStream)
                {
                    string[] fields = file.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }
            Console.Write("Enter the salary: ");
            double s = double.Parse(Console.ReadLine());
            //var e1 = employees.Where(e => e.Salary > s).OrderBy(e => e.Email).Select(e => e.Email);
            var e1 = from e in employees
                     where e.Salary > s
                     orderby e.Email
                     select e.Email;
            Console.WriteLine();
            Console.WriteLine("Email of people whose salary is more than " + s.ToString("F2",CultureInfo.InvariantCulture) +": ");
            foreach(string e in e1)
            {
                Console.WriteLine(e);
            }
            //var sum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            var sum = (from e in employees
                       where e.Name[0] == 'M'
                       select e.Salary)
                      .Sum();

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
