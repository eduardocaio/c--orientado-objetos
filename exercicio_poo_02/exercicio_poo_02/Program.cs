using exercicio_poo_02;
using System.Globalization;

Funcionarios funcionario1, funcionario2;

funcionario1 = new Funcionarios();
funcionario2 = new Funcionarios();

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
funcionario1.nome = Console.ReadLine();
Console.Write("Salário: ");
funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
funcionario2.nome = Console.ReadLine();
Console.Write("Salário: ");
funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double mediaSalario = (funcionario1.salario + funcionario2.salario) / 2;

Console.WriteLine("Salário médio = " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));
