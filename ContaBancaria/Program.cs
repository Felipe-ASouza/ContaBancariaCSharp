using System;
using System.Globalization;

namespace ContaBancaria
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContaBanco banco;
            
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                banco = new ContaBanco(numero, titular, depositoInicial);
            }
            else
            {
                banco = new ContaBanco(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(banco);
        }
    }
}