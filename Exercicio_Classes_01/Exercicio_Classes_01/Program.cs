using System;

namespace Exercicio_Classes_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person();
            Person B = new Person();

            Console.Write("Digite o nome da pessoa: ");
            A.name = Console.ReadLine();
            Console.Write($"Digite a idade de {A.name}: ");
            A.age = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da pessoa: ");
            B.name = Console.ReadLine();
            Console.Write($"Digite a idade de {A.name}: ");
            B.age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Mais velho: {older(A, B)}");


        }

        static string older(Person A, Person B)
        {
            if (A.age > B.age)
            {
                return A.name;
            }
            else if (A.age < B.age)
            {
                return B.name;
            }
            else
            {
                return "Both have the same age";
            }
        }
    }
}
