namespace exercicio_poo08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            
            Quartos[] vect = new Quartos[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel " + "#" + i + ": ");
                Console.Write("Nome: ");
                string nome =  Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Quartos { Nome = nome, Email = email };

            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }




        }
    }
}