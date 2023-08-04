using System.Globalization;

namespace exercicio_poo07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposito;

            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string verificacao = Console.ReadLine();
            
            if(verificacao == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria( numero, titular, deposito);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.ValorADepositar(deposito);

            Console.WriteLine();


            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();


            conta.ValorASacar(saque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);


        }
    }
}