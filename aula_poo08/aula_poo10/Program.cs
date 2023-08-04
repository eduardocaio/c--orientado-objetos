namespace aula_poo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int soma = 0;


            double[,] mat = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)
                {
                    
                    mat[i, j] = int.Parse(values[j]);

                    if (mat[i, j] < 0.0) {
                        soma++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Main diagonal: ");

            for (int i = 0; i < n; i++)
            {

                Console.Write(mat[i, i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers = " + soma);
        }
    }
}