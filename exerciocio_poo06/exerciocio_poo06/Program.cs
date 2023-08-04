using System.Globalization;

namespace exerciocio_poo06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Total = ConversorDeMoeda.ValorASerPago(cotacao, qte);

            Console.WriteLine("Valor a ser pago em reais = " + Total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}