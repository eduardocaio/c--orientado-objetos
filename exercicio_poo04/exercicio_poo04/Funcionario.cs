using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_poo04
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalarioPorcentagem(double porcent)
        {
            Salario += ((porcent / 100) * Salario);
        }

        public override string ToString()
        {
            return Nome + ", " + "$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
