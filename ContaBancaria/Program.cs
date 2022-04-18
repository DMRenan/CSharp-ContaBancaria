using System;
using System.Globalization;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta contaBancaria;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char escolha = char.Parse(Console.ReadLine());

            if (escolha == 's' || escolha == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new Conta(numero, titular, depositoInicial);
            }
            else contaBancaria = new Conta(numero, titular);

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);
        }
    }
}
