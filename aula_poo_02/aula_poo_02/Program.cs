using aula_poo_02;
using System.Globalization;



Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Produto produto = new Produto();

double valorTotal = produto.ValorTotalEmEstoque();

Console.WriteLine();
Console.WriteLine("Dados do produto: " + produto);

Console.WriteLine();
Console.Write("Digite o número de produtos a serem adicionados em estoque: ");
int qte = int.Parse(Console.ReadLine());
produto.AdicionarProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados do produto: " + produto);

Console.WriteLine();
Console.Write("Digite o número de produtos a serem removidos do estoque: ");
qte = int.Parse(Console.ReadLine());
produto.RemoverProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados do produto: " + produto);

