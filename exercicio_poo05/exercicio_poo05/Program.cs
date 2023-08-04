using exercicio_poo05;
using System.Globalization;

Aluno aluno = new Aluno();

Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno:");
aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double restaram = aluno.Restam();


if (aluno.Aprovacao())
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM " + restaram.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
}