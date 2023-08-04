using System.Globalization;

namespace exercicio_poo09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário # " + i + ":");
                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string Name = Console.ReadLine();
                Console.Write("Salário: ");
                double Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(Id, Name, Salary));

                Console.WriteLine();
            }

            Console.Write("Informe o ID do funcionário que terá o salário aumentado: ");
            int fun = int.Parse(Console.ReadLine());

            Funcionarios empregado = list.Find(x => x.id == fun);

            double percent;

            if (empregado != null)
            {
                Console.Write("Insira a porcentagem: ");
                percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empregado.Aumento(percent);
            }
            else
            {
                Console.WriteLine("Esse ID não existe!");
            }


            foreach(Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }




        }
    }
}