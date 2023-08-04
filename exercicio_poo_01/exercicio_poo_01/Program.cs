using exercicio_poo_01;
using System;

Pessoas pessoa1, pessoa2;

pessoa1 = new Pessoas();
pessoa2 = new Pessoas();

Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome: ");
pessoa1.nome = Console.ReadLine();
Console.Write("Idade: ");
pessoa1.idade = int.Parse(Console.ReadLine());


Console.WriteLine("Dados da segunda pessoa:");
Console.Write("Nome: ");
pessoa2.nome = Console.ReadLine(); 
Console.Write("Idade: ");
pessoa2.idade = int.Parse(Console.ReadLine());

if (pessoa2.idade > pessoa2.idade)
{
    Console.WriteLine("Pessoa mais velha: " + pessoa2.nome);
}
else
{
    Console.WriteLine("Pessoa mais velha: " + pessoa1.nome);

}
