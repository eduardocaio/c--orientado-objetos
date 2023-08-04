using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_poo09
{
    internal class Funcionarios
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public Funcionarios(int Iden, string Nome, double Salario ) {
            id = Iden;
            name = Nome;
            salary = Salario;
        }

        public double Aumento(double Porcento)
        {
            return salary += (Porcento/100) * salary;
        }

        public override string ToString()
        {
            return id + ", " + name + ", " + salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
