using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_poo07
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() {

            Saldo = 0.0;

        }  

        public ContaBancaria(int numero, string titular) : this()
        {
            Numero = numero;
            Titular = titular;
  
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public void ValorADepositar(double deposito) {
            Saldo += deposito;
        }

        public void ValorASacar(double saque)
        {
            Saldo = (Saldo - saque) - 5.00;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
