using System;

namespace ExercicioEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o número da conta: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string holder = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char op = char.Parse(Console.ReadLine());
            Account acc = new Account(number,holder);
            if(op == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                acc.Deposit(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(acc);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            acc.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(acc);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            acc.Withdraw(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(acc);


        }
    }
}
